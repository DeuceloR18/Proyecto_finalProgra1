using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuales para la aplicación
            Application.EnableVisualStyles();

            // Configura la representación de texto compatible
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia la aplicación con el formulario Login
            Application.Run(new Login());

            // Si necesitas usar el formulario MDIMaster, descomenta la línea siguiente
            // Application.Run(new MDIMaster());
        }
    }
}

