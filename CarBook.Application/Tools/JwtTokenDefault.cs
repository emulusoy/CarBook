using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Tools
{
    public class JwtTokenDefault
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "eMu+8Em-I@ulu-C!01_Mu**21ar13*Bo!ok";
        public const int Expire = 5;//3 dakika
    }
}
