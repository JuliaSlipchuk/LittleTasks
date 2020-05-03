using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_the_polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCoordinates;
            List<Tuple<int, int>> coordinates = new List<Tuple<int, int>>();
            do
            {
                Console.Write("Enter count of coordinates: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out countCoordinates) || countCoordinates < 3);
            string input;
            string[] array;
            int x, y;
            for(int i = 0; i < countCoordinates; i++)
            {
                Console.Write($"Enter {i + 1} coordinate of polygon (x y): ");
                input = Console.ReadLine();
                array = input.Split(' ');
                if (array.Length == 2 && Int32.TryParse(array[0], out x) && Int32.TryParse(array[1], out y))
                {
                    coordinates.Add(new Tuple<int, int>(x, y));
                }
                else
                {
                    Console.WriteLine("You entered invalid data, try again!");
                    i--;
                }
            }
            double area = CalculateArea(coordinates);
            Console.WriteLine($"Area of the {countCoordinates}-angle equal {area}");

            Console.ReadKey();
        }
        private static double CalculateArea(List<Tuple<int, int>> coordinates)
        {
            double area = 0;
            for (int i = 0; i < coordinates.Count; i++)
            {
                if (i != coordinates.Count - 1)
                {
                    area += coordinates[i].Item1 * coordinates[i + 1].Item2;
                    area -= coordinates[i].Item2 * coordinates[i + 1].Item1;
                }
                else
                {
                    area += coordinates[i].Item1 * coordinates[0].Item2;
                    area -= coordinates[i].Item2 * coordinates[0].Item1;
                }
            }
            area /= 2;
            return Math.Abs(area);
        }
    }
}
