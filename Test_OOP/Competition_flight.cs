using System;
using System.Collections.Generic;
using System.Text;

namespace Test_OOP
{
    //answer 7
    internal class Competition_flight
    {
        public bool IsSame(IFly ifly,IFly ifly2)
        {
            return (ifly.distance(20, 40) == ifly2.distance(20, 40));
        }
    }
}
