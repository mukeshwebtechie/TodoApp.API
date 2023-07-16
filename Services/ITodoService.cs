// ITodoService.cs
using System.Collections.Generic;
using TodoApp.API.Models;

namespace TodoApp.API.Services
{
    public interface ITodoService
    {
        IEnumerable<TodoItem> GetTodoItems();
        TodoItem GetTodoItem(int id);
        void AddTodoItem(TodoItem item);
        void UpdateTodoItem(TodoItem item);
        void DeleteTodoItem(int id);
    }
}
