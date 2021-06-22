using System;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Local
{
	internal class RandomHelper
    {
		private static readonly Random rng = new();

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
