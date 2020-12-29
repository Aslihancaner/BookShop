using BookShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Entities.Concrete
{
   public class Category: IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return $"{Id,-5}{CategoryName,15}";
        }
    }
}
