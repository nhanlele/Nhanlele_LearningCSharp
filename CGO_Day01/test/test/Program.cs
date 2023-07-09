using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ngay sinh nhat cua ban: ");
            string input = Console.ReadLine();
            DateTime dob;
            if (DateTime.TryParse(input, out dob))
            {
                Console.WriteLine("Du lieu bi sai");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
