using System;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool mistake = false;   //есть ошибка при конвертации или радиус отрицательный?
                double x = 0, y = 0;    //координаты точки
                Console.Write("Введите радиус окружности R = ");
                try
                {
                    Circle.radius = Convert.ToDouble(Console.ReadLine());//попытка прочитать радиус 
                    if (Circle.radius < 0)//если радиус отрицательный
                    {
                        mistake = true;
                        Console.WriteLine("Радиус не может быть отрицательным.");
                    }
                }
                catch
                {
                    mistake = true;
                    Console.WriteLine("Не удалось распознать R.");
                }
                if (mistake == false)//если нет ошибки, то пытаемся распознать x
                {
                    Console.Write("x = ");
                    try
                    {
                        x = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        mistake = true;
                        Console.WriteLine("Не удалось распознать x.");
                    }
                }
                if (mistake == false)//если нет ошибки, то пытаемся распознать y
                {
                    Console.Write("y = ");
                    try
                    {
                        y = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        mistake = true;
                        Console.WriteLine("Не удалось распознать y.");
                    }
                }
                if (mistake == false)//если нет ошибки, то вызаваем методы
                {
                    Circle.DefineCircleLength(Circle.radius);
                    Circle.DefineCircleArea(Circle.radius);
                    Circle.BelongToPoint(Circle.radius, x, y);
                }
                Console.WriteLine();
            }
        }
        public static class Circle
        {
            public static double radius; //радиус
            public static void DefineCircleLength(double radius)// метод вычисления длины окружности
            {
                Console.WriteLine("Длина окружности с радиусом {1} равна {0}.", 2 * Math.PI * radius, radius);
            }
            public static void DefineCircleArea(double radius)// метод вычисления площади круга
            {
                Console.WriteLine("Площадь круга с радиусом {1} равна {0}.", Math.PI * radius * radius, radius);
            }
            public static void BelongToPoint(double radius, double x, double y)// метод определяет принадлежит ли точка кругу
            {
                if (Math.Sqrt(x * x + y * y) <= radius)
                {
                    Console.WriteLine("Точка ({0},{1}) принадлежит кругу радиусом {2} с центром в точке (0,0).", x, y, radius);
                }
                else
                {
                    Console.WriteLine("Точка ({0},{1}) лежит за пределами круга радиусом {2} с центром в точке (0,0).", x, y, radius);
                }
            }
        }
    }
}