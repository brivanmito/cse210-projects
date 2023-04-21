using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string f_name = Console.ReadLine();
        Console.Write("What is your first name? ");
        string l_name = Console.ReadLine();
        
        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}");
    }
}