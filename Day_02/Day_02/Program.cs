using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ngay sinh cua ban: ");
            string input = Console.ReadLine();

            DateTime  dob = DateTime.Parse(input);
            DateTime  dob_year = new DateTime(DateTime.Now.Year, dob.Month, dob.Day);

            if (dob_year > DateTime.Now)
            {
                Console.WriteLine("Ngay sinh nhat sap toi con " + (dob_year.Date - DateTime.Now).TotalDays);
            }
            else if (dob_year == DateTime.Now.Date) {
                Console.WriteLine("Chuc Mung Sinh Nhat Ban! ");
            }
            else
            {
                dob_year = dob_year.AddYears(1);
                Console.WriteLine("Ngay sinh nhat sap toi con " + (dob_year - DateTime.Now).TotalDays);
            }
            //Console.WriteLine("Ngay sinh cua ban la:" + dob.ToString());
            Console.ReadKey();
        }
    }
}
