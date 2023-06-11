using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        bool bucle = true;

        string nameActivity = "";
        string descriptionActivity = "";

        while(bucle)
        {
            Console.Clear();
            Console.WriteLine("Mindfullness Program");
            Console.WriteLine("Menu Options");
            Console.WriteLine("\n    1.- Start Breathing Activity");
            Console.WriteLine("    2.- Start Reflection Activity");
            Console.WriteLine("    3.- Start Listing Activity");
            Console.WriteLine("    4.- Quit\n");

            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    nameActivity = "Breathing Activity";
                    descriptionActivity = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathingActivity = new BreathingActivity(nameActivity, descriptionActivity);
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    nameActivity = "Reflecting Activity";
                    descriptionActivity = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflectingActivity = new ReflectingActivity(nameActivity, descriptionActivity);
                    reflectingActivity.RunActivity();
                    break;
                case 3:
                    nameActivity = "Listing Activity";
                    descriptionActivity = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity listingActivity = new ListingActivity(nameActivity, descriptionActivity);
                    listingActivity.RunActivity();
                    break;
                case 4:
                    bucle = false;
                    break;
                default:
                    Console.WriteLine("Error! The option do not exist");
                    Console.ReadKey();
                    break;

            }

        }
    }
}
// using System;
// using System.Diagnostics;
// class Demo
// {
//     private Stopwatch sw = new Stopwatch();
//     private double lastFrame;
//     private double deltaTime()
//     {
//         TimeSpan ts = this.sw.Elapsed;
//         double firstFrame = ts.TotalMilliseconds;
//         double dt = firstFrame - lastFrame;
//         this.lastFrame = ts.TotalMilliseconds;
//         return dt;
//     }
//     public void run()
//     {
//         this.sw.Start();
//         double acc = 0.0;
//         List<string> buf = new List<string>();
//         Console.WriteLine("Go!");
//         while (acc <= 10000)
//         {
//             acc += this.deltaTime();
//             if (!Console.KeyAvailable)
//             {
//                 continue;
//             }
//             ConsoleKeyInfo key = Console.ReadKey();
//             if (key.Key == ConsoleKey.Enter)
//             {
//                 Console.WriteLine("");
//                 buf.Add("\n");
//             }
//             else
//             {
//                 buf.Add(key.KeyChar.ToString());
//             }
//         }
//         this.sw.Reset();
//         Console.WriteLine("\nTime's up!");
//         string bufStr = String.Join<string>("", buf);
//         Console.WriteLine($"Here's what you typed: {bufStr}");
//     }
// }

// static class Program
// {
//     static void Main(string[] args)
//     {
//         Demo demo = new Demo();
//         demo.run();
//     }
// }
