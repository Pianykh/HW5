using System;
using System.Text;
using System.Text.RegularExpressions;

/*
* 1.Создать калькулятор с использованием методов. Учесть ввод невалидных данных. Учесть, что делить на 0 нельзя.
* Операции которые можно сделать, +, -, *, /, %.
* С результатом выполнения можно продолжнать выполнять математические действия, если пользователь хочет.
*/

namespace Ex1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Калькулятор. Поддерживает операции с двумя переменными. Поддерживаемые операции - +, -, *, /, %");
                Console.WriteLine("Введите первое значение:");
                var firstNumber = double.Parse(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("Введите знак операции:");
                    var operation = Console.ReadLine();
                    Console.WriteLine("Введите второе значение:");
                    var secondNumber = double.Parse(Console.ReadLine());
                    var result = operation switch
                    {
                        "+" => Plus(firstNumber, secondNumber),
                        "-" => Minus(firstNumber, secondNumber),
                        "*" => Multiply(firstNumber, secondNumber),
                        "/" => Divide(firstNumber, secondNumber),
                        "%" => Modulus(firstNumber, secondNumber),
                        _ => throw new NotImplementedException(),
                    };
                    Console.WriteLine("Результат операции:" + result);
                    Console.WriteLine("Продолжить операцию с результатом? да\\нет");
                    var answer = Console.ReadLine();
                    if (answer == "нет")
                    {
                        break;
                    }
                    firstNumber = result;
                }
            }
        }
        static double Plus(double a, double b)
        {
            return a + b;
        }
        static double Minus(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static double Modulus(double a, double b)
        {
            try
            {
                return a % b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return 0;
            }
        }
        static string DefineOperation(string expression)
        {
            expression = expression.Replace(" ", "");
            var regex = new Regex(@"[0-9]*\,*");
            return regex.Replace(expression, "");
        }

        static double[] DefineNumbers(string expression)
        {
            var regex = new Regex(@"[+\-*/%]");
            expression = expression.Replace(" ", "");
            var twoNumbers = regex.Replace(expression, " ");
            var stringNumbersArray = twoNumbers.Split(" ");
            double[] numbersArray = { Convert.ToDouble(stringNumbersArray[0]), Convert.ToDouble(stringNumbersArray[1]) };
            return numbersArray;
        }


    }
}
