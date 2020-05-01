using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peaceful_tours
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData data = new InputData();
            data.GetInputData();
            int numberOfOptions = data.GetResult();
            Console.WriteLine($"Number of options: {numberOfOptions}");

            Console.ReadKey();
        }
    }
}
