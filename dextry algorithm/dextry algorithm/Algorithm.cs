using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dextry_algorithm
{
    class Algorithm
    {
        public InputData data { get; set; }
        public Algorithm(InputData data)
        {
            this.data = data;
        }
        public int Pass()
        {
            int currentNode = data.StartTop - 1;
            data.Costs.Add(currentNode, 0);
            Dictionary<int, int> topIndexCost;
            while (data.IsProcessedTops.Contains(false))
            {
                topIndexCost = Helpers.GetRow(data.Matrix, currentNode);
                for(int i = 0; i < topIndexCost.Count; i++)
                {
                    if (topIndexCost[i] != -1 && topIndexCost[i] != 0 && !data.IsProcessedTops[i])
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

            return data.Costs[data.EndTop - 1];
        }
    }
}
