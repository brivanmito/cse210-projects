using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Type yor grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letterScore = "";

        // Core Requirements
        

        if (gradePercentage >= 90)
        {
            letterScore = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterScore = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterScore = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterScore = "D";
        }
        else
        {
            letterScore = "F";
        }

        int remainder = gradePercentage % 10;

        // For each grade, you'll know it is a "+" if 
        // the last digit is >= 7. You'll know it is a 
        // minus if the last digit is < 3 and otherwise
        // it has no sign.

        if (!(letterScore == "A" || letterScore == "F"))
        {
            if (remainder >= 7)
            {
                letterScore = letterScore + "+";
            }
            else if (remainder < 3)
            {
                letterScore = letterScore + "-";
            }
        }
        // Printing the Letter Score
        Console.WriteLine($"Your grade is {letterScore}");

        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations! You pass to the next term.");
        }
        else
        {
            Console.WriteLine("Your score is not enough. Try Again the next time");
        }

    }
}