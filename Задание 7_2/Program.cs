using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/

            Console.WriteLine("Введите длину ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            CalcAreaAndVolume(a, out V, out S);
            Console.WriteLine("Площадь поверхности куба равна: {0}", S);
            Console.WriteLine("Объём куба равен: {0}", V);
            Console.ReadKey();
        }
        static void CalcAreaAndVolume(int a, out double V, out double S)
        {
            S = 6 * a * a;
            V = a * a * a;
        }
    }
}
