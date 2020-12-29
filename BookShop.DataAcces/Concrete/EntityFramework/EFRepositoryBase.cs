using BookShop.DataAcces.Abstract;
using BookShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.EntityFramework
{
    public class EFRepositoryBase<Tentity, Tcontext> : 
        IEntityRepository<Tentity>
        where Tentity:class, IEntity,new()
        where Tcontext: DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(int id)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(x => x.Id == id);
            }
        }

        public List<Tentity> GetAll()
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
