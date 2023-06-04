public class ListingActivity : Activity
{
    private string[] _prompts;
    private List<string> _userList = new List<string>();
    public ListingActivity(string name, string description, int delay) : base(name, description, delay)
    {
        _prompts = new string[] {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count())];
        _userList.Add(prompt);
        return prompt;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

    }
    public void InsertItem()
    {
        DisplayPrompt();
        string item = Console.ReadLine();

    }
    public void RunActivity()
    {
        
    }

}