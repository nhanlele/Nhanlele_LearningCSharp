using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtongmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 2;
            numbers[1] = 2;
            numbers[2] = 2;
            numbers[3] = 2;
            numbers[4] = 2;
            int S = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                S = S + numbers[i];
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}