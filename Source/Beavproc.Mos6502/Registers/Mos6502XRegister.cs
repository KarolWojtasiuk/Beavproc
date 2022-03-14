using System.Collections;
using Beavproc.Abstractions.Registers;

namespace Beavproc.Mos6502.Registers;

public class Mos6502XRegister : IIndexRegister
{
    private readonly BitArray _flags = new(8);
}