using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_circles
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public void GetInformAboutCircle()
        {
            double x, y, r;
            Console.Write("Enter x coordinate: ");
            if (Double.TryParse(Console.ReadLine(), out x))
            {
                this.X = x;
            }
            else
            {
                this.X = 0;
            }
            Console.Write("Enter y coordinate: ");
            if (Double.TryParse(Console.ReadLine(), out y))
            {
                this.Y = y;
            }
            else
            {
                this.Y = 0;
            }
            Console.Write("Enter radius: ");
            if (Double.TryParse(Console.ReadLine(), out r) && r > 0.001)
            {
                this.Radius = r;
            }
            else
            {
                this.Radius = 1;
            }
        }
        public static void GetNumberOfIntersectionPoints(Circle first, Circle second)
        {
            if (first.X == second.X && first.Y == second.Y && first.Radius == second.Radius)
            {
                Console.WriteLine(-1);
            }
            else if (Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2)) == (first.Radius + second.Radius))
            {
                Console.WriteLine(1);
            }
            else if (Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2)) < (first.Radius + second.Radius))
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
