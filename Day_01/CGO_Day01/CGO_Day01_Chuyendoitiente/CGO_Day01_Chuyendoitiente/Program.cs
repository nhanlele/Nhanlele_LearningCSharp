using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Day01_Chuyendoitiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tigia = 23000;
            Console.Write("Moi ban nhap so tien:");
            string input = Console.ReadLine();
            int dola = int.Parse(input);
            Console.WriteLine("So tien VND cua ban la:"  + dola*tigia);
            Console.ReadKey();
        }
    }
}
