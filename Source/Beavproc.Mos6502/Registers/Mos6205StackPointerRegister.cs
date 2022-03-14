using System.Collections;
using Beavproc.Abstractions.Registers;

namespace Beavproc.Mos6502.Registers;

public class Mos6205StackPointerRegister : IStackPointerRegister
{
    private readonly BitArray _flags = new(8);
}