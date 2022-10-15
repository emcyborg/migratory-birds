using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLiftDay2Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sightedBirds = new[]
            {
                1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4
            };
            var countsOfBirdsSighted = GetCountsOfBirdsSighted(sightedBirds);
        }

        static Dictionary<int, int> GetCountsOfBirdsSighted(int[] sightedBirds)
        {
            var sightedBirdsCount = new Dictionary<int, int>();

            foreach (var sightedBird in sightedBirds)
            {
                if (sightedBirdsCount.ContainsKey(sightedBird))
                {
                    var count = sightedBirdsCount[sightedBird];
                    sightedBirdsCount[sightedBird] = count + 1;
                }
                else
                {
                    sightedBirdsCount.Add(sightedBird, 1);
                }
            }

            return sightedBirdsCount;
        }

        static int GetSmallestCountOfBirdId(Dictionary<int, int> sightedBirdsCounts)
        {

        }

        static Dictionary<int, int> SortSightedBirdsCounts(Dictionary<int, int> sightedBirdsCounts)
        {

        }
    }
}
