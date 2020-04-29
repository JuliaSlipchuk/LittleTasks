using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sponsor_word
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData data = new InputData();

            Algorithm algorithm = new Algorithm(data);
            algorithm.Pass();
            algorithm.GetResult(data.WinnersNumbers, data.Costs);

            Console.ReadKey();
        }
    }
}
