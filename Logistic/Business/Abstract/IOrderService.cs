using Core.Entities.Utilities.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetDateList(DateTime yesterday);
        IDataResult<Order> GetUserName(string UserName);
        IDataResult<Order> GetGiris(string UserName, string Password);
        IDataResult<Order> GetSiparisTamala(long id);
        IDataResult<Order> GetByID(int UserID);
        IDataResult<Order> Add(Order user);
        IDataResult<Order> Update(Order user);
    }
}
