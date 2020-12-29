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
    public class EfBookDal : EFRepositoryBase<Book,BookShopContex>,
        IBookDal
    {
        public void Add(Book entity)
        {
            using (var context = new BookShopContex())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            using (var context= new BookShopContex())
            {
                return context.Books.ToList();
            }
        }

        public void Update(Book entity)
        {
            using (var context = new BookShopContex())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
