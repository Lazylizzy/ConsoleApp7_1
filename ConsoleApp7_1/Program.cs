using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите z1: ");
            double z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите z2: ");
            double z2 = Convert.ToInt32(Console.ReadLine());
            double p1 = (x1 + y1 + z1) / 2;
            double p2 = (x2 + y2 + z2) / 2;            
            double result = Area1(p1, x1, y1, z1);
            double result2 = Area2(p2, x2, y2, z2);
            if (result> result2)
            {
                Console.WriteLine("Площадь треугольника со сторонами х1,у1,z1 больше и равна {0}", result);
                Console.ReadKey();
            }
            else if (result2 > result)
            {
                Console.WriteLine("Площадь треугольника со сторонами х2,у2,z2 больше и равна{0}", result2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("{Площади треугольников равны}") ;
                Console.ReadKey();
            }
            


        }
        static double Area1 (double p1, double x1, double y1, double z1)
        {
            return  Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
            
        }
        static double Area2 (double p2, double x2, double y2, double z2)
        {
            return Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));
        }
    }

}