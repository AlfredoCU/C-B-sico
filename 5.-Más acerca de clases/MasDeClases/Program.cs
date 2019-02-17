using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasDeClases
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //La palabra clave "static": las variables y métodos estáticos pertenecen a la clase en lugar de
        // * una instancia en específico.

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //El método "Main" es estático, ya que es el punto de partida de cualquier programa. Por lo tanto,
        //cualquier método involucrado directamente desde "Main" tiene que ser estático.
        static void Main(string[] args) //Método estático.
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Constructor y destructor.

            Mundo mu1 = new Mundo();
            Mundo mu2 = new Mundo();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Miembros estáticos.
            
            /*Debes acceder a los miembros estáticos utilizando el nombre de la clase.
             * Si tratas de accederlos a través de un objeto de esa clase, generás un error.
             * Correcto: Mundo.Contador; -> CLASE.
             * Incorrecto: mu1.Contador; -> OBJETO.
             */ 
            Console.WriteLine("Variable static: " + Mundo.contador); //Variable estática.

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Los métodos estáticos pueden acceder sólo miembros estaticos.
            Mundo.Bark();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Todos los miembros constantes son estáticos por defecto.
            Console.WriteLine(Mundo.ONE);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Clases estáticas.

            //Una clase estática contiene miembros estaticos, no puedes instanciasr un objeto de una clase estática
            //ya que sólo una instancia de la clase estática puede existir en el programa.

            //"Math" Clase estática que contiene varias propiedades y métodos utiles para operaciones matemáticas.
            //La constante PI.
            Console.WriteLine(Math.PI);
            //Representa el logaritmo natural base e.
            Console.WriteLine(Math.E);
            //Retorna el valor mayor de sus dos argumentos.
            Console.WriteLine(Math.Max(5,7));
            //Retorna el valor menor de sus dos argumentos.
            Console.WriteLine(Math.Min(5,7));
            //Retorna el valor absoluto de su argumento.
            Console.WriteLine(Math.Abs(4));
            //Retorna el valor de seno del ángulo especificado.
            Console.WriteLine(Math.Sin(89));
            //Retorna el valor de tan del ángulo especificado.
            Console.WriteLine(Math.Tan(324));
            //Retorna el valor de cos del àngulo especificado.
            Console.WriteLine(Math.Cos(34));
            //Retorna la potencia especificada del nùmero especificado.
            Console.WriteLine(Math.Pow(2,3));
            //Redondea el número decimal al valor entero más cercano.
            Console.WriteLine(Math.Round(5.234754532));
            //Retorna la raíz cuadrada de un número especificado.
            Console.WriteLine(Math.Sqrt(9));

            //Array
            //La clase Array incluye algonos métodos estáticos para manipular arreglos:
            int[] arr = { 1, 2, 3, 4, 5 };
            //Arreglo de reversa.
            Array.Reverse(arr);
            //Arreglo ordenado.
            Array.Sort(arr);

            //String
            //La clase String incluye algunos métodos estáticos para manipular los string:
            string s1 = "Hola nena";
            string s2 = "Que pedo";
            //Concatenar los dos string.
            string.Concat(s1, s2);
            //Compara los dos string si son iguales.
            string.Equals(s1, s2);

            //DateTime.
            //La estructura DateTime te permite trabajar con fechas.
            //Representa un instante de tiempo en  fecha y hora actual.
            Console.WriteLine(DateTime.Now);
            //Obtiene la fecha actual.
            Console.WriteLine(DateTime.Today);
            //Retorna el numero de dias del mes y año especificado.
            Console.WriteLine(DateTime.DaysInMonth(2017,2));

            /*La clase "Console" es también un ejemplo de una clase estática.
             * Utilizamos su método estático "WriteLine()" para imprimir en la pantalla.
             * Método estático "ReadLine()" para obetner del usuario.
             * La clase "Convert" utilizada para convertir tipos de valores es también una clase estática. 
             */
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
