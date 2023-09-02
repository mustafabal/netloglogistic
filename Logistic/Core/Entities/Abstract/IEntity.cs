using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public abstract class IEntity
    {
         //standart olarak belirlediğim ve bütün entitylerde olacak alanları entity-concrete içerisinde implement edeceğim 
        public long Id { get; protected set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
