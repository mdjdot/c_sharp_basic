using System;

namespace Function
{
    class Week
    {
        int day;
        public int Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (value <= 7)
                {
                    this.day = value;
                }
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Week week = new Week
            {
                Day = 3
            };
            Console.WriteLine($"week.Day = {week.Day}");
            week.Day = 10;
            Console.WriteLine($"week.Day = {week.Day}");
        }
    }
}
