using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# Es un elegante lenguaje orientado a objetos utilizadon el Framework.Net que es conjunto bibliotecas de clases.

namespace ConceptosBasicos //Nombre del proyecto.
{
    class Program //Mi clase principla. Mi clase principal contiene un método principla llamdo MAIN.
    {
        static void Main(string[] args) //Al menos un método debe de tener mi proyecto y es el "Main".
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //En C# exiten tipos de datos similares a c y c++:
            int numero = 100;  //Enteros. 
            double pi = 3.1415; //Decimales. Otro ejemplo -> e = 2.71828
            char caracter = 'A'; //Caracter es una sóla letra. Nótese que se representa con comillas simples.
            bool soyFelizProgramando = true; //Verdadero o Falso.
            string Nombre = "Alfredo"; //Nótese que se representa con comillas dobles.
            /*Recuerda que un buen habito de programación es tener "variables","Atributos" 
             * con nombres significativos o descriptivos a lo que se este realizando.         
             */
            var num = 7; /*Palabra clave var hace que el copilador determine el tipo de dato. 
            *Var es tipo de dato "implicito" -> "var num;" ERROR es obligario inicializarla con un valor.
            *No es muy recomendable pierdes legibilidad en el código, sólo cuando sea comvenient.
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //En C# las constantes se definen con la palabra "const".
            const double e = 2.71828;  //Es obligatorio inicializarlo con un valor.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Desplegando salida:
            Console.WriteLine("*******Conceptos Básicos en C#.*******\n");
            Console.WriteLine("-El numero es: " + numero);
            Console.WriteLine("-El PI es: " + pi);
            Console.WriteLine("-El caracter es: " + caracter);
            Console.WriteLine("-Soy un programador feliz? " + soyFelizProgramando);
            Console.WriteLine("-Mi Nombre es: " + Nombre);
            Console.WriteLine("-Yo soy {0} y me gusta programar", Nombre);
            Console.WriteLine("-Palabra clave \"var\": " + num);
            //Exite el método "Write" es lo mismo sólo que no hay un salto de linea.
            Console.Write("-Constante e: " + e);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Entrada de usuario:
            string tuNombre; // Es recomendado declarar tus atributos al inicio del programa.
            int edad;
            Console.Write("\n\n-Cual es tu nombre? ");
            tuNombre = Console.ReadLine();
            Console.WriteLine("-Hola {0} bienvenid@!", tuNombre);
            Console.Write("-Cúal es tu edad? ");
            edad = Convert.ToInt32(Console.ReadLine()); //Como ReadLine es un método de "string" y edad un "int".
            //No se puede convertir por ello el "CONVERT" convierte el "int" a "string" int es igual ToInt32.
            Console.WriteLine("-Tu nombre es {0} y tienes {1} años", tuNombre, edad); //Se puede imprimir más de un dato.
            // Sólo se incrementa el número de los paréntesis {0}{1}{2}{3}{4}...{n}.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Operadores aritméticos.
            int w = 5, x = 7, y = 14, z = 0;
            z = x + y;
            Console.WriteLine("\n-La suma de {0} + {1} = {2}", x, y, z); //Adición.
            z = x - y;
            Console.WriteLine("-La resta de {0} - {1} = {2}", x, y, z); //Substracción.
            z = x * y;
            Console.WriteLine("-La multiplicación de {0} x {1} = {2}", x, y, z); //Multiplicación.
            z = y / x;
            Console.WriteLine("-La División de {0} / {1} = {2}", x, y, z); //División.
            z = x % y;
            Console.WriteLine("-La suma de {0} % {1} = {2}", x, y, z); //Módulo.
            //Precendencia de operadores.
            z = y + x * w;
            Console.WriteLine("-Resultado de operación: 14 + 7 * 5 = " + z);
            z = (y + x) * w;
            Console.WriteLine("-Resultado de operación: (14 + 7) * 5 = " + z);
            //Los "()" hacen una diferencia.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Operadores de asignación.
            int num1 = 155;
            num1 += 2; //Esto es igual num1 = num1 + 2; pero comprimido.
            Console.WriteLine("\n-Valores: " + num1);
            num1 = 155;
            num1 -= 1;
            Console.WriteLine("-Valores: " + num1);
            num1 = 155;
            num1 *= 5;
            Console.WriteLine("-Valores: " + num1);
            num1 = 155;
            num1 /= 4;
            Console.WriteLine("-Valores: " + num1);
            num1 = 155;
            num1 %= 7;
            Console.WriteLine("-Valores: " + num1);
            //Variable de Prefijo y Sufijo.
            int a = 5, b = ++a; //Prefijo.
            Console.WriteLine("-Prefijo: {0} {1}", a, b); //Incrementa el valor y luego continúa con la expresión.
            int c = 5, d = c++; //Sufijo.
            Console.WriteLine("-Sufijo: {0} {1}", c, d); //Evalúa la expresión y luego ejecuta el incremento.
            //Decremento.
            int t = 10, t2 = --t;
            Console.WriteLine("-Prefijo: {0} {1}", t, t2);
            int s = 10, s2 = t--;
            Console.WriteLine("-Sufijo: {0} {1}", s, s2);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey(); //Detiene la ejecución hasta que se presione una tecla.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
