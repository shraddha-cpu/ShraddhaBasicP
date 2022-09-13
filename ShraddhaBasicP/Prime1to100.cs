using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShraddhaBasicP
{
    internal class Prime1to100
    {                               //to find 1-100 prime no.
        static void Main(string[] args)
        {
            for(int i=2;i<=100;i++)
            {
                int k = 0;
                for(int j=2;j<=100;j++)
                {
                    if(i!=j && i%j==0)
                    {
                        k++;
                        break;
                    }
                }
                if(k==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
