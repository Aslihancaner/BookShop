using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Bussines.Abstract
{
   public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
    }
}
