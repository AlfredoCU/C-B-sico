using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales_y_Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //La declaración if-else.
            //La declaración if.
            int x = 10, y = 7;
            if(x > y) 
            {
                Console.WriteLine("X es mayo a Y");
            }
            //Operadores relacionales.
            if(x != y) // >= <= == != 
            {
                Console.WriteLine("X es diferente a Y");
            }
            //La cláusula else.
            int z = 50;
            if(z > 100)
            {
                Console.WriteLine("Z es mayor que 100");
            }
            else
            {
                Console.WriteLine("Z es menor que 100");
            }
            //Declaraciones if anidadas.
            int dinero = 757;
            if (dinero > 700)
            {
                Console.WriteLine("Dinero es mayor a $700");
                if(dinero < 900)
                {
                    Console.WriteLine("Dinero es menor a $900");
                }
                else
                {
                    Console.WriteLine("Dinero es mayor a $900");
                }
            }
            else
            {
                Console.WriteLine("Dinero es menor a $700");
                if(dinero <= 500)
                {
                    Console.WriteLine("Dinero es menor o igual $500");
                }
                else
                {
                    Console.WriteLine("Dinero es mayor a $500");
                }
            }
            //Declaración if, else if, else.
            int calificacion = 100;
            if(calificacion == 70)
            {
                Console.WriteLine("Calificación es 70");
            }
            else if(calificacion == 80)
            {
                Console.WriteLine("Calificación es 80");
            }
            else if(calificacion == 90)
            {
                Console.WriteLine("Calificación es 90");
            }
            else if(calificacion == 100)
            {
                Console.WriteLine("Calificación es 100");
            }
            else
            {
                Console.WriteLine("Calificación esta entre 0 a 70 o esta fuera del rango");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //La declaraciòn switch.
            char opc; // switch puedes tomar cualquier tipo de dato.
            Console.Write("\nLas Opciones son 1,2,3: ");
            opc = Convert.ToChar(Console.ReadLine());
            switch (opc) {
                case '1': //case es la opción que se desea.
                    Console.WriteLine("Eres el mejor!");
                    break; //break ayuda a detener el flujo del programa.
                case '2':
                    Console.WriteLine("Vamos tu puedes!");
                    break;
                case '3':
                    Console.WriteLine("Logra tus metas!");
                    break;
                default: //degault es la opción invalida! es la que no se encuetra en el rango de case.
                    Console.WriteLine("No te rindas eres el mejor!");
                    break;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //El bucle while.
            int num = 0;
            Console.WriteLine("\nWhile");
            while (num <= 10) //while se ejecuta cuando es verdadera la condición.
            {
                Console.Write(num + ", ");
                num++;
            }
            Console.WriteLine();
            num = 0;
            while (++num < 6) //Se ejecutara 5 veces.
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            num = 0;
            while (num++ < 6) //Se ejecuta 6 veces.
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //El bucle for.
            Console.WriteLine("\nFor");
            for (int i = 0; i <= 21; i++) //i+=3 / i-=2 / int i = 10 for(; x > 10 ;) x-=3
            {
                Console.Write(i + ", ");
            } //for se ejecuta cuando es verdadera la condición.
            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //El bucle do-while.
            int a = 0;
            Console.WriteLine("\nDo-While");
            do
            {
                Console.Write(a +", ");
                a++;
            } while (a < 5); // do-while  se ejecuta al menos una vez auque sea falso.
            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // break y continue.
            a = 0;
            Console.WriteLine("\nBreak y continue");
            while (a < 20)
            {
                if(a == 5)
                {
                    break;
                }
                Console.Write(a + ", ");
                a++;
            }
            Console.WriteLine();
            for(int b = 0; b < 20; b++)
            {
                if(b == 6)
                {
                    continue;
                }
                Console.Write(b + ", ");
            }
            Console.WriteLine("\n");
            //La declaración continue es similar a la declaración break, pero en lugar de finalizar el bucle
            //completamente, salta la iteración actual del bucle y continúa con la siguiente iteración.

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Operadores Lógicos.
            int edad = 21, dinero2 = 577;
            if (edad > 18 && dinero2 > 100)
            {
                Console.WriteLine("Que se arme la peda!");
            }
            else if (edad < 18 || dinero2 > 200)
            {
                Console.WriteLine("Puede que haya peda para ti!");
            }
            else if (!(edad >= 15))
            {
                Console.WriteLine("Eres joven ponte a estudiar!");
            }
            else
            {
                Console.WriteLine("Vamonos de fiesta!");
            }
         
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //Operador condicional.
            string mensaje;
            mensaje = (edad >= 18) ? "Vamonos a festejar!" : "Ponte a estudiar!";
            Console.WriteLine(mensaje);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
