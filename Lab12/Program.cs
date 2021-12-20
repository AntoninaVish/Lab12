using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Радиус окружности:");
                double r = Convert.ToDouble(Console.ReadLine());
                if (r <= 0)
                {
                    Console.Write("Радиус должен быть задан действительным числом.");
                    return;
                }
                Console.Write("Указать координату Х точки:");
                double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Указать координату Y точки:");
                double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                Circle.GetCircumference(r);
                Circle.GetSquare(r);
                Circle.GetPosition(r, positionX, positionY);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода.");
                Console.ReadKey();
                return;
            }

        }
        static class Circle
        {
            public static void GetCircumference(double r)
            {
                double Circle = 2 * Math.PI * r;
                Console.WriteLine("Длина окружности равна {0}", Circle);
            }
            public static void GetSquare(double r)
            {
                double S = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Площадь круга повторной {0}", S);
            }
            public static void GetPosition(double r, double positionX, double positionY)
            {
                if (positionX <= r && positionY <= r)
                {
                    Console.WriteLine("Точка с координатами ({0}; {1}) принадлежит кругу с радиусом {2}", positionX, positionY, r);
                }
                else
                {
                    Console.WriteLine("Точка с координатами ({0}; {1}) не принадлежит кругу с радиусом {2}", positionX, positionY, r);
                }
            }
        }
    }
}






    

