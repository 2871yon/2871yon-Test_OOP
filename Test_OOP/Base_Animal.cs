using System;
using System.Collections.Generic;
using System.Text;

namespace Test_OOP
{
    //answer 6
    internal abstract class Base_Animal
    {
        private static int idAllAnimal = 0;
        public readonly int id = 1515155;
        public string name { get; set; }
        public Base_Animal(string name)
        {
            id = ++idAllAnimal;
            this.name = name;
        }
        abstract public string Voice();

        abstract public string Eat();

        //answer 8
        public override string ToString()
        {
            return "id: " + id + " name: " + name + '\n' +
                "Eat: " + Eat() + '\n' + "voice: " + Voice();
        }
    }   
}
