using API.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
    }
}
