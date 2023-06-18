using System;

namespace MethodsExercise
{
    public class ShortStory
    {
        public static void TheGame()
        {
            string username;
            string color;
            string animal;
            string band;

            Console.WriteLine("Enter Username: ");
            username = Console.ReadLine();

            Console.WriteLine("Enter Favorite Color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter Favorite Animal: ");
            animal = Console.ReadLine();

            Console.WriteLine("Enter Favorite Band: ");
            band = Console.ReadLine();

            Console.WriteLine($"{username} will start with {color} eyes and a(n) {animal} pet." +
                "\n" + $"The music that will be playing in the background will be related to {band}.");
        }
    }
}
