using System;
using System.Collections.Generic;
using System.Linq;

class Task
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Deadline { get; private set; }
    public List<string> Tags { get; private set; }

    public Task(string title, string description, DateTime deadline, List<string> tags)
    {
        Title = title;
        Description = description;
        Deadline = deadline;
        Tags = tags;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nDescription: {Description}\nDeadline: {Deadline:dd.MM.yyyy}\nTags: {string.Join(", ", Tags)}";
    }

    public bool HasTag(string tag)
    {
        return Tags.Contains(tag);
    }
}

class TodoList
{
    private List<Task> tasks;

    public TodoList()
    {
        tasks = new List<Task>();
    }

    public void AddTask()
    {
        Console.WriteLine("New task");
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Deadline (dd.MM.yyyy): ");
        DateTime deadline;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out deadline))
        {
            Console.WriteLine("Invalid date format. Please use dd.MM.yyyy.");
            Console.Write("Deadline (dd.MM.yyyy): ");
        }

        List<string> tags = new List<string>();
        Console.WriteLine("Tags (finish on empty line)");
        int tagNumber = 1;
        while (true)
        {
            Console.Write($"{tagNumber++}: ");
            string tag = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tag))
                break;
            tags.Add(tag);
        }

        tasks.Add(new Task(title, description, deadline, tags));
        Console.WriteLine("Task added successfully!");
    }

    public void SearchTasksByTag()
    {
        Console.Write("Search tasks by tag: ");
        string[] searchTags = Console.ReadLine().Split(' ');

        var result = tasks
            .Where(task => searchTags.All(tag => task.HasTag(tag)))
            .ToList();

        if (result.Any())
        {
            Console.WriteLine("Found tasks:");
            foreach (var task in result)
            {
                Console.WriteLine(task);
            }
        }
        else
        {
            Console.WriteLine("No such tasks");
        }
    }

    public void DisplayLastTasks()
    {
        Console.WriteLine("Actual tasks:");
        var sortedTasks = tasks.OrderBy(task => task.Deadline).ToList();
        foreach (var task in sortedTasks)
        {
            Console.WriteLine(task);
        }
    }
}

class Program
{
    static void Main()
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine("Enter the number of action and press [Enter]. Then follow instructions.");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Search task");
            Console.WriteLine("3. Last tasks");
            Console.WriteLine("4. Exit");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            switch (choice)
            {
                case 1:
                    todoList.AddTask();
                    break;
                case 2:
                    todoList.SearchTasksByTag();
                    break;
                case 3:
                    todoList.DisplayLastTasks();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
