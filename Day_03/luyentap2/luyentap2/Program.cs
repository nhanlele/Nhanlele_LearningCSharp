using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int donvi = 5;
            int i = 11;
            do
            {
                int product = donvi * i;
                Console.WriteLine(donvi + "x" + i + "=" + product);
                i += 2;
            } while (i <= 10);
            Console.ReadKey();
             

        }
    }
}
