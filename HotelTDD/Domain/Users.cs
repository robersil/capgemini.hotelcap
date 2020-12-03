using HotelTDD.Domain.Core;

namespace HotelTDD.Domain
{
    public class Users : DomainBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }

        public Users(string name, string email, string senha, string perfil)
        {
            this.Name = name;
            this.Email = email;
            this.Senha = senha;
            this.Perfil = perfil;
        }
    }
}
