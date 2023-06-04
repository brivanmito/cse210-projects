public class BreathingActivity : Activity
{
    private List<string>_messages;
    public BreathingActivity(string name, string description, int delay) : base(name, description, delay)
    {
        _messages = new List<string>
        {
            "Breath In...",
            "Now Breath Out..."
        };
    }
    public void RunActivity()
    {
        base.DisplayingStartingMessage();
        base.SetDuration();
        base.PauseCountDownTimer();
        base.SetStartActivity();
        while (!base.VerifyTime(base.GetStartActivity())) // loop until the time set by user has elapsed
        {
            BreathIn();
            Console.WriteLine("");
            BreathOut();
            Console.WriteLine("\n");
        }
        base.DisplayEndingMessage();
        base.PauseSpinner();

    }
    private void BreathIn()
    {
        for (int i = 5; i > 0; i--) // loop to print a countdown to the terminal - 5 seconds
        {
            Console.Write($"{_messages[0]} {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces to clear the line then reprints in the same space
        }
    }
    private void BreathOut()
    {
        for (int i = 6; i > 0; i--) // loop to print a countdown to the terminal - 6 seconds
        {
            Console.Write($"{_messages[1]} {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // backspaces to clear the line then reprints in the same space
        }
    }
}