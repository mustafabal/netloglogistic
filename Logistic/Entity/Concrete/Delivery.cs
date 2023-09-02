using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Delivery:IEntity
    {
        public DateTime Tarih { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(8, ErrorMessage = "plaka en fazla 8 karakter olmalı"), MinLength(3, ErrorMessage = "plaka En az 6 karakter olmalı")]
        public string Plaka { get; set; }

        public Users TeslimEdenKisi { get; set; }
    }
}
