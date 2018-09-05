using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Se llama a la clase, se crea un instancia! -> objeto "Alfredo" es igual a nuevo objeto de la clase
            //Pesona.
            Persona Alfredo = new Persona();

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Se manda a llamar un atributo publico! SIN "get" NI "set".
            Console.Write("Apodo es: ");
            Alfredo.apodo = Console.ReadLine();
            Console.WriteLine("Su apodo: {0} esta chido!", Alfredo.apodo);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Se manda a llamar un atributo privado! Aparte que el "get" y "set" tipo C++ y C#.
            Console.Write("Nombre es: ");
            Alfredo.setNombre(Console.ReadLine());
            Console.WriteLine("Mi nombre es: " + Alfredo.getNombre());

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Se manda a llamar el "get" y "set" de forma simplificada. ->Los descriptores "get" y "set"
            Console.Write("Apellido es: ");
            Alfredo.Apellido = Console.ReadLine();
            Console.WriteLine("Mi apellido es: " + Alfredo.Apellido);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Se manda a llamar los descriptores "get" y "set", pero personalizados.
            Console.Write("La edad es: ");
            Alfredo.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mi edad es: " + Alfredo.Edad);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Los demas "get" y "set" son lo mismo! 
            Console.Write("El peso es: ");
            Alfredo.Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mi peso es: " + Alfredo.Peso);

            Console.Write("El estatura es: ");
            Alfredo.Estatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mi estatura es: " + Alfredo.Estatura);

            Console.Write("El color de cabello es: ");
            Alfredo.ColorCabello = (Console.ReadLine());
            Console.WriteLine("Mi color de cabello es: " + Alfredo.ColorCabello);

            Console.Write("El color de ojos es: ");
            Alfredo.ColorOjos = (Console.ReadLine());
            Console.WriteLine("Mi color de ojos es: " + Alfredo.ColorOjos);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Propiedades auto-implementadas: "get" y "set"
            Console.Write("El color de piel es: ");
            Alfredo.ColorPiel = (Console.ReadLine());
            Console.WriteLine("Mi color de piel es: " + Alfredo.ColorPiel);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //Métodos.
            Alfredo.Hablar();
            Console.WriteLine("Corriendo {0} kilometros.", Alfredo.Correr(7)); //Este es mejor!
            Console.WriteLine("Corriendo " + Alfredo.Correr(5) + " kilimetros."); //Es lo mismo, pero peor!

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
