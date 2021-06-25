using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proekt_praktika_24._04._2021.RandomAlgorithums
{
    public class DoubleRandom
    {
        private Dictionary<double, int> RunIntNDoubleRandoms(int Iterations, int Decimals)
        {
            Random randObj = new Random();
            double[] a = new double[Iterations];

            Dictionary<double, int> counter = new Dictionary<double, int>();

            for (int i = 0; i < Iterations; i++)
            {
                double interval = Math.Pow(10, (double)(-Decimals));
                double number = randObj.NextDouble() * (1.0 + interval) - interval / 2;
                a[i] = Math.Round(number, Decimals);

                if (!counter.ContainsKey(a[i]))
                {
                    counter[a[i]] = 0;
                }

                counter[a[i]] += 1;

            }

            return counter;

        }

        public DataTable GetRandomNumbersData(int Iterations, int Decimals)
        {

            DataTable tableRandomDouble = new DataTable();
            tableRandomDouble.Columns.Add("Number", typeof(double));
            tableRandomDouble.Columns.Add("Times", typeof(int));
            tableRandomDouble.Columns.Add("Percent", typeof(double));
            foreach (KeyValuePair<double, int> doubleNumber
                in RunIntNDoubleRandoms(Iterations, Decimals))
            {
                double percents = Math.Round((Convert.ToDouble(doubleNumber.Value) / Iterations * 100), 2);
                tableRandomDouble.Rows.Add(doubleNumber.Key, doubleNumber.Value, percents);

            }
            return tableRandomDouble;


        }
    }
}