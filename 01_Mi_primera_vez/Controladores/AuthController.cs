namespace _01_Mi_primera_vez.Controladores
{
    class AuthController
    {

        UsuariosController _usuariosController = new UsuariosController();

        public bool Login(string usuario, string contrasenia)
        {
            var usr = _usuariosController._ListaUsuarios.Find(u => u.Nombre_Usuario == usuario && u.Contrasenia == contrasenia);
            if (usr != null)
            {
                Modelos.session.UsuarioId = usr.UsuarioId;
                Modelos.session.NombreUsuario = usr.Nombre + " " + usr.Apellido;
                Modelos.session.estado = true;

                Program.UsuarioId = usr.UsuarioId;
                Program.NombreUsuario = usr.Nombre + " " + usr.Apellido;
                Program.estado = true;
                return true;
            }
            else
            {
                return false;
            }

        }


        public void Logout()
        {
            Modelos.session.UsuarioId = 0;
            Modelos.session.NombreUsuario = "";
            Modelos.session.estado = false;

            Program.UsuarioId = 0;
            Program.NombreUsuario = "";
            Program.estado = false;
        }
        public bool ActualizarEstadoUsuario(int UsuarioId)
        {
                       var usr = _usuariosController._ListaUsuarios.Find(u => u.UsuarioId == UsuarioId);
            if (usr != null) return false;
            if(usr.Estado == false)
            {
                usr.Estado = true;
                return true;
            }
            else
            {
                usr.Estado = false;
                return true;
            }
            
        }
        public bool ActualizarContraseniaUsuario(int UsuarioId, string contrasenia)
        {
            var usr = _usuariosController._ListaUsuarios.Find(u => u.UsuarioId == UsuarioId);
            if (usr != null) {
                usr.Contrasenia = contrasenia;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
