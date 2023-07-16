// TodoRepository.cs
using System.Collections.Generic;
using System.Linq;
using TodoApp.API.Data;
using TodoApp.API.Models;
using TodoApp.API.Repositories;

namespace TodoApp.API.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _context;

        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItem(int id)
        {
            return _context.TodoItems.Find(id);
        }

        public void AddTodoItem(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public void UpdateTodoItem(TodoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }

        public void DeleteTodoItem(int id)
        {
            var item = _context.TodoItems.Find(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
