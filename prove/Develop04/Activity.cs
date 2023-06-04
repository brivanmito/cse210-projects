public class Activity
{
    private string _nameActivity;
    private string _descriptionActivity;
    private int _durationActivity;
    private int _delaySeconds;
    private DateTime _startingActivity;

    public Activity(string name, string description, int delay)
    {
        _nameActivity = name;
        _descriptionActivity = description;
        _delaySeconds = delay;
    }

    protected void DisplayingStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameActivity}\n\n{_descriptionActivity}\n");
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        PauseSpinner();
        Console.WriteLine($"\nYou have completed another {_durationActivity} seconds of the {_nameActivity}");
    }
    protected void PauseCountDownTimer()
    {
        Console.Clear();
        for(int i = _delaySeconds; i > 0; i--)
        {
            Console.Write($"Get Ready! {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
        Console.WriteLine("\n");
    }
    protected void SetStartActivity()
    {
        _startingActivity = DateTime.Now;
    }
    protected DateTime GetStartActivity()
    {
        return _startingActivity;
    }
    protected void PauseSpinner()
    {
        List<string> caracthers = new List<string>()
        {
            "|","/","-","\\"
        };
        for(int i = 0; i < caracthers.Count(); i++)
        {
            Console.Write(caracthers[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    protected void SetDuration()
    {
        Console.Write("How long, in seconds, would you like fpr your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _durationActivity = seconds;
    }
    
    protected bool VerifyTime(DateTime start)
    {
        DateTime endTime = start.AddSeconds(_durationActivity);
        DateTime now = DateTime.Now;
        if(now > endTime)
        {
            return true;
        }
        return false;
    }
}