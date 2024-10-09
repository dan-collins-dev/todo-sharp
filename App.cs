using System;
using System.Collections.Generic;

namespace TodoApp
{
    public class App
    {
        public List<Todo> todos = new List<Todo>();
        public bool running = false;
        public void AddTodo(Todo todo) { todos.Add(todo); }
        public void RemoveTodo(Todo todo) { todos.Remove(todo); }
        public List<Todo> GetAllTodos() { return todos; }
        public void ClearTodos() { todos.Clear(); }
        public void PrintTodos()
        {
            foreach (Todo todo in todos)
            {
                Console.WriteLine(todo.Name);
                Console.WriteLine(todo.Description);
            }
        }

        public void Init()
        {
            Console.WriteLine(@"
=======================================================
Todo App in C# (console version) written by Dan Collins
=======================================================

//Todo App
What would you like to do?
");

            Console.WriteLine("1. Manage Todos");
            Console.WriteLine("2. Quit Application");
            Console.Write("Choose your option (1 or 2): ");
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Quitting application");
            }
            else if (choice == "2")
            {
                Run();
            }
        }

        public void Run()
        {
            running = true;
            while (running)
            {
                DisplayMenu();
                Console.Write("Choose your option (1, 2, 3, 4, 5): ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        running = false; 
                        break;
                    
                    default:
                        break;
                }
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1. Create a Todo");
            Console.WriteLine("2. Update a Todo");
            Console.WriteLine("3. Remove a Todo");
            Console.WriteLine("4. List all Todos");
            Console.WriteLine("5. Quit Application");
        }

    }
}
