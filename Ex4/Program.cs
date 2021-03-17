using System;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main()
        {           
            PrintSquare();
            PrintRightTriangle();
            PrintInvertedRightTriangle();
            PrintEquilateralTriangle();
        }

        static void PrintSquare()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите длинну cтороны квадрата, для печати квадрата");
            var sideLength = int.Parse(Console.ReadLine());
            for (var i = 0; i < sideLength; i++)
            {
                for (var k = 0; k < sideLength; k++)
                {
                    Console.Write(0 + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintInvertedRightTriangle()
        {
            Console.WriteLine("Введите длинну катета, для печати перевернутого прямоугольного треугольника");
            var sideLength = int.Parse(Console.ReadLine());
            for (var i = 0; i < sideLength; i++)
            {
                for (var k = i; k < sideLength; k++)
                {
                    Console.Write(0);
                }
                Console.WriteLine();
            }
        }

        static void PrintRightTriangle()
        {
            Console.WriteLine("Введите длинну катета, для печати прямоугольного треугольника");
            var sideLength = int.Parse(Console.ReadLine());
            for (var i = 0; i < sideLength; i++)
            {
                for (var k = i + 1; k > 0; k--)
                {
                    Console.Write(0);
                }
                Console.WriteLine();
            }
        }

        static void PrintEquilateralTriangle()
        {
            Console.WriteLine("Введите длинну стороны, для печати равнобедрнного треугольника");
            var sideLength = int.Parse(Console.ReadLine());
            for (var i = 1; i <= sideLength; i++)
            {
                for (var k = sideLength - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (var k = 1; k < i*2; k++)
                {
                    Console.Write(0);
                }                
                Console.WriteLine();
            }
        }
        static void PrintInvertedEquilateralTriangle()
        {
            Console.WriteLine("Введите длинну стороны, для печати перевернутого равностороннего треугольника");
            var sideLength = int.Parse(Console.ReadLine());
            for (var i = 1; i <= sideLength; i++)
            {
                for (var k = sideLength - i; k > 0; k--)
                {
                    Console.Write(" ");
                }  
                for (var k = 0; k < sideLength - i; k++)
                {
                    Console.Write(0);
                }
                              
                Console.WriteLine();
            }
        }
    }
}
