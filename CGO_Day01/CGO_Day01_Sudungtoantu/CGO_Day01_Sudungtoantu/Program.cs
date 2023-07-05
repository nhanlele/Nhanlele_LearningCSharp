using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Day01_Sudungtoantu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.WriteLine("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " +  area);
            Console.ReadKey();
        }
    }
}
