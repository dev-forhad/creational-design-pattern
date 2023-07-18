using CreationalPattern.Builder.ToyBuilder;
using System;
using static CreationalPattern.Builder.UserBuilder.User;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBuilder = new UserBuilder().WithName("forhad");

            Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
            ToyCreator toyCreator = new ToyCreator(new ToyABuilder());
            
            toyCreator.CreateToy();
            toyCreator.GetToy();
            
            
        }
    }
}
