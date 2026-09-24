using System;

namespace Step6_StairsClimb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Подъём по лестнице (цикл while)");
            Console.WriteLine();

            Console.Write("Введите номер целевого этажа: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int targetFloor) && targetFloor > 0)
            {
                int currentFloor = 1;

                Console.WriteLine();
                Console.WriteLine("Начинаем подъём:");

                while (currentFloor < targetFloor)
                {
                    currentFloor++;
                    Console.WriteLine($" Поднялись на {currentFloor}-й этаж");
                }

                Console.WriteLine();
                Console.WriteLine($" Вы достигли {targetFloor}-го этажа!");
            }
            else
            {
                Console.WriteLine("❌ Ошибка: введите положительное число.");
            }
        }
    }
}