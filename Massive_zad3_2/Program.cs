using System;

namespace Massive_zad3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив, состоящий из 8 элементов, через пробел:");
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<15)
                {
                    array[i] *= 2;
                }
            }
            Console.WriteLine($"Изменненый массив: {string.Join(',', array)}");
                
        }
    }
}
