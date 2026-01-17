using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers type 0 when finished.");

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            string userresponse = Console.ReadLine();
            number = int.Parse(userresponse);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;

        foreach (int num in numbers)

        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = ((float)sum) / (numbers.Count - 1);
        Console.WriteLine($"The average of the numbers is: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        
    }
    
}