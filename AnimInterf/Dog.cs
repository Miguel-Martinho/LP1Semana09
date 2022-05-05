using System;

namespace AnimInterf
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples {get {return 6;}}
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }

    }
}
