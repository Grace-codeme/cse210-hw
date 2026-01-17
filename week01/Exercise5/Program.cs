using System;
using System.ComponentModel.DataAnnotations;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string UserName = PromptForUserName();
        int UserNum = PromptForUserNum();

        int squaredNum = SquareNum(UserNum);
        DisplayResult(UserName, squaredNum);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptForUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptForUserNum()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }
    static int SquareNum(int num)
    {
        int Square = num * num;
        return Square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}