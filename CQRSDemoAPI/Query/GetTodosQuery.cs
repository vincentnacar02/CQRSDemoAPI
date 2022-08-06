﻿using CQRSDemoAPI.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Query
{
    public class GetTodosQuery : IRequest<List<Todo>>
    {
    }
}
