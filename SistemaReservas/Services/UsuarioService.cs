using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Data;
using SistemaReservas.Models;
using System.Collections.Generic;

namespace SistemaReservas.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repo = new UsuarioRepository();

        public List<Usuario> ObtenerUsuarios()
        {
            return _repo.ObtenerTodos();
        }
    }}
