public class GoalManager
{
    private List<Goal> goals;
    private int _totalPoints;
    public GoalManager()
    {
        goals = new List<Goal>();
    }
    public void RecordEvent(int posGoal)
    {
        goals[posGoal - 1].RecordEvent();
    }
    public void ShowGoals()
    {
        int cont = 1;
        Console.WriteLine("The goals are: ");
        foreach(Goal goal in goals)
        {
            Console.Write($"{cont}. ");
            goal.DisplayGoal();
            cont++;
        }
    }
    public void ShowNameGoals()
    {
        int cont = 1;
        Console.WriteLine("The goals are: ");
        foreach(Goal goal in goals)
        {
            Console.Write($"{cont}. ");
            Console.WriteLine(goal.GetNameGoal());
            cont++;
        }
    }
    public void ShowScore()
    {
        _totalPoints = 0;
        foreach(Goal goal in goals)
        {
            _totalPoints += goal.GetEarnedPoints();
        }
        Console.WriteLine($"You have {_totalPoints} points");
    }
    public void SaveGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void SaveGoalsInFile()
    {

    }
    public void LoadGoalsFromFile()
    {

    }
}