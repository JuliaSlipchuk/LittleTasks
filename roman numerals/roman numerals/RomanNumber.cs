using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_numerals
{
    class RomanNumber
    {
        private static Dictionary<char, int> allowCharacters;
        public string RomanNumberString { get; set; }
        public List<char> RomanNumberChar { get; set; }
        List<int> ArabNumbers = new List<int>();
        static RomanNumber()
        {
            FillAllowCharacters();
        }

        static void FillAllowCharacters()
        {
            allowCharacters = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        }
        public void GetRomanNumberChar()
        {
            this.RomanNumberChar = this.RomanNumberString.ToCharArray().ToList();
        }
        public int GetArabNumber()
        {
            int number = 0;
            for (int i = 0; i < this.RomanNumberChar.Count; i++)
            {
                if (allowCharacters.ContainsKey(RomanNumberChar[i]))
                {
                    ArabNumbers.Add(allowCharacters[RomanNumberChar[i]]);
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            for (int i = 0; i < ArabNumbers.Count; i++)
            {
                if (i != 0 && ArabNumbers[i] > ArabNumbers[i - 1])
                {
                    number += ArabNumbers[i] - ArabNumbers[i - 1];
                }
                else if (i == 0 && ArabNumbers.Count > 1 && ArabNumbers[i] < ArabNumbers[i + 1])
                {
                    continue;
                }
                else
                {
                    number += ArabNumbers[i];
                }
            }
            return number;
        }
        public static int GetArabSum(int first, int second)
        {
            return first + second;
        }
        public static string GetRomanSum(RomanNumber first, RomanNumber second)
        {
            string result = "";
            int firstArab = first.GetArabNumber();
            int secondArab = second.GetArabNumber();
            int arabNumb = GetArabSum(firstArab, secondArab);
            result = ToRoman(arabNumb);
            return result;
        }
        public static string ToRoman(int number)
        {
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}
