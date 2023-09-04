using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
namespace Entity.Concrete
{
    public class Users : IEntity
    {
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(3)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public bool? Status { get; set; }
        //burada gerekli dataişlemleri yapılabilir meslea userole vs gibi 
    }
}
