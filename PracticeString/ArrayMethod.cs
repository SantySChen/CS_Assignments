using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticeString
{
    internal class ArrayMethod
    {
        public void ListManager()
        {
            List<string> to_do = new List<string>();
            string inputCommand;

            while (true)
            {
                if (to_do.Count > 0)
                {
                    Console.Write("The current to do list: ");
                    Console.WriteLine(string.Join(", ", to_do));
                }
                else
                {
                    Console.WriteLine("The list is Empty.");
                }

                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                inputCommand = Console.ReadLine();

                switch (inputCommand)
                {
                    case "+":
                        Console.WriteLine("Enter what to do: ");
                        string inputToDo = Console.ReadLine();
                        to_do.Add(inputToDo);
                        break;
                    case "-":
                        Console.WriteLine("Choose which to be removed:");
                        string inputToRemove = Console.ReadLine();
                        if (to_do.Remove(inputToRemove))
                            Console.WriteLine("Has been removed.");
                        else
                            Console.WriteLine("Can not find it.");
                        break;
                    case "--":
                        to_do.Clear();
                        break;
                    default:
                        Console.WriteLine("End the list manage.");
                        return;

                }
            }
        }

        public int[] FindPrimesInRange(int starNum, int endNum)
        {
            List<int> primeList = new List<int>();  
            for (int i = starNum; i <= endNum; i++)
            {
                if(IsPrime(i)) primeList.Add(i);
            }
            return primeList.ToArray();
        }

        // check whether the number is prime
        public bool IsPrime(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if(num % i == 0) return false;
            }
            return true;
        }

        public int[] RotateArray(int[] array, int k)
        {
            int n = array.Length;
            int[] sum = new int[n];

            for (int i = 1; i <= k; i++)
            {
                int[] temp = new int[n];
                array.CopyTo(temp, 0);
                ReverseArray(temp, 0, n - 1);
                ReverseArray(temp, 0, i - 1);
                ReverseArray(temp, i, n - 1);
                for(int j = 0; j < n; j++)
                {
                    sum[j] += temp[j];
                }
                
            }
            return sum;
        }

        // reverse the array from start to end
        public void ReverseArray(int[] arr, int start, int end)
        {
            while(start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

        }

        public int[] FindTheLongestSequence(int[] arr)
        {
            int longestStart = 0, curStart = 0, longestLength = 0;
            
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    if(i - curStart + 1 > longestLength)
                    {
                        longestLength = i - curStart + 1;
                        longestStart = curStart;
                    }
                }    
                else
                {
                    curStart = i;
                }
                
            }

            int[] result = new int[longestLength];

            for(int j = 0; j < longestLength; j++)
            {
                result[j] = arr[longestStart++];
            }
            return result;
        }

        public int FindMostFrequentNumber(int[] arr)
        {
            Dictionary<int, int> countDic = new Dictionary<int, int>();
            int max = 0;

            foreach(int i in arr)
            {
                if (countDic.ContainsKey(i)) countDic[i]++;
                else countDic[i] = 1;

                max = Math.Max(max, countDic[i]);
            }

            foreach(int i in arr)
            {
                if (countDic[i] == max) return i;
            }

            return -1;
        }
    }
}
