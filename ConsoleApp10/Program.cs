using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];

                }
            }
            Console.WriteLine(sum);
        }
    }
}
