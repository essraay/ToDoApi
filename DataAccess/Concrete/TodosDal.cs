using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TodosDal : EfEntityRepositoryBase<Todos, ToDoContext>, ITodosDal
    {
        public Todos GetById(int id)
        {
            using (ToDoContext context = new ToDoContext())
            {
                var query = context.Todos.Where(item => item.Id == id);
                return query.SingleOrDefault();
            }
        }
    }
}
