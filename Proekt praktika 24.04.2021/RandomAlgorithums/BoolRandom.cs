using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proekt_praktika_24._04._2021.RandomAlgorithums
{
    public class BoolRandom
    {
        public string BoolRandomGenerator(int n)
        {
            
            bool[] array = new bool[n];
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                int rand = rng.Next(1, 1000);
                if (rand < 500)
                {
                    array[i] = false;
                }
                else 
                {
                    array[i] = true;
                }
            }
            double count = 0;
            foreach (bool val in array)
            {
                if (val == true)
                {
                    count++;
                }
            }
            double m = Convert.ToDouble(n);
            string result = "True: " + Math.Round(count / m * 100, 2) + " %  " + " False:" + Math.Round((m - count) / m * 100, 2) + "%";
            return result;
        }
    }
}