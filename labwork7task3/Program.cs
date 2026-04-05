using System;

namespace Labwork7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Func<double, double> discountCalculator = null;
            
            discountCalculator += price => price * 0.95;  // -5%
            discountCalculator += price => price * 0.90;  // -10%
            discountCalculator += price => price - 100;   // -100 грн

            double initialPrice = 1000;
            
            double result = discountCalculator(initialPrice);

            Console.WriteLine($"Початкова ціна: {initialPrice}");
            Console.WriteLine($"Результат стандартного виклику: {result} (Очікувано 900)");
        }
    }
}