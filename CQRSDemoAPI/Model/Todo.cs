using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemoAPI.Model
{
    public class Todo
    {
        public Int32 TaskId { get; set; }
        public string TaskName { get; set; }
        public Boolean Completed { get; set; }
    }
}
