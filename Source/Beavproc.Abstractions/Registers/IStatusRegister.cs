namespace Beavproc.Abstractions.Registers;

public interface IStatusRegister
{
    public ProcessorStatusFlagValue this[ProcessorStatusFlagType flag] { get; set; }
}