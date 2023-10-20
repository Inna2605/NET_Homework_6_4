//Створіть інтерфейс ICalc2. У ньому мають бути два методи:
//■ int CountDistinct() — повертає кількість унікальних значень у контейнері даних;
//■ int EqualToValue(int valueToCompare) — повертає кількість значень, рівних valueToCompare.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс ICalc2.
//Метод CountDistinct — повертає кількість унікальних значень в масив.
//Метод EqualToValue — повертає кількість елементів масиву, рівних valueToCompare.
//Напишіть код для тестування отриманої функціональності.

using NET_Homework_6_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_3
{
    internal class Arreys : ICalc2
    {
        int[] ar;
        public Arreys(int size)
        {
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                ar[i] = r.Next(a, b);
            }
        }
        public void Input(int size)
        {
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть значення елементу {i + 1}: ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void Show()
        {
            Console.Write("Елементи масиву:\n");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public void RandShow()
        {
            Array.Sort(ar);
            foreach (int i in ar)
            {
                Console.Write($"{i} ");
            }
        }
        public int CountDistinct()
        {
            int b = 0, j;
            for (int i = 0; i < ar.Length; i++)
            {
                j = i + 1;
                if(j + 1 == ar.Length) {  break; }
                while(ar[i] != ar[j])
                {
                    Console.Write($"{ar[i]} ");
                    b++;
                    break;
                }
            }
            return b;
        }
        public int EqualToValue(int valueToCompare)
        {
            int c = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == valueToCompare)
                {
                    c++;
                }
            }
            return c;
        }
    }
}
