using System;

namespace Labwork7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Func<double, double> discountCalculator = null;
            discountCalculator += price => price * 0.95;
            discountCalculator += price => price * 0.90;
            discountCalculator += price => price - 100;

            double currentPrice = 1000;
            Console.WriteLine($"Початкова ціна: {currentPrice}");
            
            foreach (Func<double, double> discountStep in discountCalculator.GetInvocationList())
            {
                currentPrice = discountStep(currentPrice);
            }

            Console.WriteLine($"Фінальна ціна після конвеєру: {currentPrice}");
        }
    }
}