using CQRSDemoAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ITodoRepository
    {
        public Task<Todo> AddTodo(Todo todo);
        public Task<List<Todo>> GetTodos();
    }
}
