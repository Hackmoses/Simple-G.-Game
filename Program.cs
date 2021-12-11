 using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a number guessing game with the following rules.
            // Easy, intermediate and hard levels
            // Player should choose what level they wanna play
            // Easy
            // Player should guess from 1 to 10
            // Player has got 6 trials
            // Intermediate
            // Player should guess from 1 to 20
            // Player has got 4 trials
            // Hard
            // Player should guess from 1 to 50
            // Player has got 3 trials
            try
            {
                Console.WriteLine("Select a level between easy, intermediate and hard..");
                Console.WriteLine("Select 1 for easy, 2 for intermediate and 3 for hard..");

                int getUserInput = int.Parse(Console.ReadLine());                

                if (getUserInput >= 1 && getUserInput <= 3)
                {
                    if (getUserInput == 1)
                    {
                        // Player should guess from 1 to 10
                        // Player has got 6 trials
                        PlayGame(6,1,10);
                    }
                    if (getUserInput == 2)
                    {
                        // Player should guess from 1 to 20
                        // Player has got 4 trials
                        PlayGame(4,1,20);
                    }
                    if (getUserInput == 3)
                    {
                        // Player should guess from 1 to 50
                        // Player has got 3 trials
                        PlayGame(3, 1, 50);
                    }
                }
                else
                {
                    Console.Write("Incorrect input, Please run game again and select right input");
                }  
            }
            catch (Exception ex)
            {
                 // TODO
                Console.WriteLine(ex.Message);
            }
        }

        public static void PlayGame(int trials, int minimumGuess, int maximumGuess)
        {
            Random random = new Random();
            int _trials = trials;
            int _guess, _guessFromUser;
            int _tried = 1;

            Console.WriteLine("Guess a number between " + minimumGuess + " and " + maximumGuess);
            Console.WriteLine("You have " + _trials + "trials");
                        
            while (true)
            {
                _guess = random.Next(minimumGuess, maximumGuess);
                _guessFromUser = int.Parse(Console.ReadLine());
                if (_guessFromUser == _guess)
                {
                    Console.WriteLine("Great, you got the guess correctly, The guess was " + _guess);
                    break;
                }
                if (_tried == _trials)
                {
                    Console.WriteLine("You've exhausted your trials, The guess was " + _guess);
                    break;
                }
                if (_tried != _trials)
                {
                    Console.WriteLine("Wrong guess, you have used up " + _tried + " guesses...");
                }
                _tried++;
            }
        }
    }
}
