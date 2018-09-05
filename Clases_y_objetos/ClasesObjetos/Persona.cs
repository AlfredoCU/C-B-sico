using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /*Esto es una clase y es la definición de un objeto. El conjunto de características y acciones de una
     * persona seria la clase y el objeto es la persona en sí. Otro ejemplo es ver a la clase como los planos de
     * diseño de un edificio y el objeto es cuando se ésta contruyendo y se puede tomar esos mismos planos para 
     * hacer más edificios es decir más objetos de la misma clase.
     */

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class Persona
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Estos son atributos de un objeto (característica).
         * Tipos por valor -> Stack (variables, dirreciones de memoria de un objeto). -> Memoria estatica.
         * Tipos refenciados -> Heap (Objetos). ->Memoria dinamica.
         */

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Encapsulación -> "public", "private, "protected" y "internal" son modificadores de acceso.
         * public: Puede ser manipulado fuera de la clase y es visible al exterior.
         * private: Sólo puede ser manipulado  dentro de la clase y se oculta del exteriro.
         * Protected: Puede ser utilizado en su clase y unicamente en clase heredada.
         * internal: Es un modificador de acceso para tipos y tipos de miembros.
         *           Miembros internos solo son accesibles dentro de los archivos en el mismo ensamblaje.
         */

        //pueden ser cualquier modificacor de acceso como: public, protected, etc; 

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Atributos.
        public string apodo;
        private string nombre;
        private string apellido;
        private int edad;
        private double peso;
        private double estatura;
        private string colorCabello;
        private string colorOjos;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Métodos.
        public void Hablar()
        {
            Console.WriteLine("Hola mundo!");
        }

        public int Correr(int kilometros)
        {
            return kilometros;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Constructor vacio, es siempre recomendable tener 2 constructore, 1 para inicializar los valores y otro
        //vacio por si es necesario utilizar.

        //Siempre son publicos los constructores y este es uno vacio:
        public Persona() { }

        //Se pueden inicializar el valor de los atributos de esta forma:
        public Persona(string nom, string ap, int eda)
        {
            apodo = " "; //Este es la forma más de me vale madre!
            nombre = nom;
            apellido = ap;
            edad = eda;
        }

        //Tambíen utilizando "This" mantienes el mismo nombre del atributo, pero sabiendo que "this.edad" se 
        //refiere al atributo y "edad" al parametro del constructor.
        public Persona(double peso, double estatura, string colorCabello, string colorOjos)
        {
            this.peso = peso;
            this.estatura = estatura;
            this.colorCabello = colorCabello;
            this.colorOjos = colorOjos;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Prodiedades provee un mecanismo flexible para leer, escribir, o computear un valor en un campo privado.
         * Descriptores de acceso (accessors) son: "get" (leer) y "set" (escribir).
         * Para poder utilizar los atrivutos privados, el "get" y "set" nos ayuda a tener una comunicación
         * dentro y fuera de la clase.
         * El descriptor de acceso "set" es utilizado para asignar un valor a la variable, mientras que "get"
         * es utilizado para retornar su valor.
         */

        //En C++ Y C# se escriben normalmente así:
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nom)
        {
            nombre = nom;
        }

        //Pero en C# se pueden simplificar de esta forma:
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; } //"value" es una palabra clave especial que representa el valor que asignamos
        }                             //a una propiedad utilizando el descriptor de acceso set.

        //Puedes tener cualquier lógica personalizada con los descriptores "get" y "set".
        public int Edad
        {
            get { return edad; }
            set {if (value > 0)
                    edad = value;
            }
        }
        
        //Se puede escribir en una sóla linea de código.
        public double Peso { get { return peso; } set { peso = value; } }
        public double Estatura { get { return estatura; } set { estatura = value; } }
        public string ColorCabello { get { return colorCabello; } set { colorCabello = value; } }
        public string ColorOjos { get { return colorOjos; } set { colorOjos = value; } }

        /*Propiedades auto-implementadas: C# provee un mecanismo rápido y efectivo para declara miembros privados
         * a través de sus propiedades.
         * No necesitas declarar el campo privado:
         */
         public string ColorPiel { get; set; } //Observa que ColorPiel no esta declarado arriba!

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

