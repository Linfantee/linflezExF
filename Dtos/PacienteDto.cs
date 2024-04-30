using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflezExF.Dtos
{
    internal class PacienteDto
    {
        string DNI;
        string nombre;
        string apellidos;
        string especialidad;
        DateTime fechaCita;
        bool asistenciaCita;

        public string DNI1 { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }

        public PacienteDto(string dNI, string nombre, string apellidos, string especialidad, DateTime fechaCita, bool asistenciaCita)
        {
            DNI = dNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistenciaCita = asistenciaCita;
        }

    }
}
