using System.Collections;
using Beavproc.Abstractions.Registers;

namespace Beavproc.Mos6502.Registers;

public class Mos6502StatusRegister : IStatusRegister
{
    public BitArray Data { get; } = new(8);

    public bool this[ProcessorStatusFlagType flag]
    {
        get => Data.Get(ConvertFlagToBitIndex(flag));
        set => Data.Set(ConvertFlagToBitIndex(flag), value);
    }

    private static int ConvertFlagToBitIndex(ProcessorStatusFlagType flag)
    {
        return flag switch
        {
            ProcessorStatusFlagType.Negative => 0,
            ProcessorStatusFlagType.Overflow => 1,
            ProcessorStatusFlagType.Unused => 2,
            ProcessorStatusFlagType.Break => 3,
            ProcessorStatusFlagType.Decimal => 4,
            ProcessorStatusFlagType.Interrupt => 5,
            ProcessorStatusFlagType.Zero => 6,
            ProcessorStatusFlagType.Carry => 7,
            _ => throw new NotSupportedProcessorStatusFlagException(flag)
        };
    }
}