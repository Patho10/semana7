using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_primera_vez
{
    internal static class Program
    {
        //variables globales
        public static int UsuarioId;
        public static string NombreUsuario;
        public static bool estado;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vistas.Usuarios.Usuarios());
        }
    }
}
