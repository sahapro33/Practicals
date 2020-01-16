using System;

namespace SheinPI19C
{
    class Program
    { 
      
        static void Main(string[] args)
        { 
            ShowHello();
            TaskFirst();
            Console.WriteLine("Конец... Нажмите любую клавишу...");
            Console.ReadKey();
        }

        private static void ShowHello()
        {
            Console.WriteLine("|===========================================|");
            Console.WriteLine("| Работу выполнил: Шеин А.Н.                |");
            Console.WriteLine("| Группа: ПИ19-С                            |");
            Console.WriteLine("| Вариант: 6                                |");
            Console.WriteLine("|===========================================|"); 
        }

        private static void TaskFirst()
        {
            Console.WriteLine("|================ Задача №1 ================|");
            
            // Console.Write("Введите a: ");
            double a = 0.1d; double b = 1d;
            // double a = double.Parse(Console.ReadLine());
            // Console.Write("Введите b: ");
            // double b = double.Parse(Console.ReadLine());
            double k = 10;
            k = (b - a) / k;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"Шаг (k) = {k}");
            double e = 0.0001d;
            Console.WriteLine($"Точность = {e}");


            /*
            Алгоритм решения задачи сводится к трем циклам, причем два из них вложены в третий.
            Внутренние циклы суммируют слагаемые при фиксированном параметре x, один (арифметический для заданного n), 
                другой(итерационный для заданной точности e.
            При организации этих циклов следует обратить внимание на правильный выбор формулы для вычисления 
                элемента ряда an и правильное присвоение начальных значений переменным цикла.
            Внешний цикл организует изменение параметра х.
            */

            double sn, se, y, an;
            int n = 1;
            for (double x = a; x <= b; x += k) {
                
                y = Math.Pow(Math.E, (x * Math.Cos(Math.PI / 4))) * (Math.Cos(x * Math.Sin(Math.PI / 4)));

                sn = 1d;
                n = 25;
                do
                {
                    sn += Calc(x,n); 
                } while (--n > 0);

                se = 1;
                n = 1;
                double ann = 0;
                do
                {
                    an = Calc(x, n);
                    ann = Calc(x, n - 1);
                    se += an;
                    n++;
                } while (Math.Abs(ann - an) > e);

                Console.WriteLine($"X={x.ToString("F3")} SN={sn.ToString("F14")} SE={se.ToString("F14")} Y={y.ToString("F14")}");
            } 
           
        } 

        private static double Calc(double x, int n)
        {
            
            return ((Math.Cos(n * Math.PI / 4)) / Fac(n)) * Math.Pow(x, n);
        }

        private static long Fac(long n)
        { 
            if (n <= 1) { return 1; }

            return n * Fac(--n);
        }
    }
}
