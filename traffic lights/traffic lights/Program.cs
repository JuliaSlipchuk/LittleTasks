using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traffic_lights
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, helper;
            int crossroads, tunnels;
            do
            {
                Console.Write("Enter count of crossroads: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < 2);
            crossroads = temp;
            do
            {
                Console.Write("Enter count of tunnels: ");
            }
            while (!Int32.TryParse(Console.ReadLine(), out temp) || temp < 1);
            tunnels = temp;
            List<string> connections = new List<string>();
            string connection;
            Console.WriteLine($"Enter all {tunnels} tunnels that connects two crossroads");
            string[] mass;
            for (int i = 0; i < tunnels; i++)
            {
                connection = Console.ReadLine();
                mass = connection.Split(' ');
                if (connections.Contains(connection) || mass.Length != 2 || !Int32.TryParse(mass[0], out temp) || !Int32.TryParse(mass[1], out helper) || temp < 1 || temp > crossroads || helper < 1 || helper > crossroads)
                {
                    i--;
                    Console.WriteLine("Somethind went wrong, try again");
                }
                else
                {
                    connections.Add(connection);
                }
            }

            List<int> countsLights;
            FillListByZeros(out countsLights, crossroads);
            for (int i = 0; i < connections.Count; i++)
            {
                temp = Convert.ToInt32(connections[i].Split(' ')[0]);
                helper = Convert.ToInt32(connections[i].Split(' ')[1]);
                countsLights[temp - 1]++;
                countsLights[helper - 1]++;
            }
            for (int i = 0; i < countsLights.Count; i++)
            {
                Console.WriteLine($"Crossroad {i + 1} has {countsLights[i]} traffic lights");
            }

            Console.ReadKey();
        }
        public static void FillListByZeros(out List<int> list, int count)
        {
            list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(0);
            }
        }
    }
}
