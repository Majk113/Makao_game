using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public static class Shuffler
    {
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (var i = list.Count; i > 0; i--)
                list.Swap(0, rnd.Next(0, i));
        }
    }
}
