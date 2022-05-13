using Core.DataAccess;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityDal<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
