namespace Lol.DBEntity.Common
{
    internal class RandomHelper
    {
        [ThreadStatic]
        private static Random local = new();
        private static readonly Random random = new();

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        internal static int Next(int v1, int v2)
        {
            lock (local)
            {
                return random.Next(v1, v2);
            }
        }
    }
}
