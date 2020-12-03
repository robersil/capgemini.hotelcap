using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelTDD.Services.User.Request
{
    public class UserCreateRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }
        public string Senha { get; set; }

        public UserCreateRequest()
        {                
        }
    }
}
