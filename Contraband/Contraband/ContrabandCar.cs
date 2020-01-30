using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class ContrabandCar : Car
    {
      public ContrabandCar()
        {
            passengers = gen.Next(1, 3);
            contrabandAmount = gen.Next(1, 5);
        }
    }
}
