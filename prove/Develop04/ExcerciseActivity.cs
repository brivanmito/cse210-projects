public class ExcerciseActivity : Activity
{
    private List<string> _listExcercise = new List<string>();
    private List<string> _Listdescription = new List<string>();
    private int _randomPos;

    public ExcerciseActivity(string name, string description) : base(name, description)
    {
        _listExcercise = new List<string>
        {
            "Leg Raises",
            "Ankle Rotations",
            "Leg Extensions",
            "Neck Stretches",
            "Hand Openings and Closings"
        };
        _Listdescription = new List<string>
        {
            "Sit on a chair with your feet flat on the floor. Lift one leg straight up and then lower it back down slowly. Repeat the movement with the other leg. This helps strengthen the leg muscles.",
            "Sit with your feet flat on the floor. Rotate your ankles in a clockwise direction and then in a counterclockwise direction. This exercise helps improve ankle mobility and circulation.",
            "Sit on a chair with your feet flat on the floor. Then, extend one leg forward and lift it as high as possible without lifting the heel off the floor. Hold the position for a few seconds and then lower it back down. Repeat with the other leg. This exercise works the leg muscles and helps improve flexibility.",
            "Sit in an upright position. Tilt your head to one side, bringing your ear towards your shoulder, and hold the position for a few seconds. Then, repeat the stretch on the other side. You can also do gentle neck rotations to the right and left.",
            "Sit with your hands resting on your thighs. Open your hands as wide as possible and then close them tightly. Repeat this movement several times to work the hand muscles and improve circulation."
        };
        

    }
    public void ObtainPrompt()
    {
        Random rand = new Random();
        _randomPos = rand.Next(_listExcercise.Count());
    }
    public void RunActivity()
    {
        base.DisplayingStartingMessage();
        base.SetDuration();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.ShowSpinner();
        Console.WriteLine(_listExcercise[_randomPos] + "\n");
        Console.WriteLine(_Listdescription[_randomPos] + "\n");
        base.SetStartActivity();
        while (base.VerifyTime(base.GetStartActivity())) // loop until the time set by user has elapsed
        {
            base.CountDown(base.GetDuration());
        }
        base.DisplayEndingMessage();
    }
}