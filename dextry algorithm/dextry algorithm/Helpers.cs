using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sponsor_word
{
    class Helpers
    {
        public static Dictionary<int, int> GetRow(int[,] matrix, int rowNumber)
        {
            int[] array = Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
            Dictionary<int, int> topIndexCost = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                topIndexCost.Add(i, array[i]);
            }
            return topIndexCost;
        }
    }
}
