namespace Beavproc.Abstractions.Registers;

public class NotSupportedProcessorStatusFlagException : Exception
{
    public NotSupportedProcessorStatusFlagException(ProcessorStatusFlagType flag)
        : base($"Not supported flag '{flag}'")
    {
    }
}