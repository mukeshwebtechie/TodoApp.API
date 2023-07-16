// TodosController.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.API.Models;
using TodoApp.API.Services;

namespace TodoApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _service;

        public TodosController(ITodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodoItems()
        {
            var todoItems = _service.GetTodoItems();
            return Ok(todoItems);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoItem(int id)
        {
            var todoItem = _service.GetTodoItem(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return Ok(todoItem);
        }

        [HttpPost]
        public ActionResult<TodoItem> AddTodoItem(TodoItem item)
        {
            _service.AddTodoItem(item);
            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodoItem(int id, TodoItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _service.UpdateTodoItem(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTodoItem(int id)
        {
            _service.DeleteTodoItem(id);
            return NoContent();
        }
    }
}
