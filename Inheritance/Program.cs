using System;
using System.Net.Cache;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var eagle = new Bird() {Name = "Bald Eagle", MaxAge = 20, Legs = 2, HasBackBone = true, MaxWingSpan = 7.5,
                CanFly = true, IsWarmBlooded = true, HasFeathers = true};
            Console.WriteLine($"The national animal for America is the {eagle.Name} which has a maximum life expectancy of {eagle.MaxAge} years." +
                $"\n It has {eagle.Legs} legs and a maximum wingpan of {eagle.MaxWingSpan}. " +
                $"\n True or false: Can the {eagle.Name} fly? {eagle.CanFly}. True or false: The {eagle.Name} warm blooded? {eagle.IsWarmBlooded}." +
                $"\n True or false: Does the {eagle.Name} have feathers? {eagle.HasFeathers}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile() {Name = "Komodo Dragon", MaxAge =30, Legs =4, HasBackBone = true, Environment= "Tropical Savanna Forest", 
                ExternalCovering= "Armoured Scales", IsColdBlooded=  true, Defense= "germs in saliva" };
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"The national animal for Indonesia is the {lizard.Name} which has a maximum life expectancy of {lizard.MaxAge} years." +
                $"\n It has {lizard.Legs} legs and lives in a {lizard.Environment} ecosystem. " +
                $"\n True or false: The {lizard.Name} has a backbone? {lizard.HasBackBone}. True or false : The {lizard.Name} cold blooded? {lizard.IsColdBlooded}." +
                $"\n For its defense the {lizard.Name} has {lizard.ExternalCovering} and has {lizard.Defense} that can be deadly to anything it bites.");
        }
    }
}
