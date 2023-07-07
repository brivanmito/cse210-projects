public abstract class Events
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    private string _aditionalInformation;
    public Events(string eventType, string eventTitle, string description, DateTime datetime, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _dateTime = datetime;
        _address = address;
    }
    protected string StandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_dateTime.Date}\nHour: {_dateTime.Hour}\nAddress: {_address}";
    }
    protected abstract string ShowFullDetails();
    protected string ShortDescription()
    {
        return $"{_eventType}\n{_eventTitle}\n{_dateTime.Date}";
    }
    protected string GetEventType()
    {
        return _eventType;
    }

}