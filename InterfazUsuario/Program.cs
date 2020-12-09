using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_Login());
        }
    }
    public class Ruta
    {
        //Variables del path a los archivos que usa la aplicacion, guardadas en InterfazUsuario\bin\Debug
        public static string rutaUsuario = "usuarios.txt";
        public static string rutaEstacion= "estacion.txt";

        //Variables publicas de la aplicación
        public static string noRuta;

    }
}
