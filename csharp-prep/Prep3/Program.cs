using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random(); //for core requirement 3
        int magicNumber = randomGenerator.Next(1, 101); //for core requirement 3

        int guess = -1;
 
        while (guess != magicNumber) //For the computer picking the number.
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine("Thank you for playing the game.  Goodbye "); //Message for end of game.                   
    }
}

//keep_playing = 'yes' //this is for core requirement 2

//while keep_playing == 'yes': //(this is for core requirement 2 as long as they want to keep playing the game will run.
    
//print(f'It took {guess_count} guesses. ') // Stretch challenge 1.
        
//keep_playing = input('Would you like to play again (yes/no)? ') //Stretch challenge 2