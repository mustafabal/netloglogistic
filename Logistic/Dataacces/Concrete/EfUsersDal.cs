using Core.DataAccess.Concrete;
using Dataacces.Abstract;
using Dataacces.Concrete.EntityFramework.Contexts;
using Entity.Concrete;

namespace Dataacces.Concrete
{
    public class EfUsersDal : EfEntityRepositoryBase<Users, DatabaseContext>, IUsersDal
    {

    }
}
