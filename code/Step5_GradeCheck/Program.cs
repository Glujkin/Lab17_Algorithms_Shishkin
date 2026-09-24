using System;

namespace Step5_GradeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Определение оценки по баллам ");
            Console.WriteLine();

            Console.Write("Введите количество баллов (0-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int points))
            {
                Console.WriteLine();

                if (points >= 91 && points <= 100)
                {
                    Console.WriteLine($" Баллы: {points} → Оценка: ОТЛИЧНО (5)");
                }
                else if (points >= 71 && points <= 90)
                {
                    Console.WriteLine($" Баллы: {points} → Оценка: ХОРОШО (4)");
                }
                else if (points >= 51 && points <= 70)
                {
                    Console.WriteLine($" Баллы: {points} → Оценка: УДОВЛЕТВОРИТЕЛЬНО (3)");
                }
                else if (points >= 0 && points <= 50)
                {
                    Console.WriteLine($" Баллы: {points} → Оценка: НЕУДОВЛЕТВОРИТЕЛЬНО (2)");
                }
                else
                {
                    Console.WriteLine($" Ошибка: баллы должны быть в диапазоне 0-100.");
                }
            }
            else
            {
                Console.WriteLine(" Ошибка: введено некорректное число.");
            }
        }
    }
}