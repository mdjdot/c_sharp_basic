using System;
using System.IO;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string s1 = "hello, the one";
            char[] cs = s1.ToCharArray();
            Array.Reverse(cs);
            string s2 = new string(cs);
            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");

            string sWithSpaces = " abc 123 ccc ";
            Console.WriteLine(sWithSpaces.Replace(" ", ""));

            string aPath = @"D:\github\c_sharp_basic\src\c_sharp_basic\basic\Variable\Program.cs";
            Console.WriteLine($"Path = {Path.GetDirectoryName(aPath)}\nFile = {Path.GetFileNameWithoutExtension(aPath)}\nExtension = {Path.GetExtension(aPath)}");

        }
    }
}
