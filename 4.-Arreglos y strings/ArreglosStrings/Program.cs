using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Arreglos.

            //Un arreglo es una estructura de datos que almacena una colección de datos del mismo tipo.
            int[] miArreglo = {11,57,75,21,100 }; //Así se declara un arreglo.
            
            //Como los arreglos son objetos necesitamos instanciarlos con la palabra clave "new".
            int[] numeros = new int[5];
            numeros[4] = 7; //Esto asignará el valor 7 al primer elemento del arreglo que es 0.

            //Arreglos con string y double.
            string[] nombres = new string[2] { "Alfredo", "Victor" };
            double[] decimales = new double[3] { 7.5, 1.2, 4.3 };

            //Se puede omitir la declaración del tamaño, cuando los datos son proveídos de las llavas.
            string[] apodos = new string[] { "Ferillo", "Wero","Pata","Tocina","Tocino" };
            double[] promedios = new double[] { 7.5, 10.2, 14.3,75.57,10.10 };

            //Así se imprime un arreglo.
            Console.WriteLine(miArreglo[0]); //Recuerda que es 5 elementos y 5 direcciones de memoria 0,1,2,3,4.
            Console.WriteLine(numeros[4]); //Seria el elemento final. recuerda que comienza desde el 0.
            Console.WriteLine(nombres[1]);
            Console.WriteLine(decimales[2]);
            Console.WriteLine(apodos[2]);
            Console.WriteLine(promedios[0]);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Arreglos y bucles.

            //Asignar valores a un arreglo.
            int[] a = new int[10];
            for(int i = 0; i < 10; i++)
            {
                a[i] = i * 2;
            }
            
            //Leer los valores de un arreglo.
            for(int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + ", ");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //El bucle "foreach" -> Es muy util!

            //Provee una forma más fácil y corta para acceder a los elementos de un arreglo.
            foreach (int i in a) //i es el inicializador y a es el arreglo.
            {
                Console.Write(i + ", ");
            }
            /*El tipo de datos de la variable de "foreach" osea "i" debe coincidir con el tipo de dato de los
             * elementos del arreglo.
             * Se puede utilizar var, para que el copilador determine el tipo de dato apropiado.
             */
            int[] b = new int[] {7,5,1,5,3,8,9,11,21,25 };
            int sum = 0;
            foreach(int i in b) //b[i] Se intera a través de cada elemento del arreglo, añadiendo el valor del
            {                   //elemento correspondiente a la variable sum.
                sum += i;
            }
            Console.WriteLine("\nLa suma es:" + sum);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Arreglos Multidimensionales.
             
            //                         0        1        2
            int[,] x = new int[,] { {7,5,1}, {1,2,8}, {8,4,2} }; //3 Filas y 3 Columnas.
            for(int i = 0;  i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] +" ");
                }
                Console.WriteLine();
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Suma de Matrices.

            int[,] matriz = new int[3,3];
            int[,] matriz2 = new int[3, 3];
            int[,] matriz3 = new int[3, 3];

            Console.WriteLine("\nMatriz 1.");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Insertando valor [{0}][{1}] = ", i + 1, j + 1);
                    //Parse o TryParse son un método como el convert.
                    matriz[i,j] = int.Parse(Console.ReadLine()); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz 2.");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Insertando valor [{0}][{1}] = ", i + 1, j + 1);
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nImprimir Matriz 1.");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nImprimir Matriz 2.");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de la matriz 1 y matriz 2.");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz[i, j] + matriz2[i, j];
                    Console.Write(matriz3[i, j] + " ");
                }
                Console.WriteLine();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Jagged Arrays.

            //Es un arreglo de arreglos.
            int[][] jaggedArr = new int[3][];
            //Cada dimensión es un arreglo, por lo que también puedes inicializar el arreglo durante la declaración:
            int[][] jaggedArr2 = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {2,4,6,8},
                new int[] {57,75}
            };
            //Para poder acceder elementos individuales del arreglo como se muestra es:
            int arr = jaggedArr2[2][1]; //Esto accede al segundo elemento del tercer arreglo.
            //[2] Es arreglo 0,1,2 el 2 es el arreglo 3 y [1] es elemento 0,1 el 1 es el elemento 2.
            Console.WriteLine("El arreglo de arreglo: " + arr);
            //Esto es un arreglo de arreglos bidimensionales.
            int[][,] arregloDeArreglos = new int[8][,];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Propiedades de arreglos.

            int[] propiedades = { 5, 7, 2 };
            
            //La propiedad "Length" retornan el número de elementos del arrelgo.
            Console.WriteLine("Elementos del arreglo: " + propiedades.Length);
            //La propiedad "Rank" retorna el número de dimensiones del arreglo.
            Console.WriteLine("Dimensiones del arreglo: " + propiedades.Rank);

            //"Length" es útil en un bucle for donde necesitas especidicar el número de veces que el bucle debe
            // * ejecutarse.
            for(int i = 0; i < propiedades.Length; i++)
            {
                Console.Write(propiedades[i] + ", ");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Métodos de arreglos.

            //El método "Max" retorna el elemento de mayor valor.
            Console.WriteLine(propiedades.Max());
            //El método "Min" retorna el elemento de menor valor.
            Console.WriteLine(propiedades.Min());
            //El método "Sum" retorna la suma de todos los elementos.
            Console.WriteLine(propiedades.Sum());

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Strings.

            /* Es común pensar en "strings" como arreglos de caracteres. En realidad, "strings en" C# son objetos.
             * Cuando declaras una variable "string", básicamente estás instanciando un objeto del tipo "String"
             * Los objetos "String" soportan un número de propiedades y métodos utiles:
             */
            
            string pruebasDeStrings = "Buenos días alegria";
            Console.WriteLine("La palabra es: " + pruebasDeStrings);
            
            //"Length" retorna la longitud del "string".
            Console.WriteLine(pruebasDeStrings.Length);
            
            //IndexOf(valor) retorna el índice de la primera ocurrencia del valor dentro del string.
            Console.WriteLine(pruebasDeStrings.IndexOf('a'));
            
            //Insert(índice, valor) inserta el valor dentro del "string" comenzando desde el índice especificado.
            pruebasDeStrings = pruebasDeStrings.Insert(0,"Hey ");
            Console.WriteLine(pruebasDeStrings);
            
            //Replace(viejoValor, nuevoValor) reemplaza el valor especificado en el "string"
            pruebasDeStrings = pruebasDeStrings.Replace("Hey ", "Oye!! ");
            Console.WriteLine(pruebasDeStrings);
            
            //Contains(valor) retorna tru (verdadero) si el string contiene el valor especificado.
            if (pruebasDeStrings.Contains("alegria"))
                Console.WriteLine("Felicidad");
            
            //Remove(índice) remueve todos los caracteres en el string después del índice especificado.
            pruebasDeStrings = pruebasDeStrings.Remove(4);
            Console.WriteLine(pruebasDeStrings);
            
            //Substring(índice, longitud) retorna un substring de la longitud especificada, comenzando desde el
            // * índice especificado. Si la longitud no es especificada, la operación continúa hasta el final del 
            // * string
            pruebasDeStrings = pruebasDeStrings.Substring(2);
            Console.WriteLine(pruebasDeStrings);

            //También se puede acceder caracteres de un string por su índice:
            string hola = "Hola mundo!";
            Console.WriteLine(hola[3]);

            //Ejemplo en un texto:
            string texto = "Que diosito te perdone porque yo no lo voy hacer. Tu eres el amor de mi vida. Hacer es la mejor forma de decir. Viviendo con amor.";
            texto = texto.Replace("amor","taco");
            texto = texto.Substring(0, texto.IndexOf(".") + 1);
            Console.WriteLine(texto);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}