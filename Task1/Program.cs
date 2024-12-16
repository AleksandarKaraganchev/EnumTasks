using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a month in a number from 1 to 12 to see, which season it is(Winter, Spring, Summer, Autumn:");
            int month = int.Parse(Console.ReadLine());
            CaluclateMonthToSeason(month);
        }

        private static void CaluclateMonthToSeason(int month)
        {
            Season season;
            if (month >= 1 && month <= 12)
            {
                if (month == 12 || month == 1 || month == 2)
                {
                    season = Season.Winter;
                    Console.WriteLine($"Month {month} -> {season}.");
                }
                if (month >= 3 && month <= 5)
                {
                    season = Season.Spring;
                    Console.WriteLine($"Month {month} -> {season}.");
                }

                if (month >= 6 && month <= 8)
                {
                    season = Season.Summer;
                    Console.WriteLine($"Month {month} -> {season}.");
                }
                if (month == 9 || month == 10 || month == 11)
                {
                    season = Season.Autumn;
                    Console.WriteLine($"Month {month} -> {season}.");
                }
            }
            else
            {
                throw new ArgumentException("Please enter a nubmer from 1 to 12!!!");
            }
        }
    }
}
