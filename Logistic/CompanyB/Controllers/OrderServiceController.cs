using Business.Abstract;
using Core.Entities.Utilities.Result;
using Entity.Concrete;
using ErroHandler.Constans;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Security.TokenSecurity;

namespace CompanyB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServiceController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderServiceController> _logger;
        public OrderServiceController(ILogger<OrderServiceController> logger, IOrderService orderService)
        {
            _logger = logger;
          
            _orderService = orderService;
        }
        [HttpGet]
        [Route("authenticate")]
        public IActionResult Authenticate()
        {
            try
            {
               
                var kullanici = _orderService.GetDateList(DateTime.Now.AddDays(-1));

                if (kullanici.Data.Count>0)
                {

                   
                   
                    _logger.LogInformation("Veriler geldi: "+ DateTime.Now.AddDays(-1).ToString(), DateTime.UtcNow);
                    return Ok(new SuccesDataResult<List<Order>>(kullanici.Data, true, Message.GetOrderList));
                    //return Ok(new SuccesResult(true, token));
                }
                else
                {
                    _logger.LogInformation(WarningErrorMessage.GetNoData + "Dün verileri hata alındı:: " , DateTime.UtcNow);
                    return BadRequest(new ErrorDataResult<Order>(WarningErrorMessage.GetNoData));
                }

                //return Ok(token);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Hata");
                throw;
            }
        }
    }
}

