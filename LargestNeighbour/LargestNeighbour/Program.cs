using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNeighbour
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            int abc = Challenge(input);
        }

        public  static int Challenge(int[] input)
        {
            Dictionary<int, int> counts = input.GroupBy(x => x)
                                          .ToDictionary(g => g.Key,
                                                        g => g.Count());
            return 0;
        }
    }
}
