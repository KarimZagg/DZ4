using System;

namespace Tumakov
{
    internal class Program
    {
        static void Task1()
        {
            // Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine("Выводит на экран массив случайных чисел, потом меняет местами введенные числа");
            Random random = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            Console.WriteLine("Массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите первое число из массива:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число из массива:");
            int second = int.Parse(Console.ReadLine());

            int firstIndex = -1;
            int secondIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == first && firstIndex == -1)
                {
                    firstIndex = i;
                }

                if (numbers[i] == second && secondIndex == -1)
                {
                    secondIndex = i;
                }
            }

            if (firstIndex != -1 && secondIndex != -1)
            {
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;
            }
            else
            {
                Console.WriteLine("Одно или оба числа отсутствуют в массиве.");
            }

            Console.WriteLine("Новый массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
        }

        static int Task2(ref int product, out double average, params int[] numbers)
        {
            int sum = 0;
            product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];
            }

            if (numbers.Length > 0)
            {
                average = (double)sum / numbers.Length;
            }
            else
            {
                average = 0;
            }

            return sum;
        }

        static void Task3()
        {
            // Задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Рисует в консоли введенную цифру");
            string[] digits =
            {
                "#####\n#   #\n#   #\n#   #\n#####",
                "    #\n    #\n    #\n    #\n    #",
                "#####\n    #\n#####\n#    \n#####",
                "#####\n    #\n#####\n    #\n#####",
                "#   #\n#   #\n#####\n    #\n    #",
                "#####\n#    \n#####\n    #\n#####",
                "#####\n#    \n#####\n#   #\n#####",
                "#####\n    #\n    #\n    #\n    #",
                "#####\n#   #\n#####\n#   #\n#####",
                "#####\n#   #\n#####\n    #\n#####"
            };

            while (true)
            {
                Console.WriteLine("Введите число от 0 до 9 или exit/закрыть:");
                string input = Console.ReadLine();

                if (input == "exit" || input == "закрыть")
                {
                    break;
                }

                int number;

                if (int.TryParse(input, out number))
                {
                    if (number >= 0 && number <= 9)
                    {
                        Console.WriteLine(digits[number]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: число должно быть от 0 до 9.");
                        System.Threading.Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                else
                {
                    throw new FormatException("Введено не число.");
                }
            }
        }

        enum УровеньВорчливости
        {
            Спокойный,
            Ворчливый,
            ОченьВорчливый
        }

        struct Дед
        {
            public string Имя;
            public УровеньВорчливости Уровень;
            public string[] Фразы;
            public int ЧерныеГлаза;

            public Дед(string имя, УровеньВорчливости уровень, string[] фразы)
            {
                Имя = имя;
                Уровень = уровень;
                Фразы = фразы;
                ЧерныеГлаза = 0;
            }
        }

        static int CheckGrandpa(Дед дед, params string[] плохиеСлова)
        {
            int blackEyes = 0;

            for (int i = 0; i < дед.Фразы.Length; i++)
            {
                for (int j = 0; j < плохиеСлова.Length; j++)
                {
                    if (дед.Фразы[i].ToLower().Contains(плохиеСлова[j].ToLower()))
                    {
                        blackEyes++;
                    }
                }
            }

            return blackEyes;
        }

        static void Task4()
        {
            // Задание 4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Подсчитывает количество фингалов деду за матерные слова");
            Дед дед1 = new Дед(
                "Иван",
                УровеньВорчливости.Спокойный,
                new string[] { "Ну и погодка сегодня, черт побери." });

            Дед дед2 = new Дед(
                "Петр",
                УровеньВорчливости.Ворчливый,
                new string[] { "Опять эта погода, блин.", "Какой же ты дурак!" });

            Дед дед3 = new Дед(
                "Сергей",
                УровеньВорчливости.ОченьВорчливый,
                new string[] { "Черт побери!", "Опять все через одно место.", "Какой кошмар!" });

            Дед дед4 = new Дед(
                "Алексей",
                УровеньВорчливости.Ворчливый,
                new string[] { "Да что за черт?", "Опять все сломалось, идиоты.", "Вот же блин.", "Какой кошмар!" });

            Дед дед5 = new Дед(
                "Николай",
                УровеньВорчливости.ОченьВорчливый,
                new string[] { "Черт побери!", "Какой же ты идиот.", "Опять все через одно место.", "Да чтоб тебя!", "Вот же кошмар." });

            string[] плохиеСлова =
            {
                "черт",
                "блин",
                "дурак",
                "идиот",
                "кошмар"
            };

            Console.WriteLine(дед1.Имя + ": " + CheckGrandpa(дед1, плохиеСлова) + " черных глаз");
            Console.WriteLine(дед2.Имя + ": " + CheckGrandpa(дед2, плохиеСлова) + " черных глаз");
            Console.WriteLine(дед3.Имя + ": " + CheckGrandpa(дед3, плохиеСлова) + " черных глаз");
            Console.WriteLine(дед4.Имя + ": " + CheckGrandpa(дед4, плохиеСлова) + " черных глаз");
            Console.WriteLine(дед5.Имя + ": " + CheckGrandpa(дед5, плохиеСлова) + " черных глаз");

            Console.ReadKey();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Task1();

            // Задание 2
            Console.WriteLine("Задание 2");
            Console.WriteLine("Вызывает метод для массива чисел и возвращает его сумму, произведение и среднее арифметическое");
            int product = 0;
            double average = 0;

            int sum = Task2(ref product, out average, 2, 4, 6, 8, 10);

            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Среднее: " + average);

            Console.ReadKey();
            Console.WriteLine();

            Task3();

            Task4();
        }
    }
}