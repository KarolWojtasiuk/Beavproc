namespace Beavproc.Abstractions.Registers;

public interface IStatusRegister : IRegister
{
    public bool this[ProcessorStatusFlagType flag] { get; set; }
}