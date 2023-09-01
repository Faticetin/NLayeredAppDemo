using Entities.Concrete;
using Northwind.Busines.Abstarct;
using Northwind.DataAccess.Abstarct;
using Northwind.DataAccess.Concrete.EntitiyFremwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Busines.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal; 

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        } 

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
