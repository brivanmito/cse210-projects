public class Resume
    {
        //ATRIBUTES
        public string _name;
        public List<Job> _jobs = new List<Job>();

        //METHODS
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }