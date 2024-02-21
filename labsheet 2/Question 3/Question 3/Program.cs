using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    using System;

    class TemperatureTracker
    {
        private double[] temperatures;

        public TemperatureTracker(int days)
        {
            temperatures = new double[days];
        }

        public void SetTemperature(int day, double temperature)
        {
            if (day >= 0 && day < temperatures.Length)
            {
                temperatures[day] = temperature;
            }
            else
            {
                Console.WriteLine("Invalid day. Day should be between 0 and " + (temperatures.Length - 1));
            }
        }

        public void DisplayWeeklyReport()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine("Day " + i + ": " + temperatures[i] + "°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int daysInWeek = 7;
            TemperatureTracker tracker = new TemperatureTracker(daysInWeek);

            // Input temperatures for each day
            for (int i = 0; i < daysInWeek; i++)
            {
                Console.Write("Enter temperature for day " + i + ": ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                tracker.SetTemperature(i, temperature);
            }

            // Display the weekly temperature report
            tracker.DisplayWeeklyReport();

            Console.ReadLine(); // Keep the console window open
        }
    }

}