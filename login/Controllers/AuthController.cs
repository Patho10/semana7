using login.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace login.Controllers
{
    class AuthController
    {
        // public List<Models.loginModel> _listaLoginModels = new List<Models.loginModel>();
        private Models.loginModel _loginModel = new Models.loginModel();
       /* public AuthController()
        {
            var usuario = new Models.loginModel
            {
                Contrasenia = "123",
                Correo = "coreo@gmail.com",
                Estado = true,
                Nombre = "Admin",
                NombreUsuario = "Admin",
                UsuarioId = 1
            };
            _listaLoginModels.Add(usuario);
        }*/
       /*
        public List<Models.loginModel> todos()
        {
            return _listaLoginModels;
        }

        public Models.loginModel uno(int id)
        {
            return _listaLoginModels.Find(u => u.UsuarioId == id);
        }

        public Models.loginModel uno(string usuario)
        {
            return _listaLoginModels.Find(u => u.NombreUsuario == usuario);
        }
       */
        public string login(Models.loginModel Usuario)
        {
            return _loginModel.VerificarLogin(Usuario);
        }

        public void logOut()
        {
            Program.Nombreusuario = "";
            Program.Estado = 0;
            Program.UsuarioId = 0;
        }
    }
}