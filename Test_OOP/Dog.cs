using System;
using System.Collections.Generic;
using System.Text;

namespace Test_OOP
{
    //answer 6
    internal class Dog : Base_Animal
    {
        public bool curb { get; set; }
        public Dog(string name) : base(name + "_dog")
        {
        }
        public override string Eat()
        {
            return "eat Regular or dried food twice a day from plate";
        }
        public override string Voice()
        {
            return "hwo hwo";
        }

        //answer 8
        public override string ToString()
        {
            return base.ToString() +'\n' +
                "curb: " + curb;
        }


    }
}
