using BookShop.DataAcces.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.EntityFramework
{
    public class EFAuthorDal : EFRepositoryBase<Author,BookShopContex>, IAuthorDal
    {
        public void Add(Author author)
        {
            using (var context = new BookShopContex())
            {
                context.Entry(author).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Author> GetAll()
        {
            using (var context = new BookShopContex())
            {
                return context.Author.ToList();
            }
        }

        public void Update(Author author)
        {
            using (var context = new BookShopContex())
            {
                context.Entry(author).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
