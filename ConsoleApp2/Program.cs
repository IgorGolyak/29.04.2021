using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.2
            int s = 0;
            int n = 0;
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                s = s + a;
                n = n + 1;
                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
            }
            double sr = 1.0 * s / n;

            Console.WriteLine(sr);
            Console.ReadKey();
        }
    }
}
