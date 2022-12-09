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
    public class UserDal : EfEntityRepositoryBase<User, ToDoContext>, IUserDal
    {
        public User GetById(int id)
        {
            using (ToDoContext context = new ToDoContext())
            {
                var query = context.User;
                return query.SingleOrDefault();
            }
        }
    }
}
