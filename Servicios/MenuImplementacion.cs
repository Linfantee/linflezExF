using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflezExF.Servicios
{
    /// <summary>
    /// Método que se encarga de contener la implementación de los menús.
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        OperativaInterfaz oi = new OperativaImplementacion();

        
       
        public int menuInicial()
        {
            int opcion;
            Console.WriteLine("0. Cerrar menú.");
            Console.WriteLine("1. Registro de llegada.");
            Console.WriteLine("2. Listado de consultas.");
            opcion = int.Parse(Console.ReadLine());

            return opcion;
        }

        public int menuLlegada()
        {
            int opcion;

            Console.WriteLine("0. Volver al inicio.");
            Console.WriteLine("1. Introduce su dni");
            opcion = int.Parse(Console.ReadLine());

            return opcion;
        }


        public void MenuLlegadaPaciente()
        {
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {

                opcionSeleccionada = menuLlegada();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Se ha vuelto al inicio.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Introduzca su DNI.");
                        oi.validacionDni();
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no existe elija otra por favor.");
                        break;


                }
                
            }
           
        }



    }
}
