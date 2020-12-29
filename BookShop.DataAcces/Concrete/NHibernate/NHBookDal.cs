using BookShop.DataAcces.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.NHibernate
{
    public class NHBookDal : IBookDal
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
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
            return new List<Book>()
            {
                new Book(){Id=1, Title="NH Öğreniyorum",UnitPrice=50},
                new Book(){Id=2, Title="NH ile Tasarım",UnitPrice=40},
                new Book(){Id=1, Title="NH Connection",UnitPrice=90}
            };
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
