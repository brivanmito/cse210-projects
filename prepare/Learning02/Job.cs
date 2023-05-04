public class Job
    {
        //Responsibilities: Keeps track of the company, job title, start year, and end year.

        //ATRIBUTES
        public string _company;
        public string _jobTitle;
        public string _startYear;
        public string _endYear;


        //METHODS
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }