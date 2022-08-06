using CQRSDemoAPI.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Core.Query
{
    public class GetTodosQuery : IRequest<List<Todo>>
    {
    }
}
