using System.Collections;

namespace Beavproc.Abstractions.Registers;

public class Register : IRegister
{
    public Register(int size)
    {
        Data = new BitArray(size);
    }

    public BitArray Data { get; }
}