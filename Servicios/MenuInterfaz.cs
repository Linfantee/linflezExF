using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflezExF.Servicios
{
    /// <summary>
    /// Clase donde se guarda la cabecera de los métodos
    /// </summary>

    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método inicial de nuestra aplicación donde el paciente escoge las opciones.
        /// </summary>
        /// <returns></returns>
        public int menuInicial();

        /// <summary>
        /// Método de la llegada del paciente de nuestra aplicación donde escoge las opciones.
        /// </summary>
        /// <returns></returns>
        public void MenuLlegadaPaciente();

        /// <summary>
        /// Método de la llegada del paciente de nuestra aplicación donde escoge las opciones.
        /// </summary>
        /// <returns></returns>
        public int menuLlegada();

    }
}
