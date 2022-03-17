using System.Collections;

namespace Beavproc.Abstractions.Registers;

public interface IRegister
{
    public BitArray Data { get; }
}