using CQRSDemoAPI.Command;
using CQRSDemoAPI.Core.Command;
using CQRSDemoAPI.Domain.Model;
using Domain.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Handler
{
    public class AddTodoHandler : IRequestHandler<AddTodoCommand, Todo>
    {
        private ITodoRepository _repository;
        public AddTodoHandler(ITodoRepository repository)
        {
            this._repository = repository;
        }

        public Task<Todo> Handle(AddTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = new Todo
            {
                TaskId = 1111,
                TaskName = request.TaskName
            };
            return _repository.AddTodo(todo);
        }
    }
}
