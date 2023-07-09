public class OutdoorGatherings : Events
{
    protected string weather;
    public OutdoorGatherings(string eventType, string eventTitle, string description, DateTime datetime, Address address) : base (eventType, eventTitle, description, datetime, address)
    {

    }
    protected override string ShowFullDetails()
    {
        return "";
    }
}