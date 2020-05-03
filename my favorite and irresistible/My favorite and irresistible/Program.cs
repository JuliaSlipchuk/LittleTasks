using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_favorite_and_irresistible
{
    class Program
    {
        static void Main(string[] args)
        {
            int denominator;
            do
            {
                Console.Write("Enter denominator: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out denominator) || denominator < 1);
            int countOfFractions = GetCountOfFractions(denominator);
            Console.WriteLine($"Count of fractions: {countOfFractions}");

            Console.ReadKey();
        }
        private static int GetCountOfFractions(int denominator)
        {
            int count = 0;
            if (denominator == 1)
            {
                return 0;
            }
            else
            {
                for (int i = denominator; i > 1; i--)
                {
                    for (int j = i - 1; j > 0; j--)
                    {
                        if (j != 1 && i % j == 0)
                        {
                            continue;
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
