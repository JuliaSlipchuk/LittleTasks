using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace crossing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, allowCrossedOutCells;
            string temp;
            string helperO = "", helperX = "";
            StringBuilder tape = new StringBuilder();
            do
            {
                Console.Write("Enter count of cells: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out count) || count < 1);
            do
            {
                Console.Write("Enter the number of cells allowed to be crossed out: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out allowCrossedOutCells) || allowCrossedOutCells > (count / 2));
            Console.Write("Enter tape (O or X): ");
            temp = Console.ReadLine();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 'O' || temp[i] == 'X')
                {
                    tape.Append(temp[i]);
                }
            }
            while(tape.Length < count)
            {
                tape.Append('O');
            }
            for (int i = 0; i < allowCrossedOutCells; i++)
            {
                helperO += "O";
                helperX += "X";
            }

            if (!tape.ToString().Contains(helperO))
            {
                Console.WriteLine("Cells cannot be crossed out");
                Console.ReadKey();
            }
            bool player = true; // true - first player, false - second player
            while(tape.ToString().Contains(helperO))
            {
                int indexInTape = SearchIndexForCrossOut(tape, helperO);
                if (indexInTape != -1)
                {
                    tape.Replace(helperO, helperX, indexInTape, helperO.Length);
                    player = !player;
                }
                else
                {
                    break;
                }
            }
            if (player)
            {
                Console.WriteLine("Winner is player 2!");
            }
            if (!player)
            {
                Console.WriteLine("Winner is player 1!");
            }

            Console.ReadKey();
        }
        private static int SearchIndexForCrossOut(StringBuilder tape, string helper)
        {
            int indexInTape;
            StringBuilder template = new StringBuilder();
            template.Append(helper);
            int counter = helper.Length - 1;
            while(counter > 0)
            {
                template.Append('O');
                counter--;
            }
            counter = template.Length;
            while(counter >= helper.Length)
            {
                if (tape.ToString().Contains(template.ToString()))
                {
                    indexInTape = tape.ToString().IndexOf(template.ToString()) + template.Length - helper.Length;
                    return indexInTape;
                }
                template.Remove(0, 1);
                counter--;
            }
            return -1;
        }
    }
}
