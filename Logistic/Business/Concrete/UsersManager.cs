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
    public class UsersManager : IUsersService
    {
        private IUsersDal _FileDetailsDal;
        public UsersManager(IUsersDal fileDetailsDal)
        {
            _FileDetailsDal = fileDetailsDal;
        }

        public IDataResult<Users> Add(Users aboutUs)
        {
            _FileDetailsDal.Add(aboutUs);
            return new SuccesDataResult<Users>(aboutUs);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccesDataResult<List<Users>>(_FileDetailsDal.GetList());
        }

        public IDataResult<Users> Update(Users aboutUs)
        {
            _FileDetailsDal.Update(aboutUs);
            return new SuccesDataResult<Users>(aboutUs);
        }
        public IDataResult<Users> Delete(Users aboutUs)
        {
            _FileDetailsDal.Delete(aboutUs);
            return new SuccesDataResult<Users>(aboutUs);
        }

        public IDataResult<List<Users>> GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Users> GetGiris(string UserName, string Password)
        {
            return new SuccesDataResult<Users>(_FileDetailsDal.Get(p => p.UserName == UserName && p.Password == Password));
        }

        public IDataResult<Users> GetKullaniciAdi(string KullaniciAdi)
        {
            return new SuccesDataResult<Users>(_FileDetailsDal.Get(p => p.UserName == KullaniciAdi));
        }

        public IDataResult<Users> GetByID(int UserID)
        {
            return new SuccesDataResult<Users>(_FileDetailsDal.Get(p => p.Id == UserID));
        }

        public IDataResult<List<Users>> GetUserNameList(string UserName)
        {
            return new SuccesDataResult<List<Users>>(_FileDetailsDal.GetList(p => p.UserName.Contains(UserName)));
        }

        IDataResult<Users> IUsersService.GetUserName(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
