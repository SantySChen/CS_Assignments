/* 1. FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/. */

using Chapter03;

Console.WriteLine("Question1:");
//Create a console application in Chapter03 named Exercise03 that outputs a simulated
//FizzBuzz game counting up to 100.
int max = 100;
Exercise03 exercise03 = new Exercise03();
exercise03.FizzBuzz(max);


//max = 500;
//for(byte i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}

// Result: It will never end the processing.
/* We can add the following code: 
 * if(max > byte.MaxValue)
 * {
 *    Console.WriteLine("Warning: max exceeds the range.")
 * } */

/* 2. Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars. */
Console.WriteLine("Question2:");
int row = 5;

exercise03.Print_a_Pyramid(row);

/* 3. Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). */
Console.WriteLine("Question3:");

Console.WriteLine("Guess a number from 1 to 3");

string guessNum = Console.ReadLine();
int guessedNumber = int.Parse(guessNum);

exercise03.GuessNum(guessedNumber);

/* 4. Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); . */
Console.WriteLine("Question4:");

Console.WriteLine("Enter your birth year:");
int year = int.Parse(Console.ReadLine());

Console.WriteLine("month:");
int month = int.Parse(Console.ReadLine());

Console.WriteLine("day:");
int day = int.Parse(Console.ReadLine());

DateTime nextAn;
exercise03.CalculateDays(year, month, day, out nextAn);

Console.WriteLine($"The date of next Anniversity is on {nextAn.ToString("d")}.");


/* 5. Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach).  */
Console.WriteLine("Question5:");

DateTime currentTime = DateTime.Now;

exercise03.Greets(currentTime);

/* 6. Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.  */
Console.WriteLine("Question6:");

for(int i = 1; i <= 4; i++)
{
    for(int j = 0; j <= 24; j++)
    {
        if (j % i != 0)
            continue;
        if (j == 24)
            Console.Write(j);
        else
            Console.Write($"{j},");
    }
    Console.WriteLine();
}