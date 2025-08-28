using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSeccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op,num1Argumento,num2Argumento;
            int restaResultado = 0;//declaramos la variable que va a contener el valor que se devuelva del metodo restar

            Console.WriteLine("Que operacion desea ejecutar?(1.Suma, 2.resta, 3.Multiplicación, 4.division)");
            op=Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case 1:
                    Sumar();
                    break;
                case 2:
                    restaResultado = Restar();
                    Console.WriteLine("El resultado de la resta es: ", restaResultado);
                    break;
                case3:
                    Console.WriteLine("Ingrese un num");
                    num1Argumento = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese un num");
                    num2Argumento = Convert.ToInt32(Console.ReadLine());
                    break;
            
            }
            
        }

        //metodo que no devuelve nada ni tiene un tipo, (no tiene parametros)
        static void Sumar()
        {
            int a, b,suma;
            Console.WriteLine("Ingrese un num");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un num");
            b = Convert.ToInt32(Console.ReadLine());

            suma=a+b;
            Console.WriteLine("El resultado es: ",suma);
        }


        //metodo que devuelve un valor 
        static int Restar () {
            int a, b, suma;
            Console.WriteLine("Ingrese un num");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un num");
            b = Convert.ToInt32(Console.ReadLine());

            suma = a - b;

            //para devolver un valor
            return suma;
        }

        //metodo con parametro
        //los parametros son variables que se crean dentro de los () de un metodo y contienen la copia del valor que se esta mandando desde Main, son variables que reciben información desde fuera

        //los argumentos son aquellas variables que envian una copia de su valor a los parametros PREUBA DOS

        

    }
}
