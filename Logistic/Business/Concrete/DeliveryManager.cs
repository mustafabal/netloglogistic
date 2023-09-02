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
    public class DeliveryManager : IDeliveryService
    {
        private IDeliveryDal _FileDetailsDal;
        public DeliveryManager(IDeliveryDal fileDetailsDal)
        {
            _FileDetailsDal = fileDetailsDal;
        }

        public IDataResult<Delivery> Add(Delivery aboutUs)
        {
            _FileDetailsDal.Add(aboutUs);
            return new SuccesDataResult<Delivery>(aboutUs);
        }

        public IDataResult<List<Delivery>> GetAll()
        {
            return new SuccesDataResult<List<Delivery>>(_FileDetailsDal.GetList());
        }

        public IDataResult<Delivery> Update(Delivery aboutUs)
        {
            _FileDetailsDal.Update(aboutUs);
            return new SuccesDataResult<Delivery>(aboutUs);
        }
        public IDataResult<Delivery> Delete(Delivery aboutUs)
        {
            _FileDetailsDal.Delete(aboutUs);
            return new SuccesDataResult<Delivery>(aboutUs);
        }

        public IDataResult<List<Delivery>> GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Delivery> GetGiris(Users UserName, string Password)
        {
            return new SuccesDataResult<Delivery>(_FileDetailsDal.Get(p => p.TeslimEdenKisi == UserName && p.Plaka == Password));
        }

        public IDataResult<Delivery> GetKullaniciAdi(Users KullaniciAdi)
        {
            return new SuccesDataResult<Delivery>(_FileDetailsDal.Get(p => p.TeslimEdenKisi == KullaniciAdi));
        }

        public IDataResult<Delivery> GetByID(int UserID)
        {
            return new SuccesDataResult<Delivery>(_FileDetailsDal.Get(p => p.Id == UserID));
        }

        public IDataResult<List<Delivery>> GetUserNameList(string UserName)
        {
            return new SuccesDataResult<List<Delivery>>(_FileDetailsDal.GetList(p => p.Plaka.Contains(UserName)));
        }

        IDataResult<Delivery> IDeliveryService.GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Delivery> GetGiris(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

  
    }
}
