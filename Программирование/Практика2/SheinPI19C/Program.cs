using System;

namespace SheinPI19C
{
    class Program
    { 
        static void Main(string[] args)
        {
            ShowHello();


            while (ShowMenu()) { Pause(); }

        }
        public static bool ShowMenu() {
            Console.Clear();
            ShowHello();
            Console.WriteLine(".:: Главное меню ::.");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Задача #1 (06) - Дана последовательность из n целых чисел. Найти минимальный элемент в этой последовательности.");
            Console.WriteLine(@"2. Задача #2 (29) - Дана последовательность целых чисел, за которой следует 0. 
                    Найти количество нечетных элементов этой последовательности.");
            Console.WriteLine("3. Задача #3 (40) - Сумма sin^n(x)");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Выход");
            Console.WriteLine(" ");
            Console.Write("Введите номер задачи: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TaskFirst();    // 6
                    return true;
                case "2":
                    TaskSecond();   // 29
                    return true;
                case "3":
                    TaskThird();    // 40
                    return true; 

                case "0":
                    return false;
                default:
                    return true;
            }

        }
        private static void ShowHello()
        {
            Console.WriteLine("|===========================================|");
            Console.WriteLine("| Работу выполнил: Шеин А.Н.                |");
            Console.WriteLine("| Группа: ПИ19-С                            |");
            Console.WriteLine("| Вариант: 6                                |");
            Console.WriteLine("|===========================================|");
            Console.WriteLine();
        }

        private static void TaskFirst()
        {
            Console.WriteLine("|================ Задача №1 ================|");
            // Дана последовательность из n целых чисел. Найти минимальный элемент в этой последовательности.

            Console.Write("Введите количество целых чисел: ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int y;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"[{i+1}/{n}] Введите число: ");
                y = int.Parse(Console.ReadLine());
                if( y < min)
                { 
                    min = y;
                }
            }
            Console.WriteLine($"Минимальный элемент: {min}");
        }

        private static void TaskSecond()
        {
            Console.WriteLine("|================ Задача №2 ================|");
            // Дана последовательность целых чисел, за которой следует 0. Найти количество нечетных элементов этой последовательности.

            int k = 0, y; 

            do
            {
                Console.Write("Введите целое число: "); 
                if (int.TryParse(Console.ReadLine(), out y) == false)
                {
                    continue;
                }

                k += y % 2; // Т.к если число не четное, то остаток = 1

            } while (y != 0); // Запрашиваем ввод, пока не введен 0

            Console.WriteLine($"Количество нечетных элементов: {k}");
        }

        private static void TaskThird()
        {
            Console.WriteLine("|================ Задача №3 ================|");
            // 

            Console.Write("Введите X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество слагаемых(n): ");
            int n = int.Parse(Console.ReadLine());
            double s = Math.Sin(x); 

            for (int i = 1; i <= n; i++)
            {
                s += s*Math.Sin(x);
            }
            Console.WriteLine($"Сумма элементов sin^n(x): {s}");
        }
        static void Pause()
        {
            Console.Write("\nНажмите кнопку Ввод для продолжения....");
            Console.ReadLine();
        }

    }
}
