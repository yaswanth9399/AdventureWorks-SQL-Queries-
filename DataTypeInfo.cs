using System;

class DataTypeInfo
{
    public static void Run()
    {
        Console.WriteLine("Data Type Information\n");
        
        Console.WriteLine($"sbyte  : {sizeof(sbyte)} bytes, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
        Console.WriteLine($"byte   : {sizeof(byte)} bytes, Min: {byte.MinValue}, Max: {byte.MaxValue}");
        Console.WriteLine($"short  : {sizeof(short)} bytes, Min: {short.MinValue}, Max: {short.MaxValue}");
        Console.WriteLine($"ushort : {sizeof(ushort)} bytes, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
        Console.WriteLine($"int    : {sizeof(int)} bytes, Min: {int.MinValue}, Max: {int.MaxValue}");
        Console.WriteLine($"uint   : {sizeof(uint)} bytes, Min: {uint.MinValue}, Max: {uint.MaxValue}");
        Console.WriteLine($"long   : {sizeof(long)} bytes, Min: {long.MinValue}, Max: {long.MaxValue}");
        Console.WriteLine($"ulong  : {sizeof(ulong)} bytes, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
        Console.WriteLine($"float  : {sizeof(float)} bytes, Min: {float.MinValue}, Max: {float.MaxValue}");
        Console.WriteLine($"double : {sizeof(double)} bytes, Min: {double.MinValue}, Max: {double.MaxValue}");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
    }
}
