using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial.Aplicacion
{
    public class AlquilerService
    {
        private readonly AccesoDatos.AlquilerDAO _servicioDAO = new AccesoDatos.AlquilerDAO();

        public List<Datos.AlquilerDTO> todos()
        {
            return _servicioDAO.todos();
        }

        public string insertar(Datos.AlquilerDTO alquilarDTO)
        {
            return _servicioDAO.insertar(alquilarDTO);
        }

        public string eliminar(int servicioID)
        {
            return _servicioDAO.eliminar(servicioID);
        }

        public string actualizar(Datos.AlquilerDTO alquiler)
        {
            return _servicioDAO.actualizar(alquiler);
        }
    }
}