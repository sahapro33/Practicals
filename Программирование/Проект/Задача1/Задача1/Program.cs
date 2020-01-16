using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while((n = ReadInt("\n---------------------------------\nДля выхода из программы введите 0\nВведите номер задачи: ")) != 0)
            {
                Console.WriteLine();
                switch (n)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    default: break;
                }
            }

            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();

            Pause();
        }

        private static void Task5()
        {
            string[] animals = new string[] { "Крыса", "Корова", "Тигр", "Заяц", "Дракон", "Змея", "Лошадь", "Овца", "Обезьяна", "Петух", "Собака", "Свинья" };
            string[] colors = new string[] { "зеленый", "зеленый", "красный", "красный", "желтый", "желтый", "белый", "белый", "черный", "черный" };

            int n = ReadInt("Введите номер года: ") - 4; 
            Console.WriteLine(animals[n % animals.Length] + ", " + colors[n % colors.Length]);
        }

        private static void Task4()
        {
            // Данные представлены  в виде массива, в котором направление ветра 
            // за каждый день кодируется следующим образом: 
            // 1 — северный, 2 — южный, 3 — восточный, 4 — западный, 
            // 5 — северо-западный, 6 — северо-восточный, 7 — юго-западный, 8 — юго-восточный. 
            // Определить, как должен быть расположен жилой комплекс по отношению к комбинату. 

            string[] str = new[] 
            {
                "", "северный", "южный", "восточный",
                "западный", "северо -западный", "северо-восточный",
                "юго-западный", "юго-восточный"
            };

            int[] arr = new int[365];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 9);
            }

            for (int i = 0; i < arr.Length; i++) Console.WriteLine($"День: {i+1,3} - {str[arr[i]]}"); 

            int[] M = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                M[arr[i]]++;
            }
            int min = 1;
            for (int i = 1; i < M.Length; i++)
            {
                if (M[i] < M[min]) min = i;
            }

            // 1 — северный, 2 — южный, 3 — восточный, 4 — западный, 
            // 5 — северо-западный, 6 — северо-восточный, 7 — юго-западный, 8 — юго-восточный. 

            Console.WriteLine("| Распределение ветра за год: |\n-------------------------------");
            for (int i = 1; i < M.Length; i++)
            {
                Console.WriteLine($"| {str[i],18} | {M[i],6} |");
            }
            Console.WriteLine($"-------------------------------\nЧастота ветра минимальна - {str[min]}");
        }

        private static void Task3()
        {
            Console.WriteLine(@"Дан массив ненулевых целых чисел. 
Определить, сколько раз элементы массива при просмотре от его начала меняют знак. 
Например, в массиве 10, –4, 12, 56, –4, –89 знак меняется 3 раза. ");

            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                while ((arr[i] = rnd.Next(10) - 5) == 0) { }
            }

            Array_Print(arr);

            Console.WriteLine();
            int c = 0;
            bool m = arr[0] < 0;
            for (int i = 1; i < arr.Length; i++)
            { 
                if((arr[i-1] > 0 && arr[i] < 0) || (arr[i - 1] < 0 && arr[i] > 0))
                {
                    c++;
                }
            }
            Console.WriteLine($"Знак меняется {c} раза");
        }

        private static void Task2()
        {
            Console.WriteLine("Дан двумерный массив из двух строк и двадцати двух столбцов.");
            Console.WriteLine("В его первой строке записано количество мячей, забитых футбольной");
            Console.WriteLine("командой в той или иной игре, во второй — количество пропущенных мячей в этой же игре.");

            int[,] arr = new int[2, 22];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                arr[0, i] = rnd.Next(10);
                arr[1, i] = rnd.Next(10);
            }
            // Array2D_Print(arr);

            // Для каждой проведенной игры напечатать словесный результат: "выигрыш", "ничья" или "проигрыш".   
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                Console.WriteLine($"Игра#{i + 1} [{arr[0, i]}:{arr[1, i]}] { (arr[0, i] == arr[1, i] ? "ничья" : arr[0, i] < arr[1, i] ? "проигрыш" : "выигрыш")}");
            }
            // Определить, в скольких играх разность забитых и пропущенных мячей была большей или равной трем.  
            int[] c = new int[4];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[0, i] == arr[1, i]) { c[0]++; }
                else if (arr[0, i] > arr[1, i]) { c[1]++; }
                else { c[2]++; }

                if(arr[0, i] - arr[1, i]  >= 3) { c[3]++;  }
                // (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0). 
            }

            Console.WriteLine($"Количество пройгрышей - {c[2]} Побед - {c[1]} Ничьих - {c[0]} Разница - {c[3]}");
            c[1] *= 3;
            int res = c[0] + c[1];
            Console.WriteLine($"Общее число очков: {res}");
        }

        private static void Array2D_Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($">> ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"| {arr[i, j]}");
                }
                Console.WriteLine("");
            }
        }

        private static void Task1()
        {
            Console.WriteLine("Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами. ");
            int[] arr = new int[20];
            int num;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {               
                do
                {
                    num = rnd.Next(100);
                }
                while (Array_Find(arr, num));

                arr[i] = num;
            }

            Array_Print(arr);
        }

        private static void Array_Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"| {arr[i]} ");
            Console.WriteLine("|");
        }

        private static bool Array_Find(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == num) return true;
            return false;
        }

        private static int ReadInt(string str)
        {
            int size;
            bool b;
            do
            {
                Console.Write(str);
                b = int.TryParse(Console.ReadLine(), out size);
                if (b == false)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                }
            } while (b == false);

            return size;
        }
        private static void Pause()
        {
            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
