using System;  

namespace pr5
{
    class Program
    { 
        static Random rnd = new Random();
        static int[][] arr3 = null;
        static int[,] arr2 = null;
        static int[] arr = null;

        static void Main()
        {
            Console.WriteLine($"{System.Int32.MaxValue}");
            while (ShowMenu()) { }
            Pause();
        }

        private static bool ShowMenu()
        {
            Console.WriteLine(@"
.:: Главное меню ::.
--------------------
1. Работа с одномерным массивом
2. Работа с двумерным массивом
3. Работа с рваным массивом
--------------------
0. Выход");
            switch (ReadInt("Выберите тип массива: "))
            {
                case 1:
                    Array_1D();
                    return true;
                case 2:
                    Array_2D();
                    return true;
                case 3:
                    Array_3D();
                    return true;

                default:
                    return false;
            }
        }

        private static void Array_3D()
        {
            while (ShowMenu3D()) { }
        }

        private static bool ShowMenu3D()
        {
            Console.WriteLine(@"
.:: Рваный массив ::.
---------------------
1. Создать массив
2. Напечатать массив
3. Удалить строки с K1 по K2
---------------------
0. Назад");
            switch (ReadInt("Введите номер действия: "))
            {
                case 1:
                    Console.WriteLine("Формирование рваного массива");
                    int rows3 = ReadInt("Введите количество строк: ");
                    arr3 = new int[rows3][];
                    Array3D_Fill();
                    return true;
                case 2:
                    Array3D_Print();
                    return true;
                case 3:
                    Console.WriteLine("Удалить строки начиная с номера K1 и заканчивая номером К2 включительно");
                    int k1 = ReadInt("Введите номер начального элемента (K1): ");
                    int k2 = ReadInt("Введите номер конечного элемента (K2): ");
                    Array3D_Delete(k1, k2);
                    return true;
                case 0:
                    return false;
                default:
                    return true;
            }
        }

        private static void Array3D_Delete(int k1, int k2)
        {
            if (arr3 == null) { Console.WriteLine("Массив не инициализирован!"); return; }

            int[][] tmp3 = new int[arr3.Length - (k2 - k1) - 1][];
            int x = 0;
            bool mark = false;
            for (int i = 0; i < arr3.Length; i++)
            { 
                if (i >= k1 && i <= k2) { continue; }
                tmp3[x] = arr3[i];
                x++;
            }
            arr3 = tmp3;
        }

        private static void Array3D_Print()
        {
            if (arr3 == null) { Console.WriteLine("Массив не инициализирован!"); return; }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++) { Console.Write($"|{arr3[i][j],3} "); }
                Console.WriteLine("|");
            }
        }

