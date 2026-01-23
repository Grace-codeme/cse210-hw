public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startDate;
    public string _endDate;

    public Job(string jobTitle, string company, string startDate, string endDate)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startDate = startDate;
        _endDate = endDate;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startDate}-{_endDate}");
    }
}

