using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Countdown(3);
        Run();
        End();
    }

    protected abstract void Run();

    protected void End()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed the {_name} Activity for {_duration} seconds.");
        Countdown(3);
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Spinner(int seconds)
    {
        string[] spinner = new string[] { "|", "/", "-", "\\" };
        int index = 0;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write($"\r{spinner[index]}");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
