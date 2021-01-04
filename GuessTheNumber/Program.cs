using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to guess the number. Please enter a guess between 1-100");

            bool correct = false;
            Random rng = new Random();
            int random_num = rng.Next(1, 101);
            int num_attempts = 0;

            for(;;)
            {
                num_attempts++;
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());
                
                if(guess == random_num)
                {
                    Console.WriteLine("Correct Answer! It took only " + num_attempts +" attempts. Good job :)");
                    break;
                }
                else if(guess > random_num)
                {
                    Console.WriteLine("Your guess was too big. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess was too small. Try again!");
                }

            }
        }
    }
}
