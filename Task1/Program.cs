using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0");
            Console.Write("N=");
            int N=Convert.ToInt32(Console.ReadLine());
            int result=0;
            for (int i = 1; i <= N; i++) 
            {
                result += 2 * i - 1;
                Console.WriteLine($"Сумма на шаге {i} равна "+result);
            }
            Console.ReadKey();
        }
    }
}
