using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITodosService
    {
        IDataResult<List<Todos>> GetAll();
        IDataResult<Todos> GetById(int id);
        IResult Add(Todos todos);
        IResult Delete(Todos todos);
    }
}
