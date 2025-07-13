using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alertas_Timer.Models
{
    public class AlertaModel
    {
        public int Id { get; set; }
        public string tipo { get; set; }
        public float valor { get; set; }
        public DateOnly fecha { get; set; }
        public TimeOnly hora { get; set; }
        public string mensaje { get; set; }
        public string estado { get; set; }
        public ServidorModel Servidores { get; set; }
        public ParametroModel Parametros { get; set; }

        /// <summary>
        /// Informaicon solo para las vistas
        /// esto no se envia al servidor por la etiqueta NotMapped
        /// </summary>
        /// Modelos de Servidores

        [NotMapped]
        public int id_servidor => Servidores?.Id ?? 0;
        [NotMapped]
        public string nombre_servidor => Servidores?.nombre_servidor ?? "";
        [NotMapped]
        public string ip_servidor => Servidores?.ip ?? "";
        [NotMapped]
        public string ubicacion_servidor => Servidores?.ubicacion ?? "";
        [NotMapped]
        public string sistema_operativo => Servidores?.sistema_operativo ?? "";
        [NotMapped]
        public string estado_servidor => Servidores?.estado ?? "";

        //Moddelo de Parametros
        [NotMapped]
        public int id_parametros => Parametros?.Id ?? 0;
        [NotMapped]
        public string nombre_parametro => Parametros?.nombre_parametro ?? "";
        [NotMapped]
        public string unidad_parametros => Parametros?.unidad ?? "";
    }
}
