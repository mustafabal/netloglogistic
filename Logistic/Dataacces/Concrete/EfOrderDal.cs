using Core.DataAccess.Concrete;
using Dataacces.Abstract;
using Dataacces.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacces.Concrete
{

    public class EfOrderDal : EfEntityRepositoryBase<Order, DatabaseContext>, IOrderDal
    {

    }
}
