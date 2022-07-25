using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            for (int i = 1; i <= n; i++)
            {
                d += 2*i - 1;
                Console.WriteLine(d);
            }
            Console.WriteLine("Результат равен {0}",d);
            Console.ReadKey();
        }
    }
}
