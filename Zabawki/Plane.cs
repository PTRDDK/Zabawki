using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IAccelerate, IRise
    {
        private int acceleration;
        private int height;

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

        void IRise.setRise(int set)
        {
            this.height = set;
        }

        int IRise.getRise()
        {
            return height;
        }

        void IRise.Rise(int change)
        {
            this.height = change;
        }
    }
}
