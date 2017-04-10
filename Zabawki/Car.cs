using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
        private int acceleration;

        void IAccelerate.setAccelerate(int set)
        {
            this.acceleration = set;
        }

        int IAccelerate.getAccelerate()
        {
            return acceleration;
        }

        void IAccelerate.Accelerate(int change)
        {
            this.acceleration = change;
        }
    }
}
