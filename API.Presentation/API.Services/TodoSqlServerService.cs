using API.DataAccess;
using API.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly MyDbContext _context = new MyDbContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
