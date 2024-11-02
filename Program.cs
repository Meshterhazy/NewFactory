using System;
using System.Xml.XPath;

namespace Calculator
{
    class Programm
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            double var1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double var2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите операцию: ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '*':
                    result = var1 * var2;
                    break;
                case '/':
                    if (var2 != 0)
                        result = var1 / var2;
                    else
                    {
                        Console.WriteLine("Делить на 0 нельзя.");
                    }
                    break;
                case '+':
                    result = var1 + var2;
                    break;
                case '-':
                    result = var1 - var2;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}