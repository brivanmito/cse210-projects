using System;
using System.Collections.Generic;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private string[] _prompts;
    private List<string> _usedPrompts = new List<string>();
    private List<string> _userList = new List<string>();

    private Stopwatch sw = new Stopwatch();
    private double lastFrame;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count())];
        _usedPrompts.Add(prompt);
        return prompt;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt: \n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");

    }
    public void RunActivity()
    {
        base.DisplayingStartingMessage();
        base.SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.ShowSpinner();
        DisplayPrompt();
        base.CountDown();
        base.SetStartActivity();
        GetEntries(base.GetDuration());
        base.DisplayEndingMessage();
    }
    // public double GetEntries(int durationInt)
    // {
    //     Stopwatch sw = new Stopwatch();
    //     sw.Start();
    //     dt = DeltaTime();
    //     double _durationMill = durationInt * 1000;
    //     double acc = 0.0;
    //     int total = 0;

    //     Console.Write(">");

    //     //start counting here
    //     while (acc <= _durationMill)
    //     {
    //         acc += base.DeltaTime();
    //         if (!Console.KeyAvailable)
    //         {
    //             continue;
    //         }

    //         ConsoleKeyInfo key = Console.ReadKey();
    //         if (key.Key == ConsoleKey.Enter)
    //         {
    //             total ++;

    //             Console.WriteLine("");
    //             Console.Write(">");
    //         }
    //         else
    //         {
    //             _userList.Add(key.KeyChar.ToString());
    //         }
        
    //     }

    //     Console.WriteLine();
    //     Console.WriteLine("Time's up!");
    //     Console.WriteLine($"You listed {total} items.");

    //     return acc;
    // }
    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }
    public void GetEntries(int duration)
    {
        this.sw.Start();
        double acc = 0.0;
        List<string> buf = new List<string>();
        Console.WriteLine("Go!");
        duration = duration * 1000;
        Console.Write("> ");
        while (acc <= duration)
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            
            if (key.Key == ConsoleKey.Enter)
            {
                
                Console.Write("\n> ");
                Console.Write("");
                _userList.Add("\n");
            }
            else
            {
                _userList.Add(key.KeyChar.ToString());
            }
        }
        this.sw.Reset();
        string userListStr = String.Join<string>("", _userList);
        string[] newUserList = userListStr.Split("\n");
        Console.WriteLine($"\nYou listed {newUserList.Count()} items.");
    }

}