using System;
using TodoApp;

namespace Program
{
    public class Program
    {
        public static bool running = true;
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
=======================================================
Todo App in C# (console version) written by Dan Collins
=======================================================

//Todo App
What would you like to do?
");

            App app = new App();
            Todo todo = new Todo();
            todo.Name = "Do the dishes";
            app.AddTodo(todo);
            app.PrintTodos();


            //while (running)
            //{
            //}
        }
    }
}