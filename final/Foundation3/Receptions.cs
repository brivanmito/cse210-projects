public class Receptions : Events
{
    private int _rsvp;
    public Receptions(string eventType, string eventTitle, string description, DateTime datetime, Address address) : base (eventType, eventTitle, description, datetime, address)
    {
        _rsvp = 0;
    }
    public void SetRsvp(int quantity)
    {
        _rsvp = quantity;
    }
    protected override string ShowFullDetails()
    {
        Console.WriteLine("-- Full Details --");
        return $"{base.StandardDetails()}\n{base.GetEventType()}\n{base.ShortDescription()}";
    }

}