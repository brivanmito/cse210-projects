public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        base.SetPoints();
        Console.WriteLine($"Congratulations! You have earned {base.GetPointsPerGoal()}");
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {base.GetNameGoal()} ({base.GetDescriptionGoal()})");
    }
}