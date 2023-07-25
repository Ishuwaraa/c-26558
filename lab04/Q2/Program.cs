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
            Console.Write("enter the radius value: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues circle = new FindValues();
            double ansArea = circle.findArea(radius);
            double ansCircum = circle.findCircumference(radius);

            Console.WriteLine("area of the circle: " + ansArea);
            Console.WriteLine("circumference of the circle: " + ansCircum);

            Console.ReadLine();
        }

    }
}
