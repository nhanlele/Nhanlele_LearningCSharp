using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Day03_inhinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice;
            Console.Write("1.Print the rectangle ");
            Console.Write("2.Print the square triangle ");
            Console.Write("3.Print isosceles triangle ");
            Console.Write("0.Exit");
            Console.Write("Enter Your Choice: ");
            Choice = Int32.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Print the rectangle ");
                    Console.WriteLine("* * * * * * *");
                    Console.WriteLine("* * * * * * *");
                    Console.WriteLine("* * * * * * *");
                    break;
                
                case 2:
                    Console.WriteLine("Print the square triangle ");
                    Console.WriteLine("*");
                    Console.WriteLine("* * ");
                    Console.WriteLine("* * * ");
                    Console.WriteLine("* * * * ");
                    Console.WriteLine("* * * * * ");
                    break;

                case 3:
                    Console.WriteLine("Print isosceles triangle ");
                    Console.WriteLine("*");
                    Console.WriteLine("* * ");
                    Console.WriteLine("* * * ");
                    Console.WriteLine("* * * * ");
                    Console.WriteLine("* * * * * ");
                    break;
            }
        }
    }
}
