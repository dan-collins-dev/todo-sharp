using System;

namespace TodoApp
{
    public class Todo
    {
        public string Name = "";
        public string Description = "";

        public void Print()
        {
            Console.WriteLine($"Todo: {Name}");
            Console.WriteLine($"Desciption: {Description}\n");
        }
    }
}
