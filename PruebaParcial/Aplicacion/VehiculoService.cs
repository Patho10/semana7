using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcial.Aplicacion
{
    public class VehiculoService
    {
        private readonly AccesoDatos.VehiculoDAO _vehiculoDAO = new AccesoDatos.VehiculoDAO();

        public List<Datos.VehiculoDTO> todos()
        {
            return _vehiculoDAO.todos();
        }

        public string insertar(Datos.VehiculoDTO vehiculoDTO)
        {
            return _vehiculoDAO.insertar(vehiculoDTO);
        }

        public string eliminar(int VehiculoID)
        {
            return _vehiculoDAO.eliminar(VehiculoID);
        }

        public string actualizar(Datos.VehiculoDTO vehiculo)
        {
            return _vehiculoDAO.actualizar(vehiculo);
        }
    }
}