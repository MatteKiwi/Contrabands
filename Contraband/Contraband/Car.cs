using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        //alla variabler för basklassen car, alla andra klasser ärver dessa
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public static Random gen;

        //en bool metod som kollar igenom bilarna och blir true ifall det finns kontraband annars blir den false
        public bool Examine()
        {
            alreadyChecked = true;
            if (contrabandAmount != 0 && gen.Next(6) <= contrabandAmount)
            {
                return true;
            }
            return false;
        }

        static Car()
        {
            gen = new Random();
        }

      
    }
}
