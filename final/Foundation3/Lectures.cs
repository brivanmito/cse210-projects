public class Lectures : Events
{
    private string _speakerName;
    private int _limitedCapacity;
    public Lectures(string eventType, string eventTitle, string description, DateTime datetime, Address address, string speaker, int capacity) : base (eventType, eventTitle, description, datetime, address)
    {
        _speakerName = speaker;
        _limitedCapacity = capacity;
    }
    protected override string ShowFullDetails()
    {
        return $"Speaker: {_speakerName}\nCapacity: {_limitedCapacity}";
    }
}