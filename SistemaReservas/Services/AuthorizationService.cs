using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace SistemaReservas.Services
{
    public static class AuthorizationService
    {
        public static string RolActual { get; set; }

        public static void AplicarPermisos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (!string.IsNullOrEmpty(ctrl.Tag?.ToString()))
                {
                    var permitidos = ctrl.Tag.ToString().Split(',');
                    ctrl.Enabled = permitidos.Contains(RolActual);
                }

                if (ctrl.HasChildren)
                    AplicarPermisos(ctrl.Controls);
            }
        }
    }
}

