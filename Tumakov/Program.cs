using System;

namespace Tumakov
{
    internal class Program
    {
        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Change(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static bool Factorial(int n, out int result)
        {
            result = 1;

            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }

                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        static int FactorialRecursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * FactorialRecursive(n - 1);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static int GCD(int a, int b, int c)
        {
            return GCD(GCD(a, b), c);
        }

        static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            // Задание 5.1
            Console.WriteLine("Задание 5.1");
            Console.WriteLine("Метод возвращает наибольшее из двух целых чисел");
            Console.WriteLine(Max(89, 24));
            Console.WriteLine(Max(31, 43));
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();

            // Задание 5.2
            Console.WriteLine("Задание 5.2");
            Console.WriteLine("Метод меняет местами значения двух передаваемых параметров");
            int x = 10;
            int y = 20;
            Change(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();

            // Задание 5.3
            Console.WriteLine("Задание 5.3");
            Console.WriteLine("Метод вычисляет факториал. Если метод отработал успешно, выведется true, а иначе false");
            int result;
            bool success = Factorial(5, out result);
            Console.WriteLine(success);
            Console.WriteLine(result);
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();

            // Задание 5.4
            Console.WriteLine("Задание 5.4");
            Console.WriteLine("Метод рекурсивно вычисляет факториал");
            Console.WriteLine(FactorialRecursive(5));
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();

            // Домашнее задание 5.1
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("НОД двух чисел:");
            Console.WriteLine(GCD(48, 18));
            Console.WriteLine("НОД трех чисел:");
            Console.WriteLine(GCD(48, 18, 30));
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();

            // Домашнее задание 5.2
            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine(Fibonacci(1));
            Console.WriteLine(Fibonacci(2));
            Console.WriteLine(Fibonacci(3));
            Console.WriteLine(Fibonacci(4));
            Console.WriteLine(Fibonacci(5));
            Console.WriteLine(Fibonacci(6));
            Console.WriteLine(Fibonacci(7));
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
