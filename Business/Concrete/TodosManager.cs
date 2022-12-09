using Business.Abstract;
using Business.Constants;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Business.Concrete
{
    public class TodosManager : ITodosService
    {
        ITodosDal _todosDal;
        public TodosManager(ITodosDal todosDal)
        {
            _todosDal = todosDal;
        }

        public IResult Add(Todos todos)
        {
            _todosDal.Add(todos);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(Todos todos)
        {
            _todosDal.Delete(todos);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Todos>> GetAll()
        {
            return new SuccessDataResult<List<Todos>>(_todosDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Todos> GetById(int id)
        {
            return new SuccessDataResult<Todos>(_todosDal.GetById(id), Messages.Listed);
        }
    }
}
