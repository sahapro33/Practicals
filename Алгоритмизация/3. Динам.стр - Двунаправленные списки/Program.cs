using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point2
    {
        public string data;
        public Point2 prev, next;

        // Конструктор класса для создания пустого элемента
        public Point2()
        {
            data = String.Empty;
            prev = null;
            next = null;
        }
        
        // Конструктор класса для содания
        // элемента с заполненым полеме data 
        public Point2(string str)
        {
            data = str;
            prev = null;
            next = null;
        }

        // Конструктор класса для создания элемента 
        // с полностью заполнеными полями
        public Point2(string str, Point2 pLeft = null, Point2 pRight = null)
        {
            data = str;
            prev = pLeft;
            next = pRight;
        }

        // Метод генерации списка из size элементов
        // возвращает первый элемент
        static public Point2 MakeList(int size) //добавление в начало
        {
            Random rnd = new Random();
            string data = "1";// rnd.Next(0, 9).ToString();

            Point2 beg = new Point2(data);
            Console.WriteLine($"Добавлен элемент с данными: '{beg.data}'");

            Point2 prev = beg;
            for(int i = 1; i < size; i++)
            {
                data = (i + 1).ToString();//rnd.Next(0, 9).ToString();

                Point2 newPoint = new Point2(data,prev);
                prev.next = newPoint;
                prev = newPoint;

                Console.WriteLine($"Добавлен элемент с данными: '{newPoint.data}'");
            }
             
            return beg;
        } 

        // Метод "печати" двунаправленного списка
        public void Show()
        { 
            Point2 p = this;
            while (p != null)
            {
                Console.Write($"'{p.data}' ");
                p = p.next;
            }
            Console.WriteLine();
        }

        // Мотод вставки элемента вместо элемента prev
        // возвращает вставленный элемент
        static public Point2 Insert(Point2 elem, Point2 cur)
        {
            elem.prev = cur.prev;
            elem.next = cur;

            cur.prev = elem; 
            elem.prev.next = elem; 

            return elem;
        }

        // Мотод вставки элемента вместо элемента с 
        // "индексом" prevNumber , нумерация начинается с 1 , 2 ... n
        static public Point2 Insert(Point2 elem, Point2 begin, int curNumber)
        {
            Point2 cur = begin;
            do
            {
                if(cur == null || cur.next == null)
                {
                    return null;
                }

                cur = cur.next;
            } while (--curNumber > 1);

            return Point2.Insert(elem, cur);
        }
    }

    class Program
    {
        // Тип информационного поля string.
        // Добавить в список элемент с заданным номером.
        static void Main(string[] args)
        {
            Point2 beg = Point2.MakeList(5);
            beg.Show();

            Point2 newPoint = new Point2("t");
            //Point2.Insert(newPoint, beg.next);
            //beg.Show();

            Point2 result = Point2.Insert(newPoint, beg, 2);
            if (result == null)
            {
                Console.WriteLine($"Неудалось добавить элемент '{newPoint.data}' в список");
            }
            else
            {
                if (result.next == null)
                {
                    Console.WriteLine($"В список добавлен элемент '{result.data}', в конец списка");
                }
                else Console.WriteLine($"В список добавлен элемент '{result.data}', между элементами '{result.prev.data}' и '{result.next.data}'");
            }
            beg.Show();
        } 
    }
}
