using System;

namespace TodoApp
{
    public class Todo
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public void Print()
        {
            Console.WriteLine($"Todo: {Name}");
            Console.WriteLine($"Desciption: {Description}\n");
        }
    }
}
