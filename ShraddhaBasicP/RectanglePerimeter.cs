using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShraddhaBasicP
{
    internal class RectanglePerimeter
    {
        static void Main(string[] args)
        {
            float l;
            float b;
            float perimeter;
            Console.WriteLine("enter the value of length");
            l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of breadth");
            b=Convert.ToInt32(Console.ReadLine());
            perimeter=2*(l+b);
            Console.WriteLine("perimeter of rectangle"+perimeter);
        }
    }
}
