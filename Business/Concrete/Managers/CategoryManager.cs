using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public Category Add(Category entity)
        {
            return categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            categoryDal.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return categoryDal.Get(filter);
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return categoryDal.GetList(filter);
        }

        public Category Update(Category entity)
        {
            return categoryDal.Update(entity);
        }
    }
}
