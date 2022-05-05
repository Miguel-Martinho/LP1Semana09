using System;

namespace AnimInterf
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfWings {get {return 2;}}
        public int NumberOfNipples {get {return 5;}}
        public override string Sound()
        {
            return base.Sound() + "hee";
        }
    }
}
