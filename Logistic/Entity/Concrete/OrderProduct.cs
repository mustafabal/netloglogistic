using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderProduct  :IEntity
    {
        public string Urun { get; set; }
        public decimal Miktar { get; set; }
    }
}
