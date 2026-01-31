using System;

public class Program
{
    public static void Main(string[] args)
    {
        var reference = new ScriptureReference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetReference()}: {scripture.GetDisplayText()}");
            Console.Write("Press Enter to continue, or type 'quit' to exit: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine($"{scripture.GetReference()}: {scripture.GetDisplayText()}");
                Console.WriteLine("Congratulations, you've memorized the scripture!");
                break;
            }
        }
    }
}

