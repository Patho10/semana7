using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRoles.Aplicacion
{
    public class UsuarioService
    {
        private AccesoDatos.UsuariosDAO _usuarioDAO = new AccesoDatos.UsuariosDAO();
        public List<Datos.UsuariosDTO> todos()
        {
            return _usuarioDAO.todos();
        }
        public string insertar(Datos.UsuariosDTO usuarioDTO)
        {
            return _usuarioDAO.insertar(usuarioDTO);
        }
        public string actualizar(Datos.UsuariosDTO usuarioDTO)
        {
            return _usuarioDAO.actualizar(usuarioDTO);
        }

        public string eliminar(int UsuarioId)
        {
            return _usuarioDAO.eliminar(UsuarioId);
        }
    }
}
