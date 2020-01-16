using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Point
    {
        public int data; //инф-ое поле
        public Point next; //указатель на след элемент списка

        public Point(int pData) //конструктор с параметрами
        {
            data = pData;
            next = null;
        }

        public Point() //конструктор без параметра
        {
            data = 0;
            next = null;
        }
        // Перегрузка метода .ToString()
        public override string ToString()
        {
            return data.ToString();
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Point beg = MakeList(5, toEnd: true);
            showList(beg);

            delElement(ref beg);
            showList(beg);
        }

        //функция создания элемента списка
        static Point MakePoint(int pData)
        {
            return new Point(pData);
        }

        //создание нового списка
        static Point MakeList(int size, bool toEnd = true)
        {
            Random rnd = new Random();
            int data = 1;//rnd.Next(1, 10);
            Console.WriteLine($"Добавляем элемент {data}");

            Point beg = MakePoint(data);

            if (toEnd) // Добавляем элементы в конец списка
            {
                Point r = beg; 
                for (int i = 1; i < size; i++)
                {
                    data =  i+1;//rnd.Next(0, 10);
                    Console.WriteLine($"Добавляем элемент {data}");
                    Point p = MakePoint(data);
                    r.next = p;
                    r = p;
                }
            }
            else // Добавляем элементы в начало списка 
            {
                Point r = beg;
                for (int i = 1; i < size; i++)
                {
                    data = i + 1;//rnd.Next(0, 10);
                    Console.WriteLine($"Добавляем элемент {data}");
                    Point p = MakePoint(data);
                    p.next = beg;
                    beg = p;
                }
            }
            return beg;
        }
        static void showList(Point beg)
        {
            Point p = beg;
            while (p != null)
            {
                Console.Write($"{p} ");
                p = p.next;
            }
            Console.WriteLine();
        }
        static void delElement(ref Point beg)
        {
            Point cur = beg;
            Point prev = beg;
            Point toDelete = null; 

            while (cur != null)
            { 
                if (cur.data % 2 == 0)
                {
                    toDelete = prev; 
                }
                if (cur.next == null) { break; }
                prev = cur;
                cur = cur.next;
            } 
            
            if (toDelete == beg)
            {
                Console.WriteLine($"Удален элемент с данными: {beg}");
                beg = beg.next;
            }
            else if(toDelete != null)
            {
                Console.WriteLine($"Удален элемент с данными: {toDelete.next}");
                toDelete.next = toDelete.next.next;
            } 
            else
            {
                Console.WriteLine($"В списке нет четных информационных полей");
            }
        }
    }
}
