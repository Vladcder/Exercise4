using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posCount = 0;
            int negCount = 0;
            int currentNumber=0;
            Console.WriteLine("Введите последовательность целых чисел. Окончание последовательности служит число 0");
            do
            {
                currentNumber = Convert.ToInt32(Console.ReadLine());
                if (currentNumber>0)
                {
                    posCount++;
                }
                else if (currentNumber<0)
                {
                    negCount++;
                }
            } while (currentNumber != 0);
            if  (posCount>negCount)
            {
                Console.WriteLine("Положительных чисел больше");
            }
            else if (posCount<negCount)
            {
                Console.WriteLine("Отрицательных чисел больше");
            }
            else { Console.WriteLine("Количество равно"); }
            Console.ReadKey();
        }
    }
}