        private static void Array3D_Fill()
        {
            int cols3;
            Console.WriteLine(@"
Способ формирования массива:
1. Вручную
2. С помощью Random
");
            switch (ReadInt("Введите номер действия: "))
            {
                case 1:
                    for (int i = 0; i < arr3.Length; i++)
                    {
                        cols3 = ReadInt("Введите количество столбцов: ");
                        arr3[i] = new int[cols3];
                        for (int j = 0; j < cols3; j++)
                            arr3[i][j] = ReadInt($"Элемент #{j}:  ");
                    }
                    break;
                case 2:
                    for (int i = 0; i < arr3.Length; i++)
                    {
                        cols3 = ReadInt("Введите количество столбцов: ");
                        arr3[i] = new int[cols3];
                        for (int j = 0; j < cols3; j++)
                            arr3[i][j] = rnd.Next(-11, 11);
                    }
                    break;
                default:
                    break;
            }
        }

        private static void Array_2D()
        { 
            while (ShowMenu2D()) { } 
        }

        private static bool ShowMenu2D()
        {
            Console.WriteLine(@"
.:: Двумерный массив ::.
---------------------
1. Создать массив
2. Напечатать массив
3. Добавить столбец в начало матрицы
---------------------
0. Назад");
            switch (ReadInt("Введите номер действия: "))
            {
                case 1:
                    Console.WriteLine("Формирование двумерного массива");
                    int rows = ReadInt("Введите количество строк: ");
                    int cols = ReadInt("Введите количество столбцов: ");

                    arr2 = new int[rows, cols];
                    Array2D_Fill();
                    return true;
                case 2:
                    Array2D_Print();
                    return true;
                case 3:
                    Array2D_AddCol();
                    return true;
                case 0:
                    return false;
                default:
                    return true;
            }
        }

        private static void Array2D_AddCol()
        {
            if (arr2 == null) { Console.WriteLine("Массив не инициализирован!"); return; }

            Console.WriteLine("Добавить столбец в начало матрицы");
            int[,] tmp2 = new int[arr2.GetLength(0), arr2.GetLength(1) + 1];
            for (int i = 0; i < tmp2.GetLength(0); i++)
            {
                tmp2[i, 0] = rnd.Next(-11, 11);
                for (int j = 1; j < tmp2.GetLength(1); j++) { tmp2[i, j] = arr2[i, j - 1]; }
            }
            arr2 = tmp2; 
        }

        private static void Array2D_Print()
        {
            if(arr2 == null) { Console.WriteLine("Массив не инициализирован!"); return; }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++) { Console.Write($"|{arr2[i, j],3} "); }
                Console.WriteLine("|");
            }
        }

        private static void Array2D_Fill()
        {
            Console.WriteLine(@"
Способ формирования массива:
1. Вручную
2. С помощью Random
");
            switch (ReadInt("Введите номер действия: "))
            {
                case 1:
                    for (int i = 0; i < arr2.GetLength(0); i++)
                        for (int j = 0; j < arr2.GetLength(1); j++)
                            arr2[i, j] = ReadInt($"Элемент [{i},{j}]:  ");
                    break;
                case 2:
                    for (int i = 0; i < arr2.GetLength(0); i++)
                        for (int j = 0; j < arr2.GetLength(1); j++)
                            arr2[i, j] = rnd.Next(-11, 11);
                    break;
                default:
                    break;
            }
        }

        private static void Array_1D()
        {
            while (ShowMenu1D()) { } 
        }

        private static void Array1D_Print()
        {
            if (arr == null) { Console.WriteLine("Массив не инициализирован!"); return; }

            for (int i = 0; i < arr.Length; i++) { Console.Write($"| {arr[i]} "); }
            Console.WriteLine("|");
        }

        private static void Array1D_Delete()
        {
            if (arr == null) { Console.WriteLine("Массив не инициализирован!"); return; }

            Console.WriteLine("Удалить N элементов, начиная с номера K");
            int n = ReadInt("Введите количество элементов (N): ");
            int k = ReadInt("Введите номер начального элемента (K): ");
            int[] tmp = new int[arr.Length - n];
            for (int i = 0, j = 0; i < tmp.Length && j < arr.Length; j++)
            {
                if (j >= k && n > 0)
                {
                    n--;
                    continue;
                }
                tmp[i++] = arr[j];
            }
            arr = tmp;
        }

        private static bool ShowMenu1D()
        {
            Console.WriteLine(@"
.:: Одномерный массив ::.
---------------------
1. Создать массив
2. Напечатать массив
3. Удалить N элементов, начиная с номера K
---------------------
0. Назад");
            switch (ReadInt("Введите номер действия: "))
            {
                case 1:
                    int size = ReadInt("Введите размер массива: ");
                    arr = new int[size];
                    Array1D_Fill();

                    return true;
                case 2:
                    Array1D_Print();
                    return true;
                case 3:
                    Array1D_Delete();
                    return true;
                case 0:
                    return false;
                default:
                    return true;
            }
        }

        private static void Array1D_Fill()
        {
            for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(-11, 11); } 
        }

        private static int ReadInt(string str = "")
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
            Console.Write("Для продолжения нажмите клавишу ВВОД...");
            Console.ReadLine();
        }
    }
}
