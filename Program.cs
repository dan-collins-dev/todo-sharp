using System;
using TodoApp;

namespace Program
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the beginning of my TodoApp written in C#!");
            Console.WriteLine();

            Todo todo1 = new Todo { Name = "Take out trash", Description = "The trash needs to be taken out now!" };
            todo1.Print();
        }
    }
}