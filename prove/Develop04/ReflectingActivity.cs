public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _usedQuestions = new List<int>();
    public ReflectingActivity(string name, string description, int delay) : base(name, description, delay)
    {
        _prompts = new List<string> 
        { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };
        _questions = new List<string> 
        { 
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?", 
            "What is your favorite thing about this experience?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?" 
        };
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        string question = _questions[rand.Next(_questions.Count)];
        return question;
    }
    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void RunActivity()
    {
        base.DisplayingStartingMessage();
        base.SetDuration();
        base.PauseCountDownTimer();
        DisplayPrompt();
        base.SetStartActivity();
        while (!base.VerifyTime(base.GetStartActivity())) // loop until the time set by user has elapsed
        {
            DisplayQuestions();
            
            base.PauseSpinner();
        }
        base.DisplayEndingMessage();
        base.PauseSpinner();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}