using System;


namespace SheinPI19C
{
    class Program
    {
        static int[] arr;
        static int size;

        static void Main(string[] args)
        {
            ShowHello();

            while (ShowMenu()) { Pause(); }
        }

        private static bool ShowMenu()
        {
            Console.Clear();
            if(arr != null) {
                Console.WriteLine("Текущий массив: ");
                Array_Print(arr);
                Console.WriteLine();
            }
            Console.WriteLine(".:: Главное меню ::.");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Генерация массива");
            if (arr != null)
            {
                Console.WriteLine("2. Поиск элемента");
                Console.WriteLine("3. Удаление элементов");
                Console.WriteLine("4. Перестановка элементов");
                Console.WriteLine("5. Сортировка элементов");
                Console.WriteLine("6. Добавление элементов");
                Console.WriteLine("7. Вывод массива");
            } 
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Выход");
            Console.WriteLine(" ");
            if(arr == null)
            {
                Console.WriteLine("-- Чтобы воспользоваться всеми возможностями\n-- Сгенерируйте массив\n ");
            }
            Console.Write("Введите номер задачи: ");

            switch (Console.ReadLine())
            {
                case "1":
                    size = ReadInt("Введите размер массива (n): ");
                    arr = Array_Fill(size);
                    return true;
                case "2":
                    int count;
                    int index = Array_Find(arr, out count);
                    Console.WriteLine($"Первый отрицательный - {((index == -1) ? "Все элементы положительные" : arr[index].ToString())}\nВсего итераций - {count}");
                    return true;
                case "3":
                    arr = Array_Delete(arr);
                    Console.WriteLine("Результат удаления: "); Array_Print(arr);
                    return true;
                case "4":
                    Array_Swap(arr);
                    Console.WriteLine("Результат перестановки: "); Array_Print(arr);
                    return true;
                case "5":
                    Array_Sort(arr);
                    Console.WriteLine("Результат сортировки: "); Array_Print(arr);
                    return true;
                case "6":
                    arr = Array_Add(arr, ReadInt("Введите количество новых элементов: "));
                    Console.WriteLine("Обновленный массив: "); Array_Print(arr);
                    return true;
                case "7":
                    Array_Print(arr);
                    return true;

                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static void Array_Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"| {arr[i],3} ");
            }
            Console.WriteLine("|");
        }

        private static void ShowHello()
        {
            Console.WriteLine("|===========================================|");
            Console.WriteLine("| Работу выполнил: Шеин А.Н.                |");
            Console.WriteLine("| Группа: ПИ19-С                            |");
            Console.WriteLine("| Вариант: 6                                |");
            Console.WriteLine("|===========================================|"); 
        }

        private static int[] Array_Fill(int size)
        {
            int[] arr = new int[size];

            Console.WriteLine(@"
Способ формирования массива:
1. Вручную
2. С помощью Random
");
            switch (ReadInt("Введите номер действия: ", 1, 2))
            {

                case 1:
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = ReadInt($"Элемент [{i}]:  ");
                    } 
                    break;
                case 2:
                    Random rnd = new Random();

                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = rnd.Next(-99, 101);
                    }
                    break;
                default:
                    break;
            } 

            return arr;
        }
        // 0 1 2 3 4
        // - 1 - 3 -
        private static int[] Array_Delete(int[] arr)
        {
            // Все элементы с четными индексами

            int new_size = 0;
            for (int i = 0; i < arr.Length; i++) if(i % 2 == 1) { new_size++; }

            int[] local = new int[new_size];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)  continue; 
                if(k > local.Length) break;
                local[k++] = arr[i];
            }

            return local;
        }

        private static int[] Array_Add(int[] arr, int k)
        {
            // К элементов в конец массива
            int[] local = new int[arr.Length + k];
            Random rnd = new Random();
            for (int i = 0; i < local.Length; i++)
            {
                if (i < arr.Length)
                {
                    local[i] = arr[i];
                    continue;
                }
                local[i] = rnd.Next(100);
            }
            return local;
        }

        private static void Array_Swap(int[] arr)
        {
            // Поменять местами минимальный и максимальный элементы
            int min = 0, max = 0, index ;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }
            index = arr[min];
            arr[min] = arr[max];
            arr[max] = index;
        }
        private static int Array_Find(int[] arr, out int count)
        {
            // Первый отрицательный 
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                if (arr[i] < 0) return i;
            }
            return -1;
        }
        private static void Array_Sort(int[] arr)
        {
            int i, j, min, val;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                val = arr[i];
                arr[i] = arr[min];
                arr[min] = val;
            }
        }

        private static int ReadInt(string str, int min = -1, int max = -1)
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
                if((min != -1 && size < min) || (max != -1 && max < size))
                {
                    Console.WriteLine($"Ошибка: диапазон допустимых значений [{min};{max}]");
                    b = false;
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
