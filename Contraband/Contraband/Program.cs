using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många bilar ska skapas?");
            int n = 0;
            while (n <= 1)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    continue;
                }
                Console.WriteLine("Icke sa micke! försök igen!!");
            }

            List<Car> cars = new List<Car>();
            Random rng = new Random();

            for (int i = 0; i < n; i++)
            {
                if(rng.Next(2) != 0)
                {
                    cars.Add(new ContrabandCar());
                }
                else
                {
                    cars.Add(new CleanCar());
                }
            }

           // Console.ReadLine();

            while (true)
            {
                int amount = cars.Count - 1;
                Console.WriteLine("Vilken bil vill du kolla på? [0 - " + amount + "]");

                int x = 0;
                while (x <= 1)
                {
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                    {
                        continue;
                    }
                    Console.WriteLine("Icke sa micke! försök igen!!");
                }

                if(!cars[x].alreadyChecked)
                {
                    Console.WriteLine("Kollar...");
                    if(!cars[x].Examine())
                    {
                        Console.WriteLine("Ingenting här!");
                    }
                    else
                    {
                        Console.WriteLine("Ah! Hittade: " + cars[x].contrabandAmount + " kontraband");
                    }

                }
                else
                {
                    Console.WriteLine("Redan vart här!");
                }
            }


            Console.ReadLine();
        }
    }
}
