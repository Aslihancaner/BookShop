using BookShop.DataAcces.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcces.Concrete.EntityFramework
{
   public class EFCategoryDal: EFRepositoryBase<Category,BookShopContex>,
        ICategoryDal
    {

    }
}
