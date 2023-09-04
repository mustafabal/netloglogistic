using Business.Abstract;
using Core.Entities.Utilities.Result;
using Dataacces.Abstract;
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
        private IOrderDal _FileDetailsDal;
        public OrderManager(IOrderDal fileDetailsDal)
        {
            _FileDetailsDal = fileDetailsDal;
        }
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

        public IDataResult<Order> GetSiparisTamala(long id)
        {
            return new SuccesDataResult<Order>(_FileDetailsDal.Get(p => p.Id > id && p.status==0));

        }

        public IDataResult<Order> GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetDateList(DateTime yesterday)
        {
            return new SuccesDataResult<List<Order>>(_FileDetailsDal.GetList(p=>p.Tarih>yesterday));
        }

        public IDataResult<Order> Update(Order user)
        {
            throw new NotImplementedException();
        }
    }
}
