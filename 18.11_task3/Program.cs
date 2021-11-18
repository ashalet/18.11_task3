using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11_task3
//Задан массив из n целых чисел.
//Найти сумму и количество чисел,
//больших среднего арифметического элементов массива.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = " ";
            str = Console.ReadLine();
            var array = Array.ConvertAll(str.Split(' '), i => int.Parse(i));
            double average = (array.Sum()) / (array.Length);

            var array_2 = Array.FindAll(array, i => i > average);
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.Write(array_2[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
