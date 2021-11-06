using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_1
{
    class Program
    {

        public double x;
        public double y;
        public double z;
        public double p;
        double Area()
        {
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        class AreaDemo
        {
            static void Main()
            {
                Program first = new Program();
                Program second = new Program();
                double areaxyz;
                first.x = 20;
                first.y = 20;
                first.z = 20;
                first.p = (first.x + first.y + first.z) / 2;
                second.x = 45;
                second.y = 45;
                second.z = 45;
                second.p = (second.x + second.y + second.z) / 2;
                areaxyz = first.Area();
                areaxyz = second.Area();



                if (first.Area() > second.Area())
                {
                    Console.WriteLine("Площадь первого треугольника больше и равна {0}", first.Area());
                    Console.ReadKey();
                }
                else if (second.Area() > first.Area())
                {
                    Console.WriteLine("Площадь второго треугольника больше  и равна {0}", second.Area());
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{Площади треугольников равны}");
                    Console.ReadKey();
                }

            }
        }
    }

}