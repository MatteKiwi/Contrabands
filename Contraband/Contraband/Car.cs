using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public static Random gen;

        public bool Examine()
        {
            alreadyChecked = true;
            if (contrabandAmount != 0 && gen.Next(6) <= contrabandAmount)
            {
                return true;
            }
            return false;
        }
    }
}
