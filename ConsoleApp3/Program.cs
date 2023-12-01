using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Enumerable.Range(0,100000000).ToArray(); 
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            FindMaxAverage(nums,4);
            sw.Stop();
            Console.WriteLine("MaxAverage: " + FindMaxAverage(nums, 4));
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            Console.ReadLine();
            
        }
        public static double FindMaxAverage(int[] nums, int k)
        {
            int left = 0;
            int right = k-1;
            double val = 0;
            double secval = 0;

            for (int i = left; i < right+1; i++)
            {
                secval += nums[i];
            }
            val = secval;


            for (int i = 0; i < nums.Length - k ; i++)
            {
                secval -= nums[left];
                left++;
                right++;
                secval += nums[right];
                if (secval > val || val == 0)
                {
                    val = secval;
                }
            }
            return val/k;
        }
    }
}
