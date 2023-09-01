using Entities.Concrete;
using Northwind.DataAccess.Concrete.EntitiyFremwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstarct
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
