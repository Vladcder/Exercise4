using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер стороны прямоугольника A");
            double A=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер стороны прямоугольника B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер стороны квадрата C");
            double C = Convert.ToDouble(Console.ReadLine());
            int squareNumber = 0;
            double initialA = A;
            double initialB = B;
            while (B>=C)
            {
                while(A>=C)
                {
                    A -= C;
                    squareNumber++;
                }
                B -= C;
                A = initialA;

            }
            Console.WriteLine($"Количество квадратов равно {squareNumber}");
            Console.ReadKey();
        }
    }
}
