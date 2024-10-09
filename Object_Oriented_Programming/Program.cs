using Object_Oriented_Programming;

Methods methods = new Methods();
/* 1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.  */
Console.WriteLine("Question1: ");

int[] numbers = methods.GenerateNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

methods.Reverse(numbers);

methods.PrintNumbers(numbers);


/* 2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5. This keeps going forever.
The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
Because one number is defined by the numbers before it, this sets up a perfect
opportunity for using recursion.
Your mission, should you choose to accept it, is to create a method called Fibonacci, which
takes in a number and returns that number of the Fibonacci sequence. So if someone calls
Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
someone calls Fibonacci(8), it would return 21.
In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
sequence and print them out.
Hint #1:Start with your base case. We know that if it is the 1st or 2nd number, the value will
be 1.
Hint #2:For every other item, how is it defined in terms of the numbers before it? Can you
come up with an equation or formula that calls the Fibonaccimethod again?   */
Console.WriteLine("Question2: ");

int num = 10;
Console.Write($"The fisrt {num} numbers of Fiboncci sequence are: ");
for (int i = 0; i < num; i++)
{
    Console.Write(methods.FiBonacci(i) + " ");
}
Console.WriteLine();


// Designing and Building Classes using object-oriented principles
/* 7. ry creating the two classes below, and make a simple program to work with them */
Color color1 = new Color(10, 10, 10);
Color color2 = new Color(123, 123, 123);
Color color3 = new Color(200, 200, 200);

Ball ball1 = new Ball(5, color1, 0);
Ball ball2 = new Ball(5, color2, 0);
Ball ball3 = new Ball(5, color3, 0);

ball1.Throw();
ball2.Throw();
ball3.Throw();
ball1.Throw();
ball2.Throw();

ball2.Pop();
ball2.Throw();

Console.WriteLine("ball1 has been thrown " + ball1.GetTheTimesOfThrow() + " times.");
Console.WriteLine("ball2 has been thrown " + ball2.GetTheTimesOfThrow() + " times.");
Console.WriteLine("ball3 has been thrown " + ball3.GetTheTimesOfThrow() + " times.");