using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Un método es un grupo de declaraciones que realizan una tarea en particular.
        static int Multiplicacion (int x) // Esto -> (int x) se le llama parámetros.
        {
            int resultado = x * x;
            return resultado; //Método retorna un valor!
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Hola () //Método void no retorna ningun valor!
        {
            Console.WriteLine("Hola Mundo!");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int Suma (int x,int y) //Múltiples parámetros. 
        {
            int resultado = x + y;
            return resultado;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static double Potencia (double x, double y = 2) //Argumentos opcionales ya que tiene un valor
        {                                               //Predeterminado "double y = 2".
            double resultado = 1;
            for(int i = 0; i < y; i++)
            {
                resultado *= x;
            }
            return resultado;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int AreaTriangulo (int b, int a) //Argumentos con nombres.
        {
            return (b * a) / 2;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Sqr (int l) //Pasando argumento por valor.
        {
          l *= l;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Sqr1 (ref int l) //Pasando argumento por referencia.
        {
            l *= l;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void tomaValores (out int x, out int y) //Pando argumento por salida.
        {
            x = 75;
            y = 57;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Sobrecarga de métodos.
        static void Imprimir(int a)
        {
            Console.WriteLine("Valor: " + a);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Imprimir(double a)
        {
            Console.WriteLine("Valor: " + a);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Imprimir(string Nombre, double a)
        {
            Console.WriteLine(Nombre + " Valor: " + a);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*El método factorial se invoca a sí mismo, y luego continúa haciéndolo, hasta que el argumento
         * igual a 1. La condición de salida previene que el método se llame a si mismo indefinidamente.
         */
        static int Factorial(int num) //Método recursivo.
        {
            if(num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Piramide(int n) //Haciendo una piramide. Contiene números impares de "*"
        {
            for (int i = 1; i <= n; i++) //Itera a través de cada fila de la pirámide.
            {
                for(int j = i; j <= n; j++) //Despliega los espacios requeridos antes del primer "*"
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 2*i-1; k++) //Despliega el número de "*" requeridos calculado (2*i-1)
                {
                    Console.Write("*" + "");
                }
                Console.WriteLine(); //Mueve el cursor a la siguiente fila
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Main(string[] args) //Cada programa C# válido tiene al menos un método, el método Main.
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Invocando métodos.
            Console.WriteLine(Multiplicacion(5)); //Se puede invocar un método las veces que se deseé.
            Console.WriteLine(Multiplicacion(7));
            Hola();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(Suma(7,7));
            //Tambien se puede hacer así.
            int res = Suma(5, 5);
            Console.WriteLine(res);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Un método sólo se le pasa un valor y toma el predetermidado que es 2 -> double y = 2 observa!
            Console.WriteLine(Potencia(3));

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Le mandamos los dos parametros y ya no toma el predeterminado -> Lo ignora por completo!
            Console.WriteLine(Potencia(2, 8));

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Los nombres de los parámetros para proveer los argumentos en el orden que lo desees.
            Console.WriteLine(AreaTriangulo(a:12,b:2));

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Pasando argumento por valor -> En este caso, "l" es el parámetro del método "Sqr" y "a" es el
             * verdadero argumento pasado al método. Como puedes ver, el método "Sqr" no modifica el valor
             * original de la variable, ya que es pasado por valor, significando que opera sobre el valor, no
             * sobre la variable actual.
            */
            int a = 3; 
            Sqr(a);
            Console.WriteLine(a);
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Pasando argumento por referencia -> "ref" pasa la dirección de memoria al parámetro del método lo
             * cual permite al método operar sobre la propia variable. recuerda el otro era sólo el valor 
             * este es ¡la variable!
            */
            Sqr1(ref a);
            Console.WriteLine(a);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /*Pasando argumento por salida -> "out" es similar al "ref" excepto que ellos transfieren datos 
             * desde el método hacia el parámetro en lugar de recibir.
            */
            int x, y;
            tomaValores(out x, out y);
            Console.WriteLine(x + " y " + y);
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Sobrecarga de métodos.
            Imprimir(7);
            Imprimir(7.57);
            Imprimir("Alfredo",117.7);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Método recursivo.
            Console.WriteLine(Factorial(7));

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Pirámide.
            Piramide(7);
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
