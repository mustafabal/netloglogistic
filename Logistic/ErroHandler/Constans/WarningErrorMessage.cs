using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErroHandler.Constans
{
    public static class WarningErrorMessage
    {        //login yaparken
        public static string LoginWarning = "Kullanıcı adı veya şifre hatalı !!!";
        //Slider
        public static string GetNoData = "Data Yok";
        //

        //kullanıcı oluştururken
        public static string CreateUserMultipleMailWarning = "Kullanıcı  birden fazla olamaz !!!";
        //kullanıcı güncelleme yaparken
        public static string UpdateUserMultipleMailWaning = "Kullanıcı Güncellerken birden fazla olamaz !!!";
        //kullanıcı data çekerken
        public static string GetUserWarning = "Kullanıcı Mail Bulunamadı";

    }
}
