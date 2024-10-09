using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Methods
    {
        public int[] GenerateNumbers(params int[] arr)
        {
            return arr;
        }

        public void Reverse(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            } 
                
        }

        public void PrintNumbers(int[] nums)
        {
            Console.WriteLine(string.Join(", ", nums));
        }


        public int FiBonacci(int num)
        {
            if (num == 0 || num == 1) return 1;

            return FiBonacci(num - 1) + FiBonacci(num - 2);
        }
    }
}
