using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Aplicacion.Usuarios
{
    public class UsuarioService
    {
        private Capas_Acceso_Datos.Clases.ClaseUusarios _claseUsuarios = new Capas_Acceso_Datos.Clases.ClaseUusarios();
        public List<Capa_Datos.UsuarioDTO> todos()
        {
            return _claseUsuarios.todos();
        }
    }
}
