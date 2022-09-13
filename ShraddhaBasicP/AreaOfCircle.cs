using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShraddhaBasicP
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("enter the radius");
                r=Convert.ToInt32(Console.ReadLine());
                A=(3.14)*r* r;
            Console.WriteLine("the area of circle of radius="+A);
        }
    }
}
