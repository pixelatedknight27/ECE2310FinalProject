using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a list of unique locations

            List<Location> locations = new List<Location>
            {
                new Location(12, 9),
                new Location(4, 8),
                new Location(6, 6),
                new Location(10, 5),
                new Location(1, 3),
                new Location(4, 2),
                new Location(13, 1)
            };


            // create an empty list of pools

            List<Pool> pools = new List<Pool>();


            // initialize a HashSet of unvisited pool locations
                // No key needed, we just need to know it exists.
                // Search time O(1). 
                // allows for the size of the unvisited set to shrink

            HashSet<int> unvisited = new HashSet<int>();


            // initialize each pool with a location and an unititialized temp
            // initialize the HashSet of unvisited pools

            int itr = 0;

            // O(n)
            foreach (Location location in locations)
            {

                // spaghetti? i think not.
                Pool pool = new Pool(location: location);
                pools.Add(pool);

                unvisited.Add(itr);

                itr++;

            }

            Console.WriteLine();

            // where the fun begins

            Pool currentPool = new Pool();

            Random rnd = new Random();


            // will only iterate for however many pools are in the list

            // O(n)
            for (int i = 0; i < Pool.count; ++i)
            {
                double minDist = double.PositiveInfinity;
                int minDistIndex = -1;

                // iterate through unvisited pools and find minimum distance

                // O(n)*
                foreach (int poolIndex in unvisited)
                {
                    double dist = pools[poolIndex].FindDistance(currentPool);

                    if (dist < minDist)
                    {
                        minDist = dist;
                        minDistIndex = poolIndex;
                    }
                }


                // once the location and iterator of the nearest pool is found


                // update it's temperature
                double temp = rnd.Next(98, 105);


                Console.WriteLine(minDistIndex);
                pools[minDistIndex].Temp = new Temperature(temp, "F");

                Console.WriteLine("visited " + pools[minDistIndex].ToString());


                // remove it from the unvisited list

                    // this is where the hash set comes in handy
                    // to remove in a List is O(n), even if you have the index - needs time to re-allocate memory
                    // to find and remove in a HashSet is O(1)
                    // any time saved inside a nested for loop is valuable

                unvisited.Remove((int)minDistIndex);


                // update the location of the current pool to the nearest pool

                currentPool = pools[(int)minDistIndex];

            }

            Console.WriteLine();

            // making sure all pools in the list have maintained their temperature

            foreach (Pool pool in pools)
            {
                Console.WriteLine(pool.ToString());
            }

            // not gonna try to benchmark because no one else will be benchmarking so there will be nothing to compare to

            // . represents the list shrinking after every iteration

            // Time complexity with HashSet:
            // O(O(n). + O(1)) =
            // O((n^2) / 2) =
            // O(n^2)

            // Time complexity with array:
            // O(O(n)) =
            // O(n^2)

            // Time complexity with List:
            // O(O(n). + O(n).) =
            // O(O(n)) =
            // O(n^2)

            // HashSet is 2x as fast as both indexing through an array and searching through a dynamic sized list!

            // technically the same O time complexity as list approach to store unvisited pools, but it's not the optimal solution.


            Console.Write("\npress enter to exit");
            Console.ReadLine();
        }
    }
}
