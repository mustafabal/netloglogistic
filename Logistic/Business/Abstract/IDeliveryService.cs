using Core.Entities.Utilities.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IDeliveryService
    {
        IDataResult<List<Delivery>> GetAll();
        IDataResult<List<Delivery>> GetUserNameList(string UserName);
        IDataResult<Delivery> GetUserName(string UserName);
        IDataResult<Delivery> GetGiris(string UserName, string Password);
        IDataResult<Delivery> GetKullaniciAdi(Users KullaniciAdi);
        IDataResult<Delivery> GetByID(int UserID);
        IDataResult<Delivery> Add(Delivery user);
        IDataResult<Delivery> Update(Delivery user);
    }
}
