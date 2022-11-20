using System;
using System.Collections.Generic;
using System.Text;

namespace Test_OOP
{
    //answer 7

    internal class Bird : Base_Animal,IFly
    {
        public bool CodeOnLeg { get; set; }
        public Bird(string name):base(name+"_Bird")
        {

        }
        public override string Eat()
        {
            return "Eats sperm once a day";
        }

        public override string Voice()
        {
            return "tzif tzif";
        }

        //answer 8
        public double distance()
        {
            return 40.2;
        }
       public bool distance(int a, int b)
        {
            return (a-b)<distance();
        }

       public string HowFly()
        {
            return "fly very good with the wings";
        }

        public override string ToString()
        {
            return base.ToString() + '\n' +
                "CodeonLeg: " + CodeOnLeg;
        }
    }
}
