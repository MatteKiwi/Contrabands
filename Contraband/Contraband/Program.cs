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
            Console.WriteLine("Hur många bilar ska skapas?"); //välkommnar spelaren
            int n = 0;
            while (n <= 1) //en enekel while loop som kollar ifall användaren har skrivit ett nummer och inte en bokstav, ifall användaren har skrivit ett nummer så går den vidare
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    continue;
                }
                Console.WriteLine("Icke sa micke! försök igen!!"); //felmeddelande
            }

            List<Car> cars = new List<Car>(); //lista för instanserna av car
            Random rng = new Random(); //en random gen

            for (int i = 0; i < n; i++) //en for loop som skapar antalet bilar som användaren gav som input sedan slumpas det fram kontraband bilar i det hela
            {
                if (rng.Next(2) != 0)
                {
                    cars.Add(new ContrabandCar());
                }
                else
                {
                    cars.Add(new CleanCar());
                }
            }

            while (true) //while loop med hela spelet
            {
                int amount = cars.Count - 1;
                Console.WriteLine("Vilken bil vill du kolla på? [0 - " + amount + "]");

                int x = 0;
                while (x <= 1)//en enekel while loop som kollar ifall användaren har skrivit ett nummer och inte en bokstav, ifall användaren har skrivit ett nummer så går den vidare
                {
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                    {
                        continue;
                    }
                    Console.WriteLine("Icke sa micke! försök igen!!");
                }

                //någonting som inte funkar med koden nedanför och jag är för dum för att komma på vad det är.
                if (!cars[x].alreadyChecked) //if sats som kollar ifall användaren redan har gått igenom en bil eller inte
                {
                    Console.WriteLine("Kollar...");
                    if (!cars[x].Examine())
                    {
                        Console.WriteLine("Ingenting här!");
                    }
                    else
                    {
                        Console.WriteLine("Ah! Hittade: " + cars[x].contrabandAmount + " kontraband");
                        break;
                    }

                }
                else //felmeddelande.
                {
                    Console.WriteLine("Redan vart här!");
                }
                
            }


            Console.ReadLine();
        }
    }
}
