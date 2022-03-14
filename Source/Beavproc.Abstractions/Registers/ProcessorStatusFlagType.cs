namespace Beavproc.Abstractions.Registers;

public enum ProcessorStatusFlagType : byte
{
    Unused,
    Negative,
    Overflow,
    Break,
    Decimal,
    Interrupt,
    Zero,
    Carry
}