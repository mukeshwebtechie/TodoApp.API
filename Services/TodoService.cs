// TodoService.cs
using System.Collections.Generic;
using TodoApp.API.Models;
using TodoApp.API.Repositories;

namespace TodoApp.API.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _repository.GetTodoItems();
        }

        public TodoItem GetTodoItem(int id)
        {
            return _repository.GetTodoItem(id);
        }

        public void AddTodoItem(TodoItem item)
        {
            _repository.AddTodoItem(item);
        }

        public void UpdateTodoItem(TodoItem item)
        {
            _repository.UpdateTodoItem(item);
        }

        public void DeleteTodoItem(int id)
        {
            _repository.DeleteTodoItem(id);
        }
    }
}
