using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Slpt nhap: ");
            n = int.Parse(Console.ReadLine());

            string[] arr so = new string[n];    
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap gia tri {0}", i);
                arrso[i] = Console.ReadLine();
            }
        }
    }
}
