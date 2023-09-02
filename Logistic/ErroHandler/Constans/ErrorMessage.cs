using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErroHandler.Constans
{
    public static class ErrorMessage
    {
        //Validasyonm hataları
        public static string ValidationError = "Validasyon Errors :";

        //login yaparken
        public static string LoginError = "Sisteme giriş yaparken sistemsel bir hata oluştu!!!";
        //kullanıcı oluştururken
        public static string CreateUserError = "Kullanıcı Oluşturulurken sistemsel bir hata oluştu !!!";
        //kullanıcı güncelleme yaparken
        public static string UpdateUserError = "Kullanıcı Güncellerken sistemsel bir hata oluştu !!!";
        //kullanıcı data çekerken
        public static string GetUserError = "Kullanıcı  Sorgulanırken  sistemsel bir hata oluştu !!!";
    }
}
