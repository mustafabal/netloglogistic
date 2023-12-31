﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order   :IEntity
    {
        public string TeslimAlacakKisi { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(13, ErrorMessage = "Telefon En fazla 13 karakter"), MinLength(10, ErrorMessage = "Telefon En az 10 karakter")]
        public string TelefonNo { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(3)]
        public string SevkNoktasi { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public DateTime Tarih { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan"), MaxLength(50), MinLength(3)]
        public int status { get; set; }
    }
}
