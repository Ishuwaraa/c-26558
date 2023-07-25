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
        /*Q1.
        static void Main()
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your batch number: ");
            double batch = double.Parse(Console.ReadLine());

            Console.WriteLine(name);
            Console.WriteLine(batch);

            Console.ReadLine();
        }*/

        /*Q2.
        static void Main(string[] args)
        {
            Console.Write("enter the radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * Math.Pow(radius, 2);
            Console.WriteLine("area: " + area);

            Console.ReadLine();
        }*/

        /*Q3.
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("sum: " +sum);

            Console.ReadLine();
        }*/

        /*Q4.
        static void Main(string[] args)
        {
            Console.Write("enter the salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("enter the tax rate(%): ");
            double rate = double.Parse(Console.ReadLine());

            double ans = salary - (salary * rate/100);
            Console.WriteLine("final salary: $" + ans);

            Console.ReadLine();
        }*/
    }
}
