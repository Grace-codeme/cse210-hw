public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void Run()
    {
        int breatheInTime = 4;
        int breatheOutTime = 4;
        int cycles = _duration / (breatheInTime + breatheOutTime);
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown(breatheInTime);
            Console.WriteLine("Breathe out...");
            Countdown(breatheOutTime);
        }
    }
}

