/*
 * Num_Guess: This program prompts user to guess a number between 1-100 and will track the amount of attempts it
 * takes to get the right answer
 * Name: Spencer Unitt
 * Module: Lab 6
 * Problem Statement: Create a number guessing game for the user.
 * 
 * Algorithm
 * 1. Create a new random object named rand and set an int to equal a random number between 1 and 100
 * 2. Create two ints. One will be used to compare to the random number and the other to keep track
 * 3. Prompt user to enter a number
 * 4. In a do while loop, set guess equal to the number the user inputs 
 * 5. If the guess is higher or lower than the random number, throw the user a hint of higher or lower
 * 6. If the guess is outside the scope of 1 - 100 throw an error message
 * 7. At the bottom of the loop, increment the tracker by 1
 * 8. When the corrent answer is guessed, exit the while loop and display the correct number and the amount of attempts it took
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the needed data members
            Random rand = new Random();
            int num = rand.Next(1, 100);
            int tracker = 0, guess;

            // Prompts user
            Console.WriteLine("Try to guess the random number from 1 to 100");
            
            // Starts off the loop 
            do
            {
                // Sets the guess to what the user inputs
                guess = int.Parse(Console.ReadLine());

                // throws a hint or error depending on the guess
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Invalid number, try again");
                    Console.ReadLine();
                }
                else if (guess < num)
                {
                    Console.WriteLine("To low, try higher");
                    
                }
                else if (guess > num)
                { 
                    Console.WriteLine("To high, try lower");
            
                }

                // increments the tracker by 1  each loop
                tracker++;
            }
            // runs until the correct answer is given
            while (guess != num);
            
            // displays the results to the user
            Console.WriteLine("You got it! The number was " + guess + "\nit took you " + tracker + " attempts." );
            Console.ReadLine();
        }
    }
}
