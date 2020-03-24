using System;

namespace Control
{
    class Program
    {
        static void Main()
        {
            int I = 1;
            do
            {
                if (I >= 6)
                {
                    Console.WriteLine($"I = {I}");
                    //break;
                    goto Pass;
                }
                I++;
            }
            while (true);

        Pass:;

            int n = 12;
            switch (n > 10)
            {
                case false:
                    Console.WriteLine("n <= 10");
                    break;
                case true:
                    Console.WriteLine("n > 10");
                    break;
            }

        }
    }
}
