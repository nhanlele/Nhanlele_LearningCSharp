using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int donvi=2; donvi<=10; donvi++)
            {
                int i;
                for (i=1; i <= 10; i++)
                {
                    int product = donvi * i; 
                    Console.WriteLine(donvi + " x " + i +" = " + product);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
