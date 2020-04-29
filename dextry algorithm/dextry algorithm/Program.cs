using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dextry_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData input = new InputData();
            input.GetCountOfTops();
            input.GetStartTop();
            input.GetEndTop();

            Algorithm algorithm = new Algorithm(input);
            int cost = algorithm.Pass();
            Console.WriteLine($"Cost from {input.StartTop} to {input.EndTop} is {cost}");

            Console.ReadKey();
        }
    }
}
