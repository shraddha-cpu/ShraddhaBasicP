using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShraddhaBasicP
{
    internal class Program
    {                          //find entered number prime or not
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("enter the number");
            int i = Convert.ToInt32(Console.ReadLine());
            for(int j = 1; j<=i; j++)
            {
                if(i%j==0)
                {
                    k++;
                }
            }     
            if(k==2)
            {
                Console.WriteLine("is prime number");
            }
            else
            {
                Console.WriteLine("is not primr number");
            }
        }
    }
}
