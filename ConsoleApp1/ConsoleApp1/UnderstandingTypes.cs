namespace ConsoleApp1;

public class UnderstandingTypes {
    public void TypeInfo()
    {
        int sizeSbyte = sizeof(sbyte);
        sbyte minValueSbyte = sbyte.MinValue;
        sbyte maxValueSbyte = sbyte.MaxValue;
        
        Console.WriteLine($"Sbyte has size of {sizeSbyte}, minimum value of {minValueSbyte} and maximum value of {maxValueSbyte}");
        
        int sizeByte = sizeof(byte);
        byte minValueByte = byte.MinValue;
        byte maxValueByte = byte.MaxValue;
        
        Console.WriteLine($"Byte has size of {sizeByte}, minimum value of {minValueByte} and maximum value of {maxValueByte}");
        
        int sizeShort = sizeof(short);
        short minValueShort = short.MinValue;
        short maxValueShort = short.MaxValue;
        
        Console.WriteLine($"Short has size of {sizeShort}, minimum value of {minValueShort} and maximum value of {maxValueShort}");
        
        int sizeUshort = sizeof(ushort);
        ushort minValueUshort = ushort.MinValue;
        ushort maxValueUshort = ushort.MaxValue;
        
        Console.WriteLine($"Ushort has size of {sizeUshort}, minimum value of {minValueUshort} and maximum value of {maxValueUshort}");
        
        int sizeInt = sizeof(int);
        int minValueInt = int.MinValue;
        int maxValueInt = int.MaxValue;
        
        Console.WriteLine($"Integer has size of {sizeInt}, minimum value of {minValueInt} and maximum value of {maxValueInt}");
        
        int sizeUint = sizeof(uint);
        uint minValueUint = uint.MinValue;
        uint maxValueUint = uint.MaxValue;
        
        Console.WriteLine($"Uint has size of {sizeUint}, minimum value of {minValueUint} and maximum value of {maxValueUint}");
        
        int sizeLong = sizeof(long);
        long minValueLong = long.MinValue;
        long maxValueLong = long.MaxValue;
        
        Console.WriteLine($"Long has size of {sizeLong}, minimum value of {minValueLong} and maximum value of {maxValueLong}");
        
        int sizeUlong = sizeof(ulong);
        ulong minValueUlong = ulong.MinValue;
        ulong maxValueUlong = ulong.MaxValue;
        
        Console.WriteLine($"Ulong has size of {sizeUlong}, minimum value of {minValueUlong} and maximum value of {maxValueUlong}");
        
        int sizeFloat = sizeof(float);
        float minValueFloat = float.MinValue;
        float maxValueFloat = float.MaxValue;
        
        Console.WriteLine($"Float has size of {sizeFloat}, minimum value of {minValueFloat} and maximum value of {maxValueFloat}");
        
        int sizeDouble = sizeof(double);
        double minValueDouble = double.MinValue;
        double maxValueDouble = double.MaxValue;
        
        Console.WriteLine($"Double has size of {sizeDouble}, minimum value of {minValueDouble} and maximum value of {maxValueDouble}");
        
        int sizeDecimal = sizeof(decimal);
        decimal minValueDecimal = decimal.MinValue;
        decimal maxValueDecimal = decimal.MaxValue;
        
        Console.WriteLine($"Decimal has size of {sizeDecimal}, minimum value of {minValueDecimal} and maximum value of {maxValueDecimal}");
      
    }

    public void ConvertCenturies(int centuries)
    {
        int years = centuries * 100;
        int days = years * 365;
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 100;
        long microseconds = milliseconds * 100;
        long nanoseconds = microseconds * 100;
        
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours ={minutes} minutes = {seconds} seconds ={milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        
    }
}