using System;

namespace Test_OOP
{
    internal class Program
    {

      
        static void Main(string[] args)
        {            
            
            //answer 7
            IFly ifBird = new Bird("tzivi");

            Dog d = new Dog("foogi");
            d.curb = true;
            Base_Animal baseDog = new Dog("pitzi");

            //answer 9
            Base_Animal[] ba= new Base_Animal[10];
            ba[0] = d;
            ba[1] = (Bird)ifBird;
            ba[2] = baseDog;

            for (int i = 0; i < ba.Length; i++)
            {
                Console.WriteLine(i+" : "+d.ToString()+'\n');
            }
        }
    }
}
