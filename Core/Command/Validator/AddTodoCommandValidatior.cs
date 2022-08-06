using CQRSDemoAPI.Core.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Command.Validator
{
    public class AddTodoCommandValidatior : AbstractValidator<AddTodoCommand>
    {
        public AddTodoCommandValidatior()
        {
            RuleFor(t => t.TaskName).NotEmpty();
        }
    }
}
