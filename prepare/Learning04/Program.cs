using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());

        Console.WriteLine("\n");

        MathAssigment assigmenntMath = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assigmenntMath.GetSummary());
        Console.WriteLine(assigmenntMath.GetHomeWorkList());

        Console.WriteLine("\n");

        WrittingAssigment assigmentWritting = new WrittingAssigment("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(assigmentWritting.GetSummary());
        Console.WriteLine(assigmentWritting.GetWritingInformation());
    }
}