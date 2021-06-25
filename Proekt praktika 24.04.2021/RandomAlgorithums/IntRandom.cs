using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proekt_praktika_24._04._2021.RandomAlgorithums
{
    public class IntRandom
    {
        public string IntGenerator(int tries, int min, int max)
        {
            max++;
            Random _random = new Random();
            int[] arr = new int[tries];
            Random r = new Random();
            int[] count = new int[max * tries];
            for (int i = 0; i < tries; i++)
            {
                arr[i] = r.Next(min, max);
            }

            for (int i = 0; i < tries + 1; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < tries; i++)
            {
                ++count[arr[i]];
            }

            string name = "";

            for (int x = 0; x < max; x++)
            {
                if (count[x] > 0)
                {
                    name += "<div>" + "Number " + x + " appears " + count[x] + " times" + "  " + Math.Round((Convert.ToDouble((count[x])) * 100 / tries), 2) + "%" + " <div/>";
                }
                else
                {
                    continue;
                }
            }

            return name;

        }
    }
}