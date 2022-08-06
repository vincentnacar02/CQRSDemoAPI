using CQRSDemoAPI.Core.Query;
using CQRSDemoAPI.Domain.Model;
using Domain.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Core.Handler
{
    public class GetTodosHandler : IRequestHandler<GetTodosQuery, List<Todo>>
    {
        private ITodoRepository _repository;
        public GetTodosHandler(ITodoRepository repository)
        {
            this._repository = repository;
        }

        public Task<List<Todo>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetTodos();
        }
    }
}
