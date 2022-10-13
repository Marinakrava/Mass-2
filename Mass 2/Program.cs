using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];// массив из 15 элементов
            Random random = new Random();   // вводим рандомную переменную, чтобы в массиве генерировались случайные числа
            double s = 0;// объявляем переменную суммы
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);// вводим диапазон рандомных чисел
                Console.WriteLine(" {0}", array[i]);
            }
            Console.WriteLine();
            int max = array[0];// вводим переменную для максимального числа и сравнимаем с первым числом из массива
            foreach (int a in array) // перебираем все числа из массива
            {
                if (a > max)
                    max = a; // находим максимальное число из массива
            }
            int min = array[0];// вводим переменную для минимального числа и сравнимаем с первым числом из массива
            foreach (int b in array) // перебираем все числа из массива
            {
                if (b < min)
                    min = b; // находим минимальное число из массива
                s = (max + min) / 2.0;// находим среднее арифметическое max и min
            }
            Console.WriteLine("Минимальное число = {0}", min);
            Console.WriteLine("Максимальое число = {0}", max);
            Console.WriteLine("Среднее арифметическое = {0}", s);
            Console.ReadKey();

        }
    }
}
