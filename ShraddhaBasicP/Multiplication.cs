using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShraddhaBasicP
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            int n1, n2, mul = 0, i;
            Console.WriteLine("enter first no");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no");
            n2= Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n2;i++)
            {
                mul= (mul + n1);
            }
            Console.WriteLine("multiplication of"+n1+" and "+n2+"is"+mul);
        }
    }
}
