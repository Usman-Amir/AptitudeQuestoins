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

            List<int> FinalArray = new List<int>();
            var max = counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            var min = max - 1;

            var arrayWithMaxOccurances = counts.Where(x => x.Value >= min && x.Value <= max).Select(p => p.Key);
            foreach (var item in input)
            {
                if (arrayWithMaxOccurances.Contains(item))
                {
                    FinalArray.Add(item);
                }
            }
            FinalArray.Sort();
            return printClosest(FinalArray.ToArray(), FinalArray.Count());
        }
        static int printClosest(int[] arr, int n)
        {

            int firstMax = 0, secondMax = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if (arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }
            return (firstMax + secondMax);
        }
    }
}
