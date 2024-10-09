using System;
using System.Collections.Generic;

namespace TodoApp
{
    public class App
    {
        public List<Todo> todos = new List<Todo>();
        public void AddTodo(Todo todo) { todos.Add(todo); }
        public void RemoveTodo(Todo todo) { todos.Remove(todo); }
        public List<Todo> GetAllTodos() { return todos; }
        public void ClearTodos() { todos.Clear(); }
        public void PrintTodos()
        {
            foreach (Todo todo in todos)
            {
                Console.WriteLine(todo.Name);
            }
        }
    }
}
