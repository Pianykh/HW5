using System;
using System.Text;
/*
* 3.Создать программу, которая может считать периметр, площу, радиус окружности в зависимости от того, что выберет пользователь. 
* С использованием методов, и выходного параметра out. Учесть ввод негативных данных.
*/


namespace Ex3
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите диаметр окружности:");
            double diameter;
            double result = 0;
            if (double.TryParse(Console.ReadLine(), out diameter))
            {
                if (diameter > 0)
                {
                    Console.WriteLine("1. Периметр. 2. Площадь. 3. Радиус.");
                    Console.WriteLine("Введите номер параметра, для его рассчета:");
                    var i = int.Parse(Console.ReadLine());
                    switch(i)
                    {
                        case 1:
                            GetPerimeter(diameter, out result);
                            break;
                        case 2:
                            GetSquare(diameter, out result);
                            break;
                        case 3:
                            GetRadius(diameter, out result);
                            break;
                        default:
                            Console.WriteLine("Недопустимая операция");
                            break;
                    }
                    Console.WriteLine("Результат: " + result);
                }
                else Console.WriteLine("Значение диаметра может быть только больше нуля");
            }
            else Console.WriteLine("Введите чисельное значение диаметра");
        }

        static void GetPerimeter(double diameter, out double perimeter)
        {
            perimeter = diameter*3.1415;
        }
        
        static void GetSquare(double diameter, out double square)
        {
            square = (diameter / 2) * (diameter / 2) * 3.14;
        }

        static void GetRadius(double diameter, out double radius)
        {
            radius = diameter / 2;
        }
    }
}
