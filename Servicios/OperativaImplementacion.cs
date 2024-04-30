using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linflezExF.Servicios
{
    /// <summary>
    /// Clase donde se encuentran las operaciones de la aplicación.
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void validacionDni()
        {
            
            Console.WriteLine("Introduzca su DNI (Números)");
            string dniN = Console.ReadLine();
            Console.WriteLine("Introduzca su DNI (Letra)");
            string dniL = Console.ReadLine();
            string DNI = string.Concat(dniN, dniL);
            string[] letrasDni = {"T","R","W","A","G","M","Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E"};

           

              
        }


        public void cargaInicial()
        {
          
            Console.WriteLine("47966922T;Alfonso;Fernández García;Psicología;29-04-2024 12:30:00;true");
            Console.WriteLine("47166912T;Marta;Fernández Fernández; Psicología; 29-04-2024 13:00:00;false");
            Console.WriteLine("17165912O;Pedro;Collado Puente; Fisioterapia; 30-04-2024 11:00:00;");
            Console.WriteLine("37165912P;Laura;Quintero García; Psicología; 29-04-2024 13:30:00;true");
            Console.WriteLine("17165912O;Pedro;Collado Puente; Fisioterapia; 29-04-2024 11:00:00;false");
            Console.WriteLine("37165912P;Laura;Quintero García; Psicología; 25-04-2024 13:30:00;false");


        }

    }
}
