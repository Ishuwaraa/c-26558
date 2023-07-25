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
            Console.Write("enter the value in kms: ");
            double km = Convert.ToDouble(Console.ReadLine());

            ConvertValues distance = new ConvertValues();
            double m = distance.kilometerTOmeter(km);

            Console.WriteLine("distance in meters: " + m + "m");

            Console.ReadLine();
        }



    }
}
