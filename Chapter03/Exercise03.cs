using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise03
    {
        public void FizzBuzz(int max)
        {
            for(int i = 0; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuss");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
                else 
                    Console.WriteLine(i);
            }

        }

        public void GuessNum(int num)
        {
            int correctNumber = new Random().Next(3) + 1;
            if (num == correctNumber)
                Console.WriteLine("Correct");
            else if (num < correctNumber)
                Console.WriteLine("guess low");
            else
                Console.WriteLine("guess high");
        }

        public void Print_a_Pyramid(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                // print spaces
                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }

                // print *
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void CalculateDays(int year, int month, int day, out DateTime nextAn)
        {
            DateTime birthday = new DateTime(year, month, day);
            DateTime today = DateTime.Now;
            TimeSpan age = today - birthday;

            Console.WriteLine($"The person is {age.Days} days old.");

            int daysToNextAnniversary = 1000 - (age.Days % 1000);
            nextAn = today.AddDays(daysToNextAnniversary);

        }

        public void Greets(DateTime time)
        {
            int timeHour = time.Hour;

            switch (timeHour)
            {
                case >= 5 and < 12:
                    Console.WriteLine("Good Morning");
                    break;
                case >= 12 and < 18:
                    Console.WriteLine("Good Afternoon");
                    break;
                case >= 18 and < 22:
                    Console.WriteLine("Good Evening");
                    break;
                case >= 22 or < 5:
                    Console.WriteLine("Good Night");
                    break; 
            }
        }
    }
}
