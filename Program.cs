using System;
using System.Collections.Generic;

namespace HackerRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
            //SockMerchant();
            //https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
            //CountingValleys();
            JumpingOnTheClouds();
        }

        private static void CountingValleys()
        {
            string steps = "DUDUUDUUUUUUDDDDDUDDUUUDUUUDDDUUUDDUDDDDUDDDDDUUDUDUDUDDDDUUDDUDDUUUUDDUUUUDUUDUUDUUUUDDDUDDUUUUDUDDDUUDUDUUDDUUUDUDDDUDUDUDUDUUUDUUUUUUDUDDDDDUDUDDDDUUUUUDUDUUUUUUUUDDDUUDUUDUDUDDDDDUDDDUDUUUDUDDDUDUUDUUDDDDDDDUDUDUUUDUDDUDUUDUDDDUUUDUDDDDUDDUDDUDUDUUDUDDDUDUUUDUUDUUUUUUUDUUUUUUUDDDDDUDDDUUUDDDUDDDUDDUUDDUUUDUUDDDUDUUDUUUDDUDDDDUUUUUUDUDUUDDDDUDUDDUUUDUDUUDDUUDDDUUDUUUUUDDUUDDDDUUUDUDUUDDUUDDUUDUDDDUDUDUDDUUDUDDUDUDDUUUDUDDUDDUUDUUDUDDDDDDDDDUDDUUDDUUUUDDUDUUDUUDUUDDDDUUUDUDDDDUDDUUDUDUDUUDDUUDUDUDDDDDUUUDDDDUDDDUUDDUUDDUUUDUDDDUDDDDDUUDUUUDDUDDDDUUUDDDDUUDDUUUDUUUDDUDUUUDUDDUUUDDDDDDDUUDDUDDUUUUUUDDDDUDDUDDUDDUDDDDDUUDDUDDDUDDUDUDDDUDUDUUDDUUDDDDUUDDUUUDUUDDDDDDUDUDDUDUUDDUDDDUUUUDDUUDUDDDDUUUDUUUUDDUDUUUDDUDUUUUUUDUUDDDDDUDDUDUDDDUDDDDUDUUUDUDUUDDUDDDUDUUDDDDDDDDUDUUDUDDUDDUDUUUDDDUDUDDUUUDUDUDDDUDDUDUUUDUDDDDDUDDDDDDUDUUUUDDUDDDUDDDUDUDUUUDDUDDUDDUUDDUDUDUDUUUUUDUUDDUUDUUDUUUDUDUDDUDDDUUDDDDUUDDUUUUDUUDUUUDDDDDUDDDDDUUUDDUUUDUUUDUUDUUUDUDUUDUDDUUUUUDUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU";
            int n = steps.Length;
            int level = 0;
            int valleys = 0;

            for (int i = 0; i < n; i++)
            {
                if (steps[i] == 'D') level++;
                if (steps[i] == 'U') level--;
                if (level == 0 && steps[i] == 'U') ++valleys;
            }
            Console.WriteLine("Number of valleys: " + valleys);
            Console.ReadLine();
        }

        private static void SockMerchant()
        {
            int n = 9;
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            HashSet<int> colors = new HashSet<int>();
            int pairs = 0;
            for (int i = 0; i < n; i++)
            {
                //add the first sock
                if (!colors.Contains(ar[i]))
                {
                    colors.Add(ar[i]);
                }
                //if exist, it means we have 2 socks (1 pair), so increase the pair and remove the sock item
                else
                {
                    pairs++;
                    colors.Remove(ar[i]);
                }
            }
            Console.WriteLine("Number of sock pairs: " + pairs);
            Console.ReadLine();
        }

        private static void JumpingOnTheClouds()
        {
            int[] clouds = new int[] { 0, 1, 0, 0, 1, 0, 0 };
            int numberClouds = clouds.Length;
            int steps = -1;
            for (int i = 0; i < numberClouds; i++, steps++)
            {
                if (i < (numberClouds - 2) && clouds[i + 2] == 0) i++;
            }
            Console.WriteLine("Number of steps: " + steps);
            Console.ReadLine();
        }
    }
}
