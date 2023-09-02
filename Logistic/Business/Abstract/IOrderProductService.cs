using Core.Entities.Utilities.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderProductService
    {
        IDataResult<List<OrderProduct>> GetAll();
        IDataResult<List<OrderProduct>> GetUserNameList(string UserName);
        IDataResult<OrderProduct> GetUserName(string UserName);
        IDataResult<OrderProduct> GetGiris(string UserName, string Password);
        IDataResult<OrderProduct> GetKullaniciAdi(string KullaniciAdi);
        IDataResult<OrderProduct> GetByID(int UserID);
        IDataResult<OrderProduct> Add(OrderProduct user);
        IDataResult<OrderProduct> Update(OrderProduct user);
    }
}
