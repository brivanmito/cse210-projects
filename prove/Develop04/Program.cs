using System;

class Program
{
    static void Main(string[] args)
    {
        string nameActivity = "Breathing Activity";
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int delaySeconds = 5;
        BreathingActivity activity = new BreathingActivity(nameActivity, description, delaySeconds);
        activity.RunActivity();

        // string nameActivity = "Reflecting Activity";
        // string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        // int delaySeconds = 5;
        // ReflectingActivity activity = new ReflectingActivity(nameActivity, description, delaySeconds);
        // activity.RunActivity();
    }
}