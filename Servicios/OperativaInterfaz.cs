using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflezExF.Servicios
{
    /// <summary>
    /// Clase donde se encuentra la cabecera de los métodos de las operaciones.
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que valida el dni del paciente
        /// </summary>
        /// <returns></returns>
        public void validacionDni();
        /// <summary>
        /// Método que carga la información de los pacientes desde el fichero.
        /// </summary>
        /// <returns></returns>
        public void cargaInicial();
    }
}
