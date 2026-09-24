using System;

namespace Step3_WeatherChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Выбор одежды по погоде ");
            Console.WriteLine();

            Console.Write("Введите температуру на улице (°C): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double temperature))
            {
                Console.WriteLine();
                if (temperature >= 20)
                {
                    Console.WriteLine(" Наденьте лёгкую одежду: футболку и шорты.");
                }
                else
                {
                    Console.WriteLine("Наденьте тёплую одежду: куртку и свитер.");
                }
            }
            else
            {
                Console.WriteLine(" Ошибка: введено некорректное число.");
            }
        }
    }
}