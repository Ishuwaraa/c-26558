using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("enter array size: ");
            int size = int.Parse(Console.ReadLine());

            Class1 objClass = new Class1();
            objClass.myArray(size);
            

            Console.ReadLine();
        }

    }
}
