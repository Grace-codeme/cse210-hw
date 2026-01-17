using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic Number?");
        int magicnumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int userguess = randomGenerator.Next(1, 101);

        int attempts = -1;

        while (attempts != magicnumber)

        {
            Console.Write("What is your guess?");
            attempts = int.Parse(Console.ReadLine());

            if (magicnumber < attempts)
            {
                Console.WriteLine("Lower");
            }
            else if (magicnumber > attempts)
            {
                Console.WriteLine("Higher");
            }
            else
            {  
                Console.WriteLine("You guessed it!");
            }
        }

    }
}

