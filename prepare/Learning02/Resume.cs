using System;

public class Resume
{
    public string _name;

    // initializing  list to a new List.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // using the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This code will call the Display method on each job
            job.Display();
        }
    }
}