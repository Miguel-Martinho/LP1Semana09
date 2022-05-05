using System;

namespace AnimInterf
{
    public class Program
    {
        private static Animal[] animArray;
        private static int rngNum;
        private static Random rng;
        private static void Main(string[] args)
        {
            rng = new Random();
            animArray = new Animal[10];

            for (int i = 0; i < animArray.Length; i++)
            {
                rngNum = rng.Next(0,4);
                switch(rngNum)
                {
                    case (0):
                    animArray[i] = new Cat();
                    break;
                    case (1):
                    animArray[i] = new Dog();
                    break;
                    case (2):
                    animArray[i] = new Bat();
                    break;
                    case (3):
                    animArray[i] = new Bee();
                    break;
                }
            }

            foreach(Animal animal in animArray)
            {
                Console.WriteLine(animal.Sound());
                if(animal is IMammal)
                {
                    Console.WriteLine("Nipples: "+(animal as IMammal).NumberOfNipples);
                }
                if(animal is ICanFly)
                {
                     Console.WriteLine("Wings: " +(animal as ICanFly).NumberOfWings);
                }
            }
        }
    }
}
