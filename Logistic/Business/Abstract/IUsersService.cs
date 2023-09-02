using Core.Entities.Utilities.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<List<Users>> GetUserNameList(string UserName);
        IDataResult<Users> GetUserName(string UserName);
        IDataResult<Users> GetGiris(string UserName, string Password);
        IDataResult<Users> GetKullaniciAdi(string KullaniciAdi);
        IDataResult<Users> GetByID(int UserID);
        IDataResult<Users> Add(Users user);
        IDataResult<Users> Update(Users user);
    }
}
