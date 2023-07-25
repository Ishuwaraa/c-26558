using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            double ansArea = 3.14 * radius * radius;
            return ansArea = Math.Round(ansArea, 2, MidpointRounding.AwayFromZero);
        }

        public double findCircumference(double radius)
        {
            double ansCircum = 2 * 3.14 * radius;
            return ansCircum = Math.Round(ansCircum, 2);
        }



    }
}
