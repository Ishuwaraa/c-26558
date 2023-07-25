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
        /*Q2.
        static void Main(string[] args)
        {
            Console.Write("enter a string: ");
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();
            int vowels = 0;

            for(int i = 0; i<letters.Length; i++)
            {
                if (letters[i] == 'a' || letters[i] == 'A') 
                    vowels++;
                if (letters[i] == 'e' || letters[i] == 'E') 
                    vowels++;
                if (letters[i] == 'i' || letters[i] == 'I') 
                    vowels++;
                if (letters[i] == 'o' || letters[i] == 'O') 
                    vowels++;
                if (letters[i] == 'u' || letters[i] == 'U') 
                    vowels++;    
            }
            Console.WriteLine("no of vowels: " + vowels);

            Console.ReadLine();
        }*/

        /*Q3.
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int temp = number; temp != 0; temp /= 10)
            {
                int digit = temp % 10;
                sum += digit;
            }

            Console.WriteLine("Sum of digits: " + sum);

            Console.ReadLine();
        }*/

        /*Q4.
        static void Main(string[] args)
        {
            Console.Write("enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, odds = 0;

            for(int temp=num; temp!=0; temp /= 10)
            {
                int digit = temp % 10;
                if(digit%2 != 0)
                    sum += digit;
            }
            Console.Write("sum of odds: " + sum);
            Console.ReadLine();
        }*/
    }
}
