using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.26
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            while (a != 0)
            {
               int a1 = a % 10;
                a = a / 10;
                if (max < a1)
                {
                    max = a1;
                }
            }
           
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
