using Business.Abstract;
using Core.Entities.Utilities.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        public IDataResult<Order> Add(Order user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetByID(int UserID)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetGiris(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetKullaniciAdi(string KullaniciAdi)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetUserNameList(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> Update(Order user)
        {
            throw new NotImplementedException();
        }
    }
}
