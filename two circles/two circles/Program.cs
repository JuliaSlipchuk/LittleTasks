using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle first = new Circle();
            Circle second = new Circle();

            first.GetInformAboutCircle();
            second.GetInformAboutCircle();

            Circle.GetNumberOfIntersectionPoints(first, second);

            Console.ReadKey();
        }
    }
}
