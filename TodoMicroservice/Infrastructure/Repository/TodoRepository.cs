using CQRSDemoAPI.Domain.Model;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TodoRepository : ITodoRepository
    {
        public Task<Todo> AddTodo(Todo todo)
        {
            // persist todo in DB here
            return Task.FromResult(todo);
        }

        public Task<List<Todo>> GetTodos()
        {
            // dummy
            var todos = new List<Todo>();
            todos.Add(new Todo
            {
                TaskId = 1,
                TaskName = "Task 1",
                Completed = false
            });
            todos.Add(new Todo
            {
                TaskId = 2,
                TaskName = "Task 2",
                Completed = false
            });
            return Task.FromResult(todos);
        }
    }
}
