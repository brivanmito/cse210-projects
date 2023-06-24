public class CheckListGoal : Goal
{
    private int _bonusPoint;
    private int _targetCount;
    private int _currentCount;
    private bool _completed;
    public CheckListGoal(string name, string description, int points, int bonusPoint, int targetCount) : base(name, description, points)
    {
        _bonusPoint = bonusPoint;
        _targetCount = targetCount;
        _currentCount = 0;
    }
    protected override void IsComplete()
    {
        if(_currentCount == _targetCount)
        {
            _completed = true;
            base.SetBonusPoints(_bonusPoint);
        }
        else if (_currentCount < _targetCount)
        {
             _completed = false;
        }
        else
        {
            Console.WriteLine("Goal Already Completed!");
        }
    }
    public override void DisplayGoal()
    {
        if(_completed == true)
        {
            Console.WriteLine($"[X] {base.GetNameGoal()} ({base.GetDescriptionGoal()}) -- Completed {_currentCount}/{_targetCount} times");
        }
        else
        {
            Console.WriteLine($"[ ] {base.GetNameGoal()} ({base.GetDescriptionGoal()}) -- Completed {_currentCount}/{_targetCount} times");
        }

    }
    public override void RecordEvent()
    {
        if(_completed != true)
        {
            _currentCount += 1;
            IsComplete();
            base.SetPoints();
            Console.WriteLine($"Congratulations! You have earned {base.GetPointsPerGoal()}");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_bonusPoint} bonus for completing the Goal");
        }
    }
    public override int GetBonusPoints()
    {
        return _bonusPoint;
    }
    public override int GetTargetCount()
    {
        return _targetCount;
    }
    public override int GetCurrentCount()
    {
        return _currentCount;
    }
    public override bool Completed()
    {
        return _completed;
    }
}