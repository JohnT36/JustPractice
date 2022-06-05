using System;

namespace JustPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {userName}!");

            Console.WriteLine("What is your favorite meal?");
            var userFood = Console.ReadLine();
            Console.WriteLine($"I've never liked {userFood}");

            Console.WriteLine("What is your favorite Sport?");
            var userSport = Console.ReadLine();
            Console.WriteLine($"Couldn't have picked a better sport than {userSport}?");
            Console.WriteLine($"LIKE SERIOUSLY?");

            Console.WriteLine($"Your name is {userName}, you try but arent that good at {userSport}.");
            Console.WriteLine($"I wonder why you even eat {userFood}");
            Console.WriteLine("What do you have to say for your self?!");

            var userResp = Console.ReadLine();
            Console.WriteLine(userResp);
            Console.WriteLine($"?{userResp}?!");
            Console.WriteLine("Goodnight, I can't handle you right now.");
            Console.WriteLine("P.S. I Love you.");





        }
    }

}

           
