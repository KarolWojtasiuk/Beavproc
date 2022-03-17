using System.Collections;

namespace Beavproc.Abstractions;

public static class BitMath
{
    public static BitArray ToBitArray(short number)
    {
        var byteValue = BitConverter.GetBytes(number);
        return new BitArray(byteValue);
    }

    public static void SetValue(this BitArray target, BitArray newValue)
    {
        if (newValue.Length != target.Length) throw new ArgumentOutOfRangeException(nameof(newValue), "Array differs in size from the target");

        foreach (var i in Enumerable.Range(0, target.Length)) target[i] = newValue[i];
    }
}