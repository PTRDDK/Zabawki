using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : IDive, IAccelerate
    {
        private int deep;
        private int acceleration;

        void IDive.setDive(int set)
        {
            this.deep = set;
        }

        int IDive.getDive()
        {
            return deep;
        }

        void IDive.Dive(int change)
        {
            this.deep = change;
        }

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
