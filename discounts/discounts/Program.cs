using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discounts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, price;
            int totalSum = 0;
            do
            {
                Console.Write("Enter count of prizes: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out count) || count < 1);
            int[] prises = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter price of {i + 1} prize: ");
                if (Int32.TryParse(Console.ReadLine(), out price) && price > 1)
                {
                    prises[i] = price;
                }
                else
                {
                    Console.WriteLine("Something went wrong, try again!");
                    i--;
                }
            }
            if (prises.Length == 1)
            {
                totalSum += prises[0];
            }
            else if (prises.Length == 2)
            {
                totalSum += prises[1];
            }
            else
            {
                Array.Sort(prises);
                Array.Reverse(prises);

                int j;
                int minPrice;
                for (j = 2; j < prises.Length; j += 3)
                {
                    totalSum += prises[j] + prises[j - 1] + prises[j - 2];
                    minPrice = prises[j] < prises[j - 1] && prises[j] < prises[j - 2] ? prises[j] : prises[j - 1] < prises[j] && prises[j - 1] < prises[j - 2] ? prises[j - 1] : prises[j - 2];
                    totalSum -= minPrice;
                }
                j -= 2;
                while(j < prises.Length)
                {
                    totalSum += prises[j];
                    j++;
                }
            }
            Console.WriteLine($"Total sum is {totalSum}");

            Console.ReadKey();
        }
    }
}
