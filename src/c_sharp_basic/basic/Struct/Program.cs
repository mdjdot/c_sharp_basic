using System;

namespace Struct
{
    struct Circle
    {
        double radium;

        public double Radium { get => radium; set => radium = value; }

        public double Area()
        {
            return Math.PI * radium * radium;
        }


    }
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle
            {
                Radium = 4.5
            };
            Console.WriteLine($"circle area = {circle.Area()}");
        }
    }
}
