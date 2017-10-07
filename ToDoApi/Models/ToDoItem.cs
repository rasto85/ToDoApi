using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }
        public string Header { get; set; }
        public bool IsImportant { get; set; }
    }
}
