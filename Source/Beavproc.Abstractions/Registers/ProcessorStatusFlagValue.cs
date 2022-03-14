namespace Beavproc.Abstractions.Registers;

public record ProcessorStatusFlagValue(bool Value = false)
{
    public bool Value { get; set; } = Value;

    public static implicit operator ProcessorStatusFlagValue(bool value) => new(value);
    public static implicit operator bool(ProcessorStatusFlagValue value) => value.Value;
}