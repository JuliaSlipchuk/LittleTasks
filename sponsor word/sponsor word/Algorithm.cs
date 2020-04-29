using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sponsor_word
{
    class Algorithm
    {
        public InputData data { get; set; }
        public Algorithm(InputData data)
        {
            this.data = data;
        }
        public void Pass()
        {
            int currentNode = data.PostOfficeStartNumber - 1;
            data.Costs.Add(currentNode, 0);
            Dictionary<int, int> topIndexCost;
            while (data.IsProcessedTops.Contains(false))
            {
                topIndexCost = Helpers.GetRow(data.Matrix, currentNode);
                for (int i = 0; i < topIndexCost.Count; i++)
                {
                    if (topIndexCost[i] != Int32.MaxValue && topIndexCost[i] != 0 && !data.IsProcessedTops[i])
                    {
                        if (!data.Costs.ContainsKey(i))
                        {
                            data.Costs.Add(i, topIndexCost[i] + data.Costs[currentNode]);
                        }
                        else if (data.Costs.ContainsKey(i) && data.Costs[i] > topIndexCost[i] + data.Costs[currentNode])
                        {
                            data.Costs[i] = topIndexCost[i] + data.Costs[currentNode];
                        }
                    }
                }
                data.IsProcessedTops[currentNode] = true;
                int minValue = topIndexCost.Values.Where(v => v > 0).Min();
                currentNode = topIndexCost.Where(i => i.Value == minValue).Select(i => i.Key).ToList()[0];
            }
        }
        public void GetResult(List<int> winnersNumbers, Dictionary<int, int> costs)
        {
            if (!costs.ContainsKey(winnersNumbers[0] - 1))
            {
                Console.WriteLine("It is not fault of sponsor...");
                return;
            }
            int maxTime = costs[winnersNumbers[0] - 1];
            for (int i = 0; i < winnersNumbers.Count; i++)
            {
                if (!costs.ContainsKey(winnersNumbers[i] - 1)/* || costs[winnersNumbers[i] - 1] == Int32.MaxValue*/)
                {
                    Console.WriteLine("It is not fault of sponsor...");
                    return;
                }
                if (costs[winnersNumbers[i] - 1] > maxTime)
                {
                    maxTime = costs[winnersNumbers[i] - 1];
                }
            }
            Console.WriteLine("The good sponsor!");
            Console.WriteLine($"Max time: {maxTime}");
        }
    }
}
