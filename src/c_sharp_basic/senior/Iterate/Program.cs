using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterate
{
    class IterateSeason : System.Collections.IEnumerable
    {
        string[] seasons = new string[] { "春", "夏 ", "秋", "冬" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < seasons.Length; i++)
            {
                yield return seasons[i];
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 3, 4, 2, 1, 7 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }

            IterateSeason seasons = new IterateSeason();

            foreach (string sea in seasons)
            {
                Console.WriteLine(sea);
            }
        }
    }
}
