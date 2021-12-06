using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Два треугольника заданы длинами своих сторон. 
             *Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
             *Для решения задачи можно использовать формулу Герона*/

            Console.WriteLine("Введите длины сторон a1, b1 и с1 первого треугольника:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон a2, b2 и с2 второго треугольника:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1 = CalcArea(a1, b1, c1);
            Console.WriteLine("Площадь первого треугольника равна: {0:f2}", S1);
            double S2 = CalcArea(a2, b2, c2);
            Console.WriteLine("Площадь второго треугольника равна: {0:f2}", S2);
            if (S1 == S2)
            {
                Console.WriteLine("Площади обоих треугольников равны между собой.");
            }
            else
            {
                Console.WriteLine((S1 > S2) ? "Площадь первого треугольника больше, чем площадь второго треугольника." : "Площадь второго треугольника больше, чем площадь первого треугольника.");
            }
            Console.ReadKey();
        }
        static double CalcArea(int a, int b, int c)
        {
            double p = (double)(a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
