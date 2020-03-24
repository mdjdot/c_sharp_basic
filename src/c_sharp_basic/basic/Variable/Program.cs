using System;

namespace Variable
{
    class Program
    {
        const int K = 18;
        static void PrintVariable()
        {
            string a = "hello, the one";
            Console.WriteLine(a);
        }
        static void Main()
        {
            PrintVariable();
            Console.WriteLine(K);
        }
    }
}
