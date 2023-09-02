using Business.Abstract;
using Core.Entities.Utilities.Result;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Security.TokenSecurity;
using ErroHandler.Constans;

namespace CompanyA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUsersService _usersService;
        private readonly IJWTManagerRepository _jWTManager;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IUsersService usersService, IJWTManagerRepository jWTManager)
        {
            _logger = logger;
            _jWTManager = jWTManager;
            _usersService = usersService;
        }
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users user, string? username, string? password)
        {
            try
            {
                if (user.UserName == null || user.Password == null)
                {
                    return BadRequest();
                }
                var kullanici = _usersService.GetGiris(user.UserName, user.Password);

                if (kullanici.Data != null)
                {

                    var token = _jWTManager.Authenticate(kullanici.Data);
                    if (token == null)
                    {
                        _logger.LogWarning("Giriş hatası Token alınamadı user name: " + kullanici.Data.UserName + " user pass: " + kullanici.Data.UserName, DateTime.UtcNow);
                        return Unauthorized();
                    }
                    _logger.LogInformation("Başarılı Token Alındı user name: " + kullanici.Data.UserName + " user pass: " + kullanici.Data.UserName, DateTime.UtcNow);
                    return Ok(new SuccesDataResult<Token>(token, true, Message.GetUserSucces));
                    //return Ok(new SuccesResult(true, token));
                }
                else
                {
                    _logger.LogInformation(WarningErrorMessage.GetUserWarning + "Kullanici Mail Bulunamadı: : " + user.UserName, DateTime.UtcNow);
                    return BadRequest(new ErrorDataResult<Users>(WarningErrorMessage.GetUserWarning));
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
