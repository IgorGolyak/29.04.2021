using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.1 b
            int s = 0;
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                s = s + 4;
                Console.WriteLine("введите число");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
