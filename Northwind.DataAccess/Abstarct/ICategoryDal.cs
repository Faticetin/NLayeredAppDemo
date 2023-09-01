using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstarct
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
