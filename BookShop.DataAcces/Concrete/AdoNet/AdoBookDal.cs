using BookShop.DataAcces.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.AdoNet
{
    public class AdoBookDal : IBookDal
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

        public List<Book> GetAll() // list<book> referance türlüdür.
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="AdoNet Öğreniyorum",UnitPrice=50},
                new Book(){Id=2, Title="AdoNet ile Tasarım",UnitPrice=40},
                new Book(){Id=1, Title="AdoNet Connection",UnitPrice=90}
            };
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
