using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerService.Response
{
    public class Orderer
    {
        public string TeslimAlacakKisi { get; set; }
        public string TelefonNo { get; set; }
        public string SevkNoktasi { get; set; }
        public DateTime Tarih { get; set; }
        public int id { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string lastModifiedBy { get; set; }
        public DateTime lastModifiedDate { get; set; }
    }

    public class OrderResponse
    {
        public List<Orderer> data { get; set; }
        public object dataList { get; set; }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }

}
