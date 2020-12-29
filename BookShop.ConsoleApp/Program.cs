using BookShop.Bussines.Concrete;
using BookShop.DataAcces.Concrete.EntityFramework;
using BookShop.DataAcces.Concrete.NHibernate;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var categoryManager = new CategoryManager(new EFCategoryDal());
            categoryManager.Add(new Category { Id = 1, CategoryName = "Novel" });
            categoryManager.GetAll().ForEach(x => Console.WriteLine(x));
            //var authorManager = new AuthorManager(new EFAuthorDal());
            //var author = new Author()
            //{
            //    Id=1 ,
            //    FirstName = "Zafer",
            //    LastName = "Aydın"
            //};
            //authorManager.Add(author);
            /*
            var bookManager = new BookManager(new EfBookDal());
            var book = new Book()
            {
                Id = 1,
                Title = "EF Öğreniyorum",
                UnitPrice = 50,
                Author = new Author() { Id = 1, FirstName = "Zafer", LastName = "Aydın" }
                

            };
            bookManager.Add(book);
           
            bookManager.GetAll().ForEach(b => Console.WriteLine(b));
            */


            Console.ReadLine();
        }

    }
}
