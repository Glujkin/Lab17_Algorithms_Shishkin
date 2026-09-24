using System;

namespace Step4_TipsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Калькулятор чаевых ===");
            Console.WriteLine();

            
            Console.Write("Введите сумму счёта (₽): ");
            string billInput = Console.ReadLine();

            
            Console.Write("Введите процент чаевых (%): ");
            string tipInput = Console.ReadLine();

            if (double.TryParse(billInput, out double bill) &&
                double.TryParse(tipInput, out double tipPercent))
            {
                
                double tips = bill * (tipPercent / 100.0);

                
                double total = bill + tips;

                
                Console.WriteLine();
                Console.WriteLine("=== Результат ===");
                Console.WriteLine($"Сумма счёта:    {bill:F2} ₽");
                Console.WriteLine($"Процент чаевых: {tipPercent:F2} %");
                Console.WriteLine($"Сумма чаевых:   {tips:F2} ₽");
                Console.WriteLine($"ИТОГО К ОПЛАТЕ: {total:F2} ₽");
            }
            else
            {
                Console.WriteLine(" Ошибка: введены некорректные данные.");
            }
        }
    }
}