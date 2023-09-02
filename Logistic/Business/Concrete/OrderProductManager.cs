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
    public class OrderProductManager : IOrderProductService
    {
        public IDataResult<OrderProduct> Add(OrderProduct user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OrderProduct>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderProduct> GetByID(int UserID)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderProduct> GetGiris(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderProduct> GetKullaniciAdi(string KullaniciAdi)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderProduct> GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OrderProduct>> GetUserNameList(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<OrderProduct> Update(OrderProduct user)
        {
            throw new NotImplementedException();
        }
    }
}
