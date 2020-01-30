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

                }
            }


            Console.ReadLine();
        }
    }
}
