using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        int percentage = int.Parse(answer);
        string letter = "";

        if (percentage >= 90)
        {
            if (percentage < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        if (percentage >= 80)
        {
            if (percentage >= 87)
            {
                letter = "B+";
            }
            else if (percentage < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (percentage >= 70)
        {
            if (percentage >= 77)
            {
                letter = "C+";
            }
            else if (percentage < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (percentage >= 60)
        {
            if (percentage >= 67)
            {
                letter = "D+";
            }
            else if (percentage < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations!  You have a passing grade.");
        }
        else
        {
            Console.WriteLine("That is ok try harder and do better next time.");
        }    
    }
}