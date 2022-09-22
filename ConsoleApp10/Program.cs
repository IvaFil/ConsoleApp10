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
            double[] arr = new double[10];

            Console.WriteLine("Введи максимальный элемент: ");
            double min = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи минимальный элемент: ");
            double max = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().NextDouble();
            }

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];

                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            sum = max - min;
            Console.WriteLine(sum);
        }
    }
}
