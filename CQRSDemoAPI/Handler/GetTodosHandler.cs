using CQRSDemoAPI.Model;
using CQRSDemoAPI.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Handler
{
    public class GetTodosHandler : IRequestHandler<GetTodosQuery, List<Todo>>
    {
        public Task<List<Todo>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
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
