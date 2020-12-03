using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelTDD.Services.User.Response
{
    public class UserLoginResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Perfil { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

        public UserLoginResponse()
        {
        }

        public UserLoginResponse(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
