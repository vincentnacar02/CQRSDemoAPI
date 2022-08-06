using CQRSDemoAPI.Command;
using CQRSDemoAPI.Model;
using CQRSDemoAPI.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            var query = new GetTodosQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] AddTodoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
