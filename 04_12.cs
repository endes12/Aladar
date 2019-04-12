using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            /*do
            {
                Console.WriteLine("Kérek egy pozitv számot");
                a = Convert.ToInt16(Console.ReadLine());
                if (a==0)
	            {
		            Console.WriteLine("A NULLA nem pozitv");
	            }
                else if (a < 0)
                {
                    Console.WriteLine("Ne negatv számot írj");
                }
            } while (a<1);
            int ossz = 0;
            for (int i = 1; i <= a; i++)
            {
                if (i<a)
                    Console.WriteLine(i + "+");
                else
                    Console.WriteLine(i+"=");
                ossz = ossz + i;
            }
            Console.WriteLine(ossz);*/
            /*Kérj be 5 és 15 köztt egy számot, írd ki a szám faktoriálisát*/
            do
            {
                Console.WriteLine("kérek egy számot 5-15 között");
                a = Convert.ToInt16(Console.ReadLine());
            } while (true);
            Console.ReadKey();
        }
    }
}
