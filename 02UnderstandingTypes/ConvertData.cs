using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class ConvertData
    {
        public void ConvertIntegerToDate(ref int i)
        {
            double years = i * 100;
            double days = i * (355 * 100 + Math.Floor(years/4));
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            BigInteger milliseconds = new BigInteger(seconds) * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{i} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} secondes = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            
        }
    }
}
