using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array
    {
        public void myArray()
        {
            double[] array = new double[10];
            double min = 10000, max = 0, total = 0, avg;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter no" + (i + 1) + ": ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                total += array[i];

                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            avg = total / 10;

            Console.WriteLine("min value: " + min);
            Console.WriteLine("max value: " + max);
            Console.WriteLine("average value: " + avg);
        }

    }
}
