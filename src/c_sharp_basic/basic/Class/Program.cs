using System;

namespace Class
{
    class Rectangle
    {
        double width;
        double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double Area() => width * height;
    }
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle { Width = 3.4, Height = 4.5 };
            Console.WriteLine($"rectangle area = {rectangle.Area()}");
        }
    }
}
