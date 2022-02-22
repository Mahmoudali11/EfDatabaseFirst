using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Web;
using WebApplication1.DA;

namespace WebApplication1.BL
{
    public class Reposatory<TEntity> : IReposatory<TEntity> where TEntity : class
    {
             LearnEntities1 le;

             DbSet<TEntity> sete;
        public Reposatory(LearnEntities1 context)
        {
            le = context;
            sete = le.Set<TEntity>();


        }
         
        public TEntity Add(TEntity entity)
        {
           
                sete.Add(entity);
              return le.SaveChanges()>0? entity:null;

        }

        public bool Delete(TEntity entity)
        {

            sete.Remove(entity);
            return le.SaveChanges() > 0;

        }

        public IQueryable<TEntity> GetAll()
        {
            return sete;
        }

        public List<TEntity> GetAllBind()
        {
          return sete.ToList();
        }

        public TEntity GetById(params int[] id)
        {
             return  sete.Find(id);
        }

        public bool Update(TEntity entity)
        {
             sete.Attach(entity);

            le.Entry(entity).State=EntityState.Modified;
            return le.SaveChanges() > 0;
        }
    }
}