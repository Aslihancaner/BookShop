using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Abstract
{
   public interface IAuthorDal
    {
        List<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
    }
}
