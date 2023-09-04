using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderProduct  :IEntity
    {
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(3)]
        public string Urun { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(1)]
        public decimal Miktar { get; set; }
    }
}
