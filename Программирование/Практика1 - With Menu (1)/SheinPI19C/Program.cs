using System;

namespace SheinPI19C
{
    class Program
    { 
        static void Main(string[] args)
        {
            while (ShowMenu()) { }
        }

        static bool ShowMenu()
        { 
            Console.Clear();
            Console.WriteLine(".:: Главное меню ::.");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Задача #1 - Тип выражений и результат вычисления");
            Console.WriteLine("2. Задача #2 - Принадлежность точки заштрихованной области (полукруг в отрицательном y)");
            Console.WriteLine("3. Задача #3 - Значение выражения с различными типами данных");
            Console.WriteLine("--------------------");
            Console.WriteLine("9. Информация о задачах");
            Console.WriteLine("0. Выход");
            Console.WriteLine(" ");
            Console.Write("Введите номер задачи: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TaskFirst();
                    return true;
                case "2":
                    TaskSecond();
                    return true;
                case "3":
                    TaskThird();
                    return true;


                case "9":
                    ShowInfo();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            } 
        }

        static void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine(".:: Спискок заданий ::.");
            Console.WriteLine("--------------------");
            Console.WriteLine("1) Для задачи 1 определить тип заданных выражений и найти их значения.");
            Console.WriteLine("2) Составить систему тестов и вычислить полученное выражение для нескольких значений Х, определить при каких Х выражение не может быть вычислено.");
            Console.WriteLine("3) Для задачи 2 записать выражение, зависящее от координат точки X1 и Y1 и принимающее значение TRUE, если точка принадлежит заштрихованной области, и FALSE, если не принадлежит.");
            Console.WriteLine("4) Составить систему тестов и вычислить полученное выражение для нескольких точек, принадлежащих и не принадлежащих заштрихованной области.");
            Console.WriteLine("5) Для задачи 3 вычислить значение выражения, используя различные вещественные типы данных (float и double).");
            Console.WriteLine("6) Результаты всех вычислений вывести на печать.");
            Console.WriteLine("7) Объяснить полученные результаты.");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Назад");
            Console.WriteLine(" ");
            Console.Write("Введите: ");
            while (Console.ReadLine() != "0") { }
        }
        static void Pause()
        { 
            Console.Write("\nНажмите кнопку Ввод для продолжения....");
            Console.ReadLine();
        }
        static void TaskFirst()
        {
            Console.WriteLine("|================ Задача №1 ================|");

            int n, m;

            Console.WriteLine("Пример №1 (Тип результата int)");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            int r = m - ++n;
            Console.WriteLine($"n={n} m={m} m-++n={r}");

            Console.WriteLine(" ");

            Console.WriteLine("Пример №2 (Тип результата bool)");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            bool r2 = m++ > --n;
            Console.WriteLine($"n={n} m={m} m++>--n={r2}");

            Console.WriteLine(" ");

            Console.WriteLine("Пример №3 (Тип результата bool)");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            bool r3 = m-- < ++n;
            Console.WriteLine($"n={n} m={m} m--<++n={r3}");

            Console.WriteLine(" ");

            Console.WriteLine("Пример №4 (Тип результата double)");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            double r4 = 25 * Math.Pow(x, 5) - Math.Sqrt(Math.Pow(x, 2) + x);
            Console.WriteLine($"x={x} 25*x^5-Sqrt(x^2+x)={r4}");

            Console.WriteLine("Выражения закончились, вернитесь в главное меню");
            Pause();
        }

        static void TaskSecond()
        {
            Console.WriteLine("|================ Задача №2 ================|");

            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());

            bool check = CheckXY(x, y);
            Console.WriteLine($"x={x} y={y} {check}");

            Console.WriteLine("Выражения закончились, вернитесь в главное меню");
            Pause();
        }
        static bool CheckXY(double x, double y)
        {
            // Заштрихованная область находится в нижней части координат
            if (y > 0)
            {
                return false; // Отбрасываем все, что выше оси X (y > 0)
            }

            // Формула расчета принадлежности точки заданной окружности, с центром в (0;0)
            double xy = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return xy <= 1; // 1 -> Радиус окружности
        }

        static void TaskThird()
        {
            Console.WriteLine("|================ Задача №3 ================|");

            float a = 100F, b = 0.001F;
            float c = (float)(-3 * Math.Pow(a, 2) * b - Math.Pow(b, 3));
            if (c == 0)
            {
                Console.WriteLine($"Float:  a={a,-6} b={b,-6} result: Ошибка, делить на 0 нельзя.");
            }
            else
            {
                float r = (float)((Math.Pow(a - b, 3) - (Math.Pow(a, 3) + 3 * a * Math.Pow(b, 2))) / c);
                Console.WriteLine($"Float:  a={a,-6} b={b,-6} result: {r}");
            }

            double a2 = 100, b2 = 0.001D;
            double c2 = (-3 * Math.Pow(a2, 2) * b2 - Math.Pow(b2, 3));
            if (c2 == 0)
            {
                Console.WriteLine($"Double: a={a2,-6} b={b2,-6} result: Ошибка, делить на 0 нельзя.");
            }
            else
            {
                double r2 = ((Math.Pow(a2 - b2, 3) - (Math.Pow(a2, 3) + 3 * a2 * Math.Pow(b2, 2))) / c2);
                Console.WriteLine($"Double: a={a2,-6} b={b2,-6} result: {r2}");
            }
            Console.WriteLine("Выражения закончились, вернитесь в главное меню");
            Pause();
        }

    }
}
