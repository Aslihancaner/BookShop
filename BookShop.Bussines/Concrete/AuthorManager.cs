using BookShop.Bussines.Abstract;
using BookShop.DataAcces.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Bussines.Concrete
{
  public class AuthorManager: IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }


        List<Author> IAuthorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
