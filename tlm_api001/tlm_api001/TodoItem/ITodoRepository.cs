using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tlm_api001.TodoItem
{
    public interface ITodoRepository
    {
        void Add(TodoItem item);
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(string key);
        TodoItem Remove(string key);
        void Update(TodoItem item);
    }
}