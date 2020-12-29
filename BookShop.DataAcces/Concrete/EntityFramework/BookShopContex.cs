using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.EntityFramework
{
   public class BookShopContex: DbContext
    {
        public BookShopContex()
        {
            Database.SetInitializer<BookShopContex>(null);//2.kez veritabanı oluşumunu engeller.
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
