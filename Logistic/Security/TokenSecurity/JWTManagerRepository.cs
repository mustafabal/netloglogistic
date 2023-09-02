using Business.Abstract;
using Entity.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Security.TokenSecurity
{
    public class JWTManagerRepository : IJWTManagerRepository
    { // buraya usermodel gelcek


        private readonly IConfiguration iconfiguration;
        private readonly IUsersService kullaniciservice;
        public JWTManagerRepository(IConfiguration iconfiguration, IUsersService _kullaniciservice)
        {
            this.iconfiguration = iconfiguration;
            this.kullaniciservice = _kullaniciservice;
        }
        public Token Authenticate(Users users)
        {
            var kullanici = kullaniciservice.GetGiris(users.UserName, users.Password);


            if (kullanici == null)
            {
                return null;
            }

            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["Token:SecurityKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, users.UserName)
              }),
                Expires = DateTime.Now.AddMinutes(Convert.ToInt16(iconfiguration["Token:Expiration"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256),
                Issuer = iconfiguration["Token:Issuer"],
                Audience = iconfiguration["Token:Audience"]
            };


            var token = tokenHandler.CreateToken(tokenDescriptor);
            byte[] numbers = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(numbers);
            return new Token { AccesToken = tokenHandler.WriteToken(token), Expires = (tokenDescriptor.Expires), RefreshToken = Convert.ToBase64String(numbers) };








        }
    }
}
