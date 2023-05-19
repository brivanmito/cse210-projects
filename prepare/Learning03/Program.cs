using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        // In your Program.cs file, verify that you can call 
        // all of these methods and get the correct values, 
        // using setters to change the values and then getters 
        // to retrieve these new values and then display them to 
        // the console.
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
        // f1.SetTop(3);
        // f1.SetBottom(4);
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
        
        // CONSOLE
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Fraction f2 = new Fraction(6);

        // Fraction f3 = new Fraction(6, 7);

    }
}