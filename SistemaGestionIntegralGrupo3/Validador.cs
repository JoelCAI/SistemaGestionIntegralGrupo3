using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionIntegralGrupo3
{
    public class Validador
    {
        public static void ValidarString(string mensaje)
        {

           

        }

        public static void ValidarStringSioNo(string mensaje)
        {

            
        }

        public static void VerNombre(string mensaje)
        {

            Console.Clear();
            Console.WriteLine(" \n Usted ingreso la frase: " + mensaje);

        }

        public static void VolverMenu()
        {
            Console.WriteLine("\n Presione cualquier tecla para volver al Menú ");
            Console.ReadKey();
        }

        public static void PedirIntMenu(string mensaje, int min, int max)
        {
            

        }
    }
}
