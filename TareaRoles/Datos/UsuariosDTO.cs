using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRoles.Datos
{
    public class UsuariosDTO
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public int IdRol { get; set; }
    }
}
