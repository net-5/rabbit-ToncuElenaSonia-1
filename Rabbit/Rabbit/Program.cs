using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        { 
            RabbitClass myRabbit = new RabbitClass(EyesType.Red,FurType.White,GenderType.Female, new DateTime(1989,10,20));
            Console.WriteLine("My rabbit looks like this:");
            Console.WriteLine(myRabbit.AboutRabbit);
            Console.WriteLine();
            myRabbit.MoveRabbit();
            Console.WriteLine();
            myRabbit.SleepRabbit();
            Console.WriteLine();
            myRabbit.EatRabbit();
        }
    }
}
