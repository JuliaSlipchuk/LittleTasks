using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter transitions (R, L or S): ");
            string tape = Console.ReadLine();
            StringBuilder tapeBuilder = new StringBuilder();
            tapeBuilder.Append(tape);
            for (int i = 0; i < tapeBuilder.Length; i++)
            {
                if (tapeBuilder[i] != 'S' && tapeBuilder[i] != 'L' && tapeBuilder[i] != 'R')
                {
                    tapeBuilder.Remove(i, 1);
                    i--;
                }
            }
            List<char> tapeInList = tape.ToCharArray().ToList();
            int countR = tapeInList.Where(i => i == 'R').Count();
            int countL = tapeInList.Where(i => i == 'L').Count();
            int countOfVisitedCells = Math.Abs(countR - countL) + 1;
            Console.WriteLine($"Robot visited {countOfVisitedCells} cells");

            Console.ReadKey();
        }
    }
}
