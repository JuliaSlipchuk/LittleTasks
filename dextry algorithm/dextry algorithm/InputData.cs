using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dextry_algorithm
{
    class InputData
    {
        public int TopsCount { get; set; }
        public int StartTop { get; set; }
        public int EndTop { get; set; }
        public int[,] Matrix { get; set; }
        public Dictionary<int, int> Costs { get; set; }
        public bool[] IsProcessedTops { get; set; }

        public void GetCountOfTops()
        {
            int count;
            Console.Write("Enter count of tops: ");
            if (Int32.TryParse(Console.ReadLine(), out count))
            {
                this.TopsCount = count;
            }
            else
            {
                this.TopsCount = 3;
            }
            FillMatrix(this.TopsCount);
            Costs = new Dictionary<int, int>();
            IsProcessedTops = new bool[this.TopsCount];
        }
        public void GetStartTop()
        {
            int start;
            Console.Write("Enter start of tops: ");
            if (Int32.TryParse(Console.ReadLine(), out start) && start <= this.TopsCount)
            {
                this.StartTop = start;
            }
            else
            {
                this.StartTop = 1;
            }
        }
        public void GetEndTop()
        {
            int end;
            Console.Write("Enter end of tops: ");
            if (Int32.TryParse(Console.ReadLine(), out end) && end <= this.TopsCount)
            {
                this.EndTop = end;
            }
            else
            {
                this.EndTop = 2;
            }
        }
        public void FillMatrix(int topsCount)
        {
            this.Matrix = new int[topsCount, topsCount];
            int temp;
            for(int i = 0; i < topsCount; i++)
            {
                for (int j = 0; j < topsCount; j++)
                {
                    if (i != j)
                    {
                        Console.Write($"Enter element [{i}][{j}]: ");
                        if (Int32.TryParse(Console.ReadLine(), out temp))
                        {
                            this.Matrix[i, j] = temp;
                        }
                        else if (i == j)
                        {
                            this.Matrix[i, j] = 0;
                        }
                        else
                        {
                            this.Matrix[i, j] = -1;
                        }
                    }
                    else
                    {
                        this.Matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
