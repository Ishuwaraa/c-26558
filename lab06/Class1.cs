using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public void myArray(int size)
        {
            int[] array = new int[size];

            for(int i=0; i<size/2; i++)
            {
                Console.Write("enter " +(i+1)+  " input: ");
                int input = int.Parse(Console.ReadLine());
                array[i * 2] = input;
                array[i * 2 + 1] = 0;
                
            }
            
            for(int i=0; i<size; i++)
            {
                Console.Write(array[i] +" ");
                
            }
        }
    }
}
