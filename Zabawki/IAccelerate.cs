using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IAccelerate
    {
        void setAccelerate(int set);
        int getAccelerate();
        void Accelerate(int change);
    }
}
