using Beavproc.Abstractions.Registers;

namespace Beavproc.Abstractions;

public interface ICpu
{
    public IDictionary<string, IRegister> Registers { get; }
    public IStatusRegister StatusRegister { get; }
    public void Initialize();
}