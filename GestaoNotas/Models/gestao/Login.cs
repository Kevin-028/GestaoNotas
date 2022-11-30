using System;
using System.Linq;

namespace GestaoNotas.gestao
{
    public class Login
    {
        public int IdLogin { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        public string perfil { get; set; }

        public Login() { }


    }
}
