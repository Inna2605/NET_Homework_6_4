//Створіть інтерфейс ICalc2. У ньому мають бути два методи:
//■ int CountDistinct() — повертає кількість унікальних значень у контейнері даних;
//■ int EqualToValue(int valueToCompare) — повертає кількість значень, рівних valueToCompare.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс ICalc2.
//Метод CountDistinct — повертає кількість унікальних значень в масив.
//Метод EqualToValue — повертає кількість елементів масиву, рівних valueToCompare.
//Напишіть код для тестування отриманої функціональності.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_4
{
    internal interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
