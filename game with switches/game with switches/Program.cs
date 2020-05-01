using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_with_switches
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData data = new InputData();
            data.GetInputData();

            data.GetSwitchState();
            Console.ReadKey();
        }
    }
}
