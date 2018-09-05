using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasDeClases
{
    class Mundo
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int contador = 0; //Variable estática.
        public const int ONE = 1; //Las constantes son estáticos.

        //Métodos de acceso estáticos.
        public static int X { get; set; }
        public static int Y { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Esto puede ser útil, por ejemplo, si tu clase está trabajando con almacenaje o archivos.
         * El "constructor"inicializará y abrirá los archvisos.
         * Luego, cuando el programa finalice el "destructor" cerrará los archivos.
         */ 
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Métodos especiales que son utilizados para inicializar objetos, y que son invocados al momento de la
        // * creación de los objetos.
        public Mundo()
        {
            Console.WriteLine("Constructor, crea el objeto");
            contador++;
        }

        //Constructor estático. Para inicializar miembros estaticos y estos sean invocados una vez cuando tratemos
        //de acceder a "X" y "Y".
        static Mundo()
        {
            X = 57;
            Y = 75;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Métodos especiales que son invocados al momento del borrado del objeto.
        ~Mundo()
        {
            Console.WriteLine("Destructor, elimina el objeto al final del programa.");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //El mismo concepto aplica a métodos estáticos.
        public static void Bark()
        {
            Console.WriteLine("Woof");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
