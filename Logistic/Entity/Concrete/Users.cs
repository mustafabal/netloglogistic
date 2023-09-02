using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
namespace Entity.Concrete
{
    public class Users : IEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? Status { get; set; }
        //burada gerekli dataişlemleri yapılabilir meslea userole vs gibi 
    }
}
