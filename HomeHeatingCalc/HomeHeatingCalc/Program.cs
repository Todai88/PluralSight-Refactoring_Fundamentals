using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeHeatingCalc
{
    public class Program
    {
        private const int ELECTRICITY_MULTIPLIER = 293;
        private const decimal costPerKwHr = 0.12m;

        static void Main(string[] args)
        {
            Console.WriteLine("Home Heating Calculator...");
            Console.WriteLine("How many square feet is your home? (1500 or 2500)");
            int size = 1500;

            int.TryParse(Console.ReadLine(), out size);

            Console.WriteLine("How sever are your winters? (Mild, moDerate, Severe)");
            char severity = Console.ReadLine().ToUpper().Trim()[0];

            decimal cost = CalculateCost(size, severity);
            Console.WriteLine($"Cost: {cost}");
            Console.WriteLine();
        }

        public static decimal CalculateCost(int size, char severity)
        {
            switch (severity)
            {
                case 'M':
                    return (decimal)size * 1000 * costPerKwHr * ELECTRICITY_MULTIPLIER / 1000000;
                case 'D':
                    return (decimal)size * 2000 * costPerKwHr * ELECTRICITY_MULTIPLIER / 1000000;
                case 'S':
                    return (decimal)size * 5000000 * costPerKwHr * ELECTRICITY_MULTIPLIER / 1000000;
                default:
                    throw new ArgumentException("Incorrect value!");
            }
        }
    }
}
