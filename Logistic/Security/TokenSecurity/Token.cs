using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.TokenSecurity
{
    public class Token
    {
        public string AccesToken { get; set; }
        public DateTime? Expires { get; set; }
        public string RefreshToken { get; set; }
    }
}
