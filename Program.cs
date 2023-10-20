//Створіть інтерфейс ICalc2. У ньому мають бути два методи:
//■ int CountDistinct() — повертає кількість унікальних значень у контейнері даних;
//■ int EqualToValue(int valueToCompare) — повертає кількість значень, рівних valueToCompare.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс ICalc2.
//Метод CountDistinct — повертає кількість унікальних значень в масив.
//Метод EqualToValue — повертає кількість елементів масиву, рівних valueToCompare.
//Напишіть код для тестування отриманої функціональності.

using NET_Homework_6_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Arreys arr = new Arreys(size);
            arr.Show();

            Console.WriteLine("\nВпорядкований масив:");
            arr.RandShow();

            Console.Write($"\n\nУнікальні значеня: ");
            int unique = arr.CountDistinct();
            Console.WriteLine($"\nКількість унікальних значень: {unique}");

            Console.Write("\nВведіть число, щоб знайти кількість рівних йому значень: ");
            int G = Convert.ToInt32(Console.ReadLine());
            int Same = arr.EqualToValue(G);
            Console.WriteLine($"Кількість елементів рівних {G} дорівнює {Same}\n");

            Console.ReadLine();
        }
    }
}
