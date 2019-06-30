using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Rabbit
{
    public enum EyesType
    {
        Blue,
        Red,
        Black
    }
    public enum FurType
    {
        White,
        Brown,
        Black,
        Grey
    }
    public enum GenderType
    {
        Male,
        Female
    }
    class RabbitClass
    {
        
        private int ageOfRabbit;
        public EyesType EyesRabbit { get; set; }
        public FurType FurOfRabbit { get; set; }
        public GenderType Gender { get; set; }
        public DateTime BirthdayRabbit { get; }
        public int AgeOfRabbit
        {
            get
            {
                ageOfRabbit = DateTime.Now.Year - BirthdayRabbit.Year;
                return ageOfRabbit;
            }     
        }
        public RabbitClass(EyesType eyesRabbit, FurType furOfRabbit, GenderType gender, DateTime birthdayRabbit )
        {
            EyesRabbit = eyesRabbit;
            FurOfRabbit = furOfRabbit;
            Gender = gender;
            BirthdayRabbit = birthdayRabbit;
        }
        //•	a rabbit can have Blue, Red or Black eyes
        //•	a rabbit's fur can be white, brown, black or grey
        //•	it has a gender
        //•	has a birth date, and based on that you should be able to see how old the rabbit is
        public string AboutRabbit
        {
            get
            {
                return $"My rabbit has {EyesRabbit} eyes, {FurOfRabbit} fur and {Gender} gender and it has {AgeOfRabbit} years";
            }
        }
        
        //•	we also know that a rabbit is a mammal that moves, sleeps and eats
        public void MoveRabbit()
        {
            Console.WriteLine($"My rabbit can move.");
        }
        public void SleepRabbit()
        {
            Console.WriteLine($"My rabbit can sleep.");
        }
        public void EatRabbit()
        {
            Console.WriteLine($"My rabbit likes to eat alot.");
        }
    }
}

