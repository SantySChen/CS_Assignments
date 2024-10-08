using _02UnderstandingTypes;

/* 1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal. */
Console.WriteLine($"{"Type",-10} {"Bytes",-10} {"Min Value",-30} {"Max Value",-30}");
Console.WriteLine(new string('-', 80));

// sbyte
Console.WriteLine($"{"sbyte",-10} {sizeof(sbyte),-10} {sbyte.MinValue,-30} {sbyte.MaxValue,-30}");

// byte
Console.WriteLine($"{"byte",-10} {sizeof(byte),-10} {byte.MinValue,-30} {byte.MaxValue,-30}");

// short
Console.WriteLine($"{"short",-10} {sizeof(short),-10} {short.MinValue,-30} {short.MaxValue,-30}");

// ushort
Console.WriteLine($"{"ushort",-10} {sizeof(ushort),-10} {ushort.MinValue,-30} {ushort.MaxValue,-30}");

// int
Console.WriteLine($"{"int",-10} {sizeof(int),-10} {int.MinValue,-30} {int.MaxValue,-30}");

// uint
Console.WriteLine($"{"uint",-10} {sizeof(uint),-10} {uint.MinValue,-30} {uint.MaxValue,-30}");

// long
Console.WriteLine($"{"long",-10} {sizeof(long),-10} {long.MinValue,-30} {long.MaxValue,-30}");

// ulong
Console.WriteLine($"{"ulong",-10} {sizeof(ulong),-10} {ulong.MinValue,-30} {ulong.MaxValue,-30}");

// float
Console.WriteLine($"{"float",-10} {sizeof(float),-10} {float.MinValue,-30} {float.MaxValue,-30}");

// double
Console.WriteLine($"{"double",-10} {sizeof(double),-10} {double.MinValue,-30} {double.MaxValue,-30}");

// decimal
Console.WriteLine($"{"decimal",-10} {sizeof(decimal),-10} {decimal.MinValue,-30} {decimal.MaxValue,-30}");

/* 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows! */
ConvertData convertData = new ConvertData();
int centuries = 1;
convertData.ConvertIntegerToDate(ref centuries);
centuries = 5;
convertData.ConvertIntegerToDate(ref centuries);





