using System;
using System.Collections.Generic;

namespace sponsor_word
{
    class InputData
    {
        public int ParticipantsCount { get; set; }
        public int PrizesCount { get; set; }
        public int TimeFramesCount { get; set; }
        public List<int> WinnersNumbers { get; set; }
        public int[,] Matrix { get; set; }
        public int PostOfficeStartNumber { get; set; }
        public Dictionary<int, int> Costs { get; set; }
        public bool[] IsProcessedTops { get; set; }

        public InputData()
        {
            this.Costs = new Dictionary<int, int>();
            this.GetCountOfParticipants();
            this.IsProcessedTops = new bool[this.ParticipantsCount];
            this.GetPrizesCount();
            this.GetTimeFramesCount();
        }

        public void GetCountOfParticipants()
        {
            int count;
            Console.Write("Enter participant count: ");
            if (Int32.TryParse(Console.ReadLine(), out count) && count > 3)
            {
                this.ParticipantsCount = count;
            }
            else
            {
                this.ParticipantsCount = 3;
            }
            FillMatrix();
        }
        public void GetPrizesCount()
        {
            int count;
            Console.Write("Enter prizes count: ");
            if (Int32.TryParse(Console.ReadLine(), out count) && count > 1 && count <= this.ParticipantsCount)
            {
                this.PrizesCount = count;
            }
            else
            {
                this.PrizesCount = 1;
            }
            GetWinnersNumbers();
        }
        public void GetTimeFramesCount()
        {
            int count;
            Console.Write("Enter time frames count: ");
            if (Int32.TryParse(Console.ReadLine(), out count) && count >= this.PrizesCount)
            {
                this.TimeFramesCount = count;
            }
            else
            {
                this.TimeFramesCount = this.PrizesCount;
            }
            GetTimesBtwPostOffices();
        }
        public void GetPostOfficeStartNumber()
        {
            int number;
            Console.Write("Enter post office start number: ");
            if (Int32.TryParse(Console.ReadLine(), out number) && number >= 1 && number >= this.PrizesCount)
            {
                this.PostOfficeStartNumber = number;
            }
            else
            {
                this.PostOfficeStartNumber = 1;
            }
        }
        public void GetWinnersNumbers()
        {
            int temp;
            WinnersNumbers = new List<int>();
            for (int i = 0; i < this.PrizesCount; i++)
            {
                Console.Write($"Enter {i + 1} winner: ");
                if (Int32.TryParse(Console.ReadLine(), out temp) && temp > 0 && temp <= this.ParticipantsCount && !WinnersNumbers.Contains(temp))
                {
                    WinnersNumbers.Add(temp);
                }
                else
                {
                    i--;
                    Console.WriteLine($"Number of winner should be greater than 0 less or equal to {this.ParticipantsCount}");
                }
            }
            GetPostOfficeStartNumber();
        }
        public void GetTimesBtwPostOffices()
        {
            int start, end, time;
            for (int i = 0; i < this.TimeFramesCount; i++)
            {
                Console.Write("Enter start post office: ");
                if (!Int32.TryParse(Console.ReadLine(), out start) || start <= 0 || start > this.ParticipantsCount)
                {
                    continue;
                }
                Console.Write("Enter end post office: ");
                if (!Int32.TryParse(Console.ReadLine(), out end) || end <= 0 || end > this.ParticipantsCount || end == start)
                {
                    continue;
                }
                Console.Write("Enter time: ");
                if (Int32.TryParse(Console.ReadLine(), out time) && time >= 0)
                {
                    Matrix[start - 1, end - 1] = time;
                }
            }
            CheckMatrix();
        }
        public void FillMatrix()
        {
            Matrix = new int[this.ParticipantsCount, this.ParticipantsCount];
            for (int i = 0; i < this.ParticipantsCount; i++)
            {
                for (int j = 0; j < this.ParticipantsCount; j++)
                {
                    if (i == j)
                    {
                        this.Matrix[i, j] = 0;
                    }
                    else
                    {
                        this.Matrix[i, j] = Int32.MaxValue;
                    }
                }
            }
        }
        public void CheckMatrix()
        {
            for (int i = 0; i < this.Matrix.GetLength(1); i++)
            {
                for (int j = 0; j < this.Matrix.GetLength(0); j++)
                {
                    if (Matrix[j, i] == 0 || Matrix[j, i] == Int32.MaxValue)
                    {
                        if(j == this.Matrix.GetLength(0) - 1 && i + 1 != PostOfficeStartNumber)
                        {
                            IsProcessedTops[i] = true;
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
