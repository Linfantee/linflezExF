using linflezExF.Dtos;
using linflezExF.Servicios;
using System.Security.Cryptography.X509Certificates;

namespace linflezExF
{
    /// <summary>
    /// Clase principal de la aplicación  
    /// </summary>
    class Program
    {
        string fichero = "C:\\Users\\csi23-linflez\\Desktop\\citas.txt";
        List<PacienteDto> listaPaciente = new List<PacienteDto>();
        public static void Main(string[] args)
        {
         

            MenuInterfaz mi = new MenuImplementacion();
           


            int opcionInicial;
            bool cerrarMenu = false;

            try
            {
                do
                {
                    opcionInicial = mi.menuInicial();

                  switch (opcionInicial)
                    {
                        case 0:
                            cerrarMenu = true;
                            Console.WriteLine("Se ha cerrado la aplicación. Hasta pronto.");
                            break;
                        case 1:
                            Console.WriteLine("Has entrado en registro de llegada.");
                            mi.menuLlegada();
                            break;
                        case 2:
                            Console.WriteLine("Has entrado en listado de consultas.");
                            break;
                        default:
                            Console.WriteLine("La opción seleccionada no existe elija otra por favor.");
                            break;


                  }

                }while(cerrarMenu);


            }catch (Exception ex)
            {
                Console.WriteLine("La aplicación esta en mantenimiento vuelva en 15 minutos.");
            }

        }
    }
}
