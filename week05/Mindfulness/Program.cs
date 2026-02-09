using System;
using System.Threading;

// Begin Activity class
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {name} Activity!");
        Console.WriteLine(description);
        Console.Write("Enter duration (seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Countdown(3);
        Run();
        End();
    }

    protected abstract void Run();

    protected void End()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed the {name} Activity for {duration} seconds.");
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

// Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void Run()
    {
        int breatheInTime = 4;
        int breatheOutTime = 4;
        int cycles = duration / (breatheInTime + breatheOutTime);
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(breatheInTime);
            Console.WriteLine("Breathe out...");
            Countdown(breatheOutTime);
        }
    }
}

// Reflection Activity
public class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    protected override void Run()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        int startTime = Environment.TickCount;
        while ((Environment.TickCount - startTime) / 1000 < duration)
        {
            string question = questions[random.Next(questions.Length)];
            Console.WriteLine(question);
            Spinner(5);
        }
    }
}

// Listing Activity
public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void Run()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Countdown(5);
        Console.WriteLine("Start listing...");
        int startTime = Environment.TickCount;
        int count = 0;
        while ((Environment.TickCount - startTime) / 1000 < duration)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                count++;
            }
        }
        Console.WriteLine($"You listed {count} items.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
            activity.Start();
        }
    }
}

