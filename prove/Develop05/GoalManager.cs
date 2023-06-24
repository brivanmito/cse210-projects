using System.Text.Json;
public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;
    public GoalManager()
    {
        _goals = new List<Goal>();
    }
    public void RecordEvent(int posGoal)
    {
        if(_goals.Count > 0)
        {
            _goals[posGoal - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("You cannot record an event because you have not entered _goals. \nWe recommend that you enter at least 1.");
        }
    }
    public void ShowGoals()
    {
        int cont = 1;
        Console.WriteLine("The _goals are: ");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{cont}. ");
            goal.DisplayGoal();
            cont++;
        }
        Console.Write("Press Enter to continue... ");
        Console.ReadKey();
    }
    public void ShowNameGoals()
    {
        int cont = 1;
        Console.WriteLine("The _goals are: ");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{cont}. ");
            Console.WriteLine(goal.GetNameGoal());
            cont++;
        }
    }
    public void ShowScore()
    {
        _totalPoints = 0;
        foreach(Goal goal in _goals)
        {
            _totalPoints += goal.GetEarnedPoints();
        }
        Console.WriteLine($"You have {_totalPoints} points");
    }
    public void SaveGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void SaveGoalsInFile()
    {
        List<string> goals = new List<string>();
        foreach(Goal goal in _goals)
        {
            goals.Add(GetStringRepresentation(goal));
        }
        // Ya esta la parte de obtener los string
        foreach(string goal in goals)
        {
            Console.WriteLine(goal);
        }
        //Queda pendiente la parte del guardado en un archivo de texto
    }
    public void LoadGoalsFromFile()
    {

    }
    public string GetStringRepresentation(Goal objectGoal)
    {
        string typeObject = objectGoal.GetType().ToString();

        string nameGoal = objectGoal.GetNameGoal();
        string descriptionGoal = objectGoal.GetDescriptionGoal();
        int pointsPerGoal = objectGoal.GetPointsPerGoal();
        int pointsEarneds = objectGoal.GetEarnedPoints();

        string infoObject = "";

        switch(typeObject)
        {
            case "SimpleGoal":
                string check = objectGoal.GetChecked().ToString();
                infoObject = $"{typeObject}, {nameGoal} {descriptionGoal}, {pointsPerGoal}, {pointsEarneds}, {check}";
                break;
            case "EternalGoal":
                infoObject = $"{typeObject}, {nameGoal} {descriptionGoal}, {pointsPerGoal}, {pointsEarneds}";
                break;
            case "CheckListGoal":
                string bonusPoint = objectGoal.GetBonusPoints().ToString();
                string targetCount = objectGoal.GetTargetCount().ToString();
                string currentCount = objectGoal.GetCurrentCount().ToString();
                string completed = objectGoal.Completed().ToString();
                infoObject = $"{typeObject}, {nameGoal} {descriptionGoal}, {pointsPerGoal}, {pointsEarneds}, {bonusPoint}, {targetCount}, {currentCount}, {completed}";
                break;
        }
        return infoObject;
    }
}