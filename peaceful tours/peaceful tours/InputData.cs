using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peaceful_tours
{
    class InputData
    {
        public int WhiteTours { get; set; }
        public int BlackTours { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public void GetInputData()
        {
            int temp;
            do
            {
                Console.Write("Enter count of white tours: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < 1);
            this.WhiteTours = temp;
            do
            {
                Console.Write("Enter count of black tours: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < 1);
            this.BlackTours = temp;
            do
            {
                Console.Write("Enter board length: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < this.WhiteTours);
            this.Length = temp;
            do
            {
                Console.Write("Enter board width: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < BlackTours + 1);
            this.Width = temp;
        }
        public int GetResult()
        {
            int numberOptions;
            numberOptions = (Factorial(Length) / (Factorial(WhiteTours) * Factorial(Length - WhiteTours))) * Width * (Width - 1);
            if (BlackTours <= Length - WhiteTours)
            {
                numberOptions *= Factorial(Length - WhiteTours) / (Factorial(Length - WhiteTours - BlackTours) * Factorial(BlackTours));
            }
            return numberOptions;
        }
        public int Factorial(int numb)
        {
            int result = 1;
            for (int i = 2; i <= numb; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
