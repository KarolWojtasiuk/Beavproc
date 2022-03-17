using Beavproc.Abstractions;
using Beavproc.Abstractions.Registers;
using Beavproc.Mos6502.Registers;

namespace Beavproc.Mos6502;

public class Mos6502Cpu : ICpu
{
    private readonly IMemory _memory;

    public Mos6502Cpu(IMemory memory)
    {
        _memory = memory;
    }

    public IDictionary<string, IRegister> Registers { get; } = new Dictionary<string, IRegister>
    {
        [Mos6502RegisterNames.Accumulator] = new Register(8),
        [Mos6502RegisterNames.IndexX] = new Register(8),
        [Mos6502RegisterNames.IndexY] = new Register(8),
        [Mos6502RegisterNames.ProcessorStatus] = new Mos6502StatusRegister(),
        [Mos6502RegisterNames.StackPointer] = new Register(8),
        [Mos6502RegisterNames.ProgramCounter] = new Register(16),
    };

    public IStatusRegister StatusRegister => (IStatusRegister)Registers[Mos6502RegisterNames.ProcessorStatus];

    public void Initialize()
    {
        const int memorySize = 64 * 1024 * 8; //64 KiB
        const short resetAddress = 0xFFC;

        //TODO: Investigate if Mos6502 can work on less memory
        if (_memory.Data.Length != memorySize)
            throw new InvalidOperationException($"{nameof(Mos6502Cpu)} must have a 64 KiB of a memory");

        StatusRegister[ProcessorStatusFlagType.Interrupt] = true;
        Registers[Mos6502RegisterNames.ProgramCounter].Data.SetValue(BitMath.ToBitArray(resetAddress));
    }
}