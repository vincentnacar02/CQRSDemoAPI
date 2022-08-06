using CQRSDemoAPI.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Command
{
    public class AddTodoCommand : IRequest<Todo>
    {
        public String TaskName { get; set; }
    }
}
