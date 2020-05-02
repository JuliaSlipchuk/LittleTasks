using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garland
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            do
            {
                Console.Write("Enter seconds: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out seconds) || seconds < 1);

            if (seconds == 1)
            {
                Console.WriteLine("One light is on");
            }
            else
            {
                List<bool> glowLightBulbs;
                FillList(out glowLightBulbs, seconds);
                for (int i = 1; i < seconds; i++)
                {
                    for (int j = 0; j < glowLightBulbs.Count; j++)
                    {
                        if (!glowLightBulbs[j])
                        {
                            continue;
                        }
                        else if (glowLightBulbs[j] && j != 0 && j != glowLightBulbs.Count - 1)
                        {
                            glowLightBulbs[j - 1] = true;
                            glowLightBulbs[j + 1] = true;
                        }
                        else if (glowLightBulbs[j] && j == 0)
                        {
                            glowLightBulbs[j + 1] = true;
                        }
                        else
                        {
                            glowLightBulbs[j - 1] = true;
                        }
                        glowLightBulbs[j] = false;
                        j++;
                    }
                }
                int count = glowLightBulbs.Where(l => l == true).Count();
                Console.WriteLine($"{count} light bulbs are lit!");
            }

            Console.ReadKey();
        }
        private static void FillList(out List<bool> list, int second)
        {
            list = new List<bool>();
            list.Add(true);
            for (int i = 1; i < second; i++)
            {
                list.Add(false);
            }
        }
    }
}
