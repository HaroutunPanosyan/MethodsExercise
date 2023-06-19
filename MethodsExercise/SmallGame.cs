using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class SmallGame
    {
        public static void StartGameOptions()
        {
            Console.WriteLine("Start Game: " + 
                "\n" + "1. New Game" + 
                "\n" + "2. Quit Game");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                FirstSetOfChoices();
            }
            else
            {
                
            }
        }
        public static void FirstSetOfChoices()
        {
            Console.WriteLine("You find yourself in a dusty old town with sandblasted buildings strewn about almost haphazardly," +
                "\n" + "and many of the inhabitants are giving you the stink eye.");
            Console.WriteLine("\n" + "What do you do?" + "\n");
            Console.WriteLine("1. Intimidate them." + "\n" + 
                "2. Ignore Them." + "\n" + 
                "3. Pay closer attention to your surroundings.");

            Random rand = new Random();

            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int randomNumber = rand.Next(1, 11);
                    if (randomNumber > 8)
                    {
                        Console.WriteLine("You've successfully intimidated the crowd. They fizzle out and make way for" +
                            "you walk as you please." + "\n" + "Press any key to move on.");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("You come across a saloon with one door hanging loose from its top hinge." + "\n" +
                            "Do you enter?" + "\n" + "1. Yes. " + "\n" + "2. No.");
                        Case1SuccessChoices();
                    }
                    else
                        Console.WriteLine("You were unsuccessful in your attempt and have angered the mob." +
                            " They proceed to beating you until you've fully bled out." +
                            "\n" + "You are dead.");                    
                    break;
                case 2:
                    randomNumber = rand.Next(1, 11);
                    if (randomNumber > 4)
                    {
                        Console.WriteLine("You ignore the crowd. They still look at you a little strange" + 
                            "but do nothing to you as you walk down the dusty street." + "\n" + "Press any key to move on.");

                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("You come across a saloon with one door hanging loose from its top hinge." + "\n" +
                            "Do you enter?" + "\n" + "1. Yes. " + "\n" + "2. No.");
                        Case2SuccessChoices();
                    }
                    else
                    {
                        Console.WriteLine("You've successfully pissed off the crowd. They proceed to beating " +
                            "you until you've fully bled out." + "\n" + "You are dead.");
                    }
                    break;
                case 3:
                    randomNumber = rand.Next(1, 11);
                    if (randomNumber > 1)
                    {
                        Console.WriteLine("You noticed a snake creeping up on one of the townsfolk. " +
                            "You take out a knife and throw it at the snake. You've got amazing aim and " +
                            "hit the snake square in the face. It no longer moves, and the townsfolk are " +
                            "thoroughly impressed. The man you just saved thanks you profusely and mentions " +
                            "that he has a shop not to far from here. He'd be more than happy to give you a discount " +
                            "on all his wares.");

                        Case3SuccessChoices();
                    }
                    else
                    {
                        Console.WriteLine("You noticed a snake creeping up on one of the townsfolk. " +
                            "You take out a knife and throw it at the snake. But, unfortunately, your" +
                            "aim was completely wrong and you hit the thigh of the poor man. " +
                            "He winces from pain, falls to the floor and gets bit by the snake." +
                            "Seeing all this angered the townsfolk." + "\n" +
                            "They proceed to beating you until you've fully bled out.");
                    }
                    break;
            }
        }
        public static void Case1SuccessChoices()
        {
            int choice = Convert.ToInt16(Console.ReadLine());
            Random rand = new Random();
            switch (choice)
            {
                case 1:
                    int randomNumber = rand.Next(1, 11);
                    if (randomNumber > 8)
                    {
                        Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");                       
                    }
                    else
                    {
                        Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");
                    }
                    break;
                case 2:
                    randomNumber = rand.Next(1, 11);
                    if (randomNumber > 4)
                    {
                        Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");
                    }
                    else
                    {
                        Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");
                    }
                    break;
            }
        }
        public static void Case2SuccessChoices()
        {
            Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");
        }
        public static void Case3SuccessChoices()
        {
            Console.WriteLine("This text-based game will be updated throughout the course. This is all for now.");
        }
        public static void Case1aChoices()
        {

        }
        public static void Case1aSuccessChoices()
        {

        }
        public static void Case1bChoices()
        {

        }
        public static void Case1bSuccessChoices()
        {

        }
        public static void Case6SuccessChoices()
        {

        }
    }

   
}

