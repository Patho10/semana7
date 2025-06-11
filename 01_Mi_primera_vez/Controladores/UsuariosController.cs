using _01_Mi_primera_vez.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_primera_vez.Controladores
{
    internal class UsuariosController
    {
        public List<Modelos.Usuarios> _ListaUsuarios = new List<Modelos.Usuarios>();
        
        private List<UsuarioModelo> _usuarios = new List<UsuarioModelo>();

        public List<Modelos.Usuarios> todos()
        {
            return _ListaUsuarios;

        }
        public Modelos.Usuarios uno(int UsuarioId)
        {
            return _ListaUsuarios.Find(usuarios => usuarios.UsuarioId == UsuarioId);
        }
        public string insertar(Modelos.Usuarios nuevoUsuario)
        {
            try
            {
                _ListaUsuarios.Add(nuevoUsuario);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string actualizar(Modelos.Usuarios actualizarUsuario)
        {
            try
            {
                var usr = _ListaUsuarios.Find(usuarios => usuarios.UsuarioId == actualizarUsuario.UsuarioId);
                if (usr == null)
                {
                    usr.Nombre = actualizarUsuario.Nombre;
                    usr.Apellido = actualizarUsuario.Apellido;
                    usr.Correo = actualizarUsuario.Correo;
                    usr.Nombre_Usuario = actualizarUsuario.Nombre_Usuario;
                    usr.Contrasenia = actualizarUsuario.Contrasenia;
                    usr.Estado = actualizarUsuario.Estado;
                    return "ok";
                }
                else
                {
                    return "Usuario no encontrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }
       public string eliminar(int UsuarioId)
        {
            try
            {
                var usr = _ListaUsuarios.Find(uid => uid.UsuarioId == UsuarioId);
                if (usr != null)
                {
                    _ListaUsuarios.Remove(usr);
                    return "ok";
                }
                else
                {
                    return "Usuario no encontrado";
                }
                }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public static UsuariosController Instancia
        {

            get
            {
                if (_instancia == null)
                    _instancia = new UsuariosController();
                return _instancia;
            }
        }


        public UsuariosController()
        { }
            public static UsuariosController _instancia;
        
        

        public void AgregarUsuario(UsuarioModelo usuario)
        {
            var nuevoUsuario = new Modelos.Usuarios
            {
                Nombre = usuario.Nombre,
                Correo = usuario.Correo
               
            };

            _ListaUsuarios.Add(nuevoUsuario);
        }

        public List<UsuarioModelo> ObtenerUsuarios()
        {
            return _ListaUsuarios.Select(u => new UsuarioModelo
            {
                Nombre = u.Nombre,
                Correo = u.Correo
            }).ToList();
        }
    }
    }


        
        


    