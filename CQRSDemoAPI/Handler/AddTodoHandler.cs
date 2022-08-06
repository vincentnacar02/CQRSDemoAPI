using CQRSDemoAPI.Command;
using CQRSDemoAPI.Model;
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
        public Task<Todo> Handle(AddTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = new Todo
            {
                TaskId = 1111,
                TaskName = request.TaskName
            };
            return Task.FromResult(todo);
        }
    }
}
