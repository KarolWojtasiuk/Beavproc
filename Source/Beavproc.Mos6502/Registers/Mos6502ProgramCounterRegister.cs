using System.Collections;
using Beavproc.Abstractions.Registers;

namespace Beavproc.Mos6502.Registers;

public class Mos6502ProgramCounterRegister : IProgramCounterRegister
{
    private readonly BitArray _flags = new(16);
}