using System;

namespace Expression
{
    class Program
    {
        static void Main()
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = n1 + n2;
            string a1 = n3 + "15";
            Console.WriteLine($"n1 = {n1}");
            Console.WriteLine($"n2 = {n2}");
            Console.WriteLine($"n3 = {n3}");
            Console.WriteLine($"a1 = {a1}");

            int n4 = n1 > n2 ? n1 : n2;
            Console.WriteLine($"n4 = {n4}");
        }
    }
}
