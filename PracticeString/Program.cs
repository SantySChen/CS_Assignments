/* 1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly. */

using PracticeString;

Console.WriteLine("Question1: ");

int[] initialArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
int[] firstArray = new int[10];
initialArray.CopyTo( firstArray, 0 );
Console.WriteLine("firstArray:");
Console.WriteLine(string.Join(", ", firstArray));

int[] secondArray = new int[initialArray.Length];
for (int i = 0; i < initialArray.Length; i++)
{
    secondArray[i] = initialArray[i];
}
Console.WriteLine("secondArray:");
Console.WriteLine(string.Join(", ", secondArray));

/* 2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear.  
Your program should read in the user's input and determine if it begins with a “+” or “-“ or
if it is simply “—“ . In the first two cases, your program should add or remove the string
given ("some item" in the example). If the user enters just “—“ then the program should
clear the current list.  */
Console.WriteLine("Question2: ");
ArrayMethod method = new ArrayMethod();
method.ListManager();

/* 3. Write a method that calculates all prime numbers in given range and returns them as array
of integers */
Console.WriteLine("Question3: ");
int[] primes = method.FindPrimesInRange(5, 67);
Console.WriteLine(string.Join(", ", primes));

/* 4. Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1  */
Console.WriteLine("Question4: ");

Console.WriteLine("Enter an array separated by space: ");
string input = Console.ReadLine();
string[] inputStrArr = input.Split(' ');
int[] inputIntArr = Array.ConvertAll(inputStrArr, int.Parse);

Console.WriteLine("Enter the rotate times: ");
int times = int.Parse(Console.ReadLine());

int[] rotateSum = method.RotateArray(inputIntArr, times);
Console.WriteLine(string.Join(", ", rotateSum));

/* 5. Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.  */
Console.WriteLine("Question5: ");

Console.WriteLine("Enter an array separated by space: ");
string input2 = Console.ReadLine();
string[] inputStrArr2 = input2.Split(' ');
int[] inputIntArr2 = Array.ConvertAll(inputStrArr2, int.Parse);

int[] findLongestSequence = method.FindTheLongestSequence(inputIntArr2);
Console.WriteLine(string.Join(", ", findLongestSequence));

/* 7. Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them  */
Console.WriteLine("Question7: ");

Console.WriteLine("Enter an array separated by space: ");
string input3 = Console.ReadLine();
string[] inputStrArr3 = input3.Split(' ');
int[] inputIntArr3 = Array.ConvertAll(inputStrArr3, int.Parse);

int result = method.FindMostFrequentNumber(inputIntArr3);
Console.WriteLine($"The leftmost most frequent number in this array is {result}");