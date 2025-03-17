// create new Job class

using System;

public class Job
{
    public string _company;
    public string _title;
    public int _startYear;
    public int _endYear;

    // method = display the job information
    public void JobDetails()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}
 
