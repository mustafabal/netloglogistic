using Business.Abstract;
using Entity.Concrete;
using Newtonsoft.Json;
using Quartz;
using SchedulerService.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerService
{
    public class CompleteOrderTimeJob:IJob
    {
        private const string URL = "https://localhost:7290//api/OrderService/authenticate";


        public Task Execute(IJobExecutionContext context)
        {
            //soap verileri çekilecek  ve kendi dbmize eklenecek
            ConsumeEventSync objsync = new ConsumeEventSync();
            objsync.GetAllEventData();
            var now = DateTime.Now.ToString("HH : mm : ss");
            Console.WriteLine($" soap verileri çekilecek {now}");

            return Task.CompletedTask;
        }

        public class ConsumeEventSync
        {
            private readonly IOrderService _orderService;

            public void GetAllEventData() //Get All Events Records  
            {
                using (var client = new WebClient()) //WebClient  
                {
                    client.Headers.Add("Content-Type:application/json"); //Content-Type  
                    client.Headers.Add("Accept:application/json");
                    var result = client.DownloadString(URL);
                    var ser = JsonConvert.DeserializeObject<OrderResponse>(result);

                    foreach (var item in ser.data)
                    {
                        Order neworder = new Order()
                        {
                            CreatedBy = "Soap",
                            CreatedDate = DateTime.Now,
                            LastModifiedBy = "",
                            SevkNoktasi = item.SevkNoktasi,
                            LastModifiedDate = DateTime.Now,
                            Tarih = item.Tarih,
                            TelefonNo = item.TelefonNo,
                            TeslimAlacakKisi = item.TeslimAlacakKisi
                        };
                        _orderService.Add(neworder);
                    }

                    Console.WriteLine(Environment.NewLine + result);
                }
            }
        }
    }
}

