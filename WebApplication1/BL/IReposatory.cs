using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace WebApplication1.BL
{
    public interface IReposatory<TEntity>
    {


        List<TEntity> GetAllBind();
        IQueryable<TEntity> GetAll();
        bool Update(TEntity entity);
        bool Delete(TEntity entity);


        TEntity Add(TEntity entity);
        TEntity GetById(params object[] id);


    }
}
