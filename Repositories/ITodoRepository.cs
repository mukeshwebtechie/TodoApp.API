// ITodoRepository.cs
using System.Collections.Generic;
using TodoApp.API.Models;

namespace TodoApp.API.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetTodoItems();
        TodoItem GetTodoItem(int id);
        void AddTodoItem(TodoItem item);
        void UpdateTodoItem(TodoItem item);
        void DeleteTodoItem(int id);
    }
}
