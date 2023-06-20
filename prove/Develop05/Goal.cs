public abstract class Goal
{
    // Esta clase esta encargada de guardar la informacion de cada meta
    //
    private string _nameGoal;
    private string _descriptionGoal;
    private int _pointsPerGoal;
    private int _pointsEarneds;
    private List<string> _levels;

    public Goal(string name, string description, int points)
    {
        _nameGoal = name;
        _descriptionGoal = description;
        _pointsPerGoal = points;
        _levels = new List<string>{
            "Beginner", "Ninja", "Profesional", "Elite"
        };
    }
    
    // protected virtual void DisplayGoal()
    // {
    //     Console.WriteLine($"{_nameGoal} {_descriptionGoal}");
    // }
    public string GetNameGoal()
    {
        return _nameGoal;
    }
    protected string GetDescriptionGoal()
    {
        return _descriptionGoal;
    }
    protected void SetPoints()
    {
        _pointsEarneds += _pointsPerGoal;
    }
    protected void SetBonusPoints(int points)
    {
        _pointsEarneds += points;
    }
    public int GetEarnedPoints()
    {
        return _pointsEarneds;
    }
    protected int GetPointsPerGoal()
    {
        return _pointsPerGoal;
    }
    public abstract void DisplayGoal();
    public abstract void RecordEvent();
    protected virtual void IsComplete()
    {

    }

}