using System;

namespace OOP
{
    #region 接口实现
    interface IRectangle
    {
        double Width { get; set; }
        double Height { get; set; }
        double Area();
    }

    class Rectangle : IRectangle
    {
        double width;
        double height;
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double Area()
        {
            return width * height;
        }
    }
    #endregion

    #region 抽象类使用
    abstract class ACircle
    {
        double radium;
        public double Radium { get => radium; set => radium = value; }
        public abstract double Area();
    }

    class Circle : ACircle
    {
        public override double Area()
        {
            return Math.PI * Radium * Radium;
        }
    }
    #endregion

    class Program
    {
        static void Main()
        {
            IRectangle irec = new Rectangle { Width = 3.4, Height = 4.3 };
            Console.WriteLine($"irec type = {irec.GetType()}");
            Console.WriteLine($"irec area = {irec.Area()}");

            Circle circle = new Circle { Radium = 3.4 };
            Console.WriteLine($"circle area = {circle.Area()}");

            ACircle aCircle = new Circle { Radium = 3.4 };
            Console.WriteLine($"aCircle area = {aCircle.Area()}");
        }
    }
}
