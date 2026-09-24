using System;

namespace Step6_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Таблица умножения (цикл for) ");
            Console.WriteLine();

            Console.Write("Введите число для таблицы умножения: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine();
                Console.WriteLine($"Таблица умножения для числа {number}:");
                

                for (int i = 1; i <= 10; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} × {i,2} = {result,3}");
                }

                
            }
            else
            {
                Console.WriteLine(" Ошибка: введено некорректное число.");
            }
        }
    }
}