using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class CleanCar : Car
    {
        //metod cleancar som säger generar ett antal passangerare samt inget kontraband
        public CleanCar()
        {
            passengers = gen.Next(1, 4);
            contrabandAmount = 0;
        }
    }
}
