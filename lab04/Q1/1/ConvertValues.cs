using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("enter the value in kms: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double m = 1000 * km;
            Console.WriteLine("distance in meters: " + m + "m");
        }

    }
}
