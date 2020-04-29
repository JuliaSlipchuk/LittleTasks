using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_offsets
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            List<int> binaryNumb;
            List<int> binaryResult;
            int result;

            Console.Write("Enter number: ");
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                GetNumbInBinary(number, out binaryNumb);
                binaryResult = DoOffsets(binaryNumb);
                result = GetNumbFromBinary(binaryResult);
                Console.WriteLine($"Result is {result}");
            }
            else
            {
                Console.WriteLine("You entered invalid number");
            }

            Console.ReadKey();
        }
        static void GetNumbInBinary(int number, out List<int> binaryNumb)
        {
            binaryNumb = new List<int>();
            while(number > 0)
            {
                binaryNumb.Add(number % 2);
                number /= 2;
            }
            binaryNumb.Reverse();
        }
        static int GetNumbFromBinary(List<int> binaryNumb)
        {
            int number = 0;
            int counter = 0;
            for (int i = binaryNumb.Count - 1; i >= 0; i--)
            {
                if (binaryNumb[i] == 1)
                {
                    number += (int)Math.Pow(2, counter);
                }
                counter++;
            }
            return number;
        }
        static List<int> DoOffsets(List<int> binaryNumb)
        {
            List<int> result = new List<int>();
            result.AddRange(binaryNumb);
            for(int i = 0; i < binaryNumb.Count; i++)
            {
                int firstBit = binaryNumb.First();
                binaryNumb.RemoveAt(0);
                binaryNumb.Add(firstBit);
                if (GetNumbInDecimal(binaryNumb) > GetNumbInDecimal(result))
                {
                    result.Clear();
                    result.AddRange(binaryNumb);
                }
            }
            return result;
        }
        static int GetNumbInDecimal(List<int> binaryNumb)
        {
            return Convert.ToInt32(string.Join("", binaryNumb.ToArray()));
        }
    }
}
