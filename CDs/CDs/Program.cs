using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int sum = 0;
            do
            {
                Console.Write("Enter count of disks: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out count) || count <= 0);
            int countHundredDisks = count / 100;
            sum += countHundredDisks * 100;
            count -= sum;
            int countTwentyDisks = count / 20;
            sum += countTwentyDisks * 30;
            count -= countTwentyDisks * 20;
            sum += count * 2;
            Console.WriteLine($"Total sum: {sum}");

            Console.ReadKey();
        }
    }
}
