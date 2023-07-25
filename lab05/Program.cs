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
        //Q3.Can’t access it due to the method type being private.
        //Private method can only be accessed within the class where they are defined.
        static void Main(string[] args)
        {
            Array array = new Array();
            array.myArray();

            Console.ReadLine();
        }

    }
}
