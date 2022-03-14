using Beavproc.Abstractions;
using Beavproc.Abstractions.Registers;
using Beavproc.Mos6502.Registers;

namespace Beavproc.Mos6502;

public class Mos6502Cpu : ICpu
{
    public IStatusRegister StatusRegister { get; } = new Mos6502StatusRegister();
    public IAccumulatorRegister AccumulatorRegister { get; } = new Mos6502AccumulatorRegister();
    public IIndexRegister XRegister { get; } = new Mos6502XRegister();
    public IIndexRegister YRegister { get; } = new Mos6502YRegister();
    public IStackPointerRegister StackPointerRegister { get; } = new Mos6205StackPointerRegister();
    public IProgramCounterRegister ProgramCounterRegister { get; } = new Mos6502ProgramCounterRegister();
}