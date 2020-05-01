using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumber first = new RomanNumber();
            RomanNumber second = new RomanNumber();

            Console.Write("Enter the first roman number: ");
            first.RomanNumberString = Console.ReadLine();
            first.GetRomanNumberChar();
            Console.Write("Enter the second roman number: ");
            second.RomanNumberString = Console.ReadLine();
            second.GetRomanNumberChar();

            Console.WriteLine("Result: " + RomanNumber.GetRomanSum(first, second));

            Console.ReadKey();
        }
    }
}
