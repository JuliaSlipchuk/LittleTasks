using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_with_switches
{
    class InputData
    {
        public int TestsCount { get; set; }
        public List<int> Tests { get; set; }

        public void GetInputData()
        {
            int count;
            Console.Write("Enter tests count: ");
            if (Int32.TryParse(Console.ReadLine(), out count) && count > 0)
            {
                this.TestsCount = count;
            }
            else
            {
                this.TestsCount = 1;
            }
            this.Tests = new List<int>();
            int test;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter {i} test: ");
                if (Int32.TryParse(Console.ReadLine(), out test) && test > 0)
                {
                    this.Tests.Add(test);
                }
                else
                {
                    i--;
                    continue;
                }
            }
        }
        public void GetSwitchState()
        {
            bool state;
            string result;
            for (int i = 0; i < this.TestsCount; i++)
            {
                state = false;
                for (int j = 1; j <= this.Tests[i]; j++)
                {
                    if (this.Tests[i] % j == 0)
                    {
                        state = !state;
                    }
                    Console.WriteLine($"{j} - {state}");
                }
                result = state ? string.Format("Switch {0} is ON", this.Tests[i]) :  string.Format("Switch {0} is OFF", this.Tests[i]);
                Console.WriteLine(result);
            }
        }
    }
}
