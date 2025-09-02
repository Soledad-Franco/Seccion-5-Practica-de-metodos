using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            decimal num1Argumento, num2Argumento;
            int restaResultado = 0;//declaramos la variable que va a contener el valor que devuelva el metodo restar           

            //declaramos las variables para dividir
            decimal num1Ar, num2Ar, resulDiv;


            Console.WriteLine("Que operacion desea ejecutar?(1.Suma, 2.resta, 3.Multiplicación, 4.division)");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    restaResultado = Restar();//se le invoca al metodo restar y a el valor que devuelve
                    Console.WriteLine("El resultado de la resta es: {0}", restaResultado);
                    break;
                case 3:


                    num1Argumento = IngresarNumero("Ingrese el primer num");
                    num2Argumento = IngresarNumero("Ingrese el segundo num");

                    Multiplicar(num1Argumento, num2Argumento); //Llamamos al metodo y entre los () ponemos a las variables con los valores que queremos pasar al metodo o argumentos.
                    break;



                case 4:

                    num1Ar = IngresarNumero("Ingrese el primer num");
                    num2Ar = IngresarNumero("Ingrese el segundo num");

                    resulDiv = Dividir(num1Ar, num2Ar);// se le pasa los argumentos al metodo dividir "Dividir(num1Ar, num2Ar)" y se devuelve un valor "resulDiv = Dividir();"
                    if (resulDiv != 0)
                    {
                        Console.WriteLine("El resultado de la división es: {0}", resulDiv);
                        break;
                    }
                    else
                    {
                        return;
                    }



            }

        }

        //metodo que no devuelve nada ni tiene un tipo, (no tiene parametros)
        static void Sumar()
        {
            int a, b, suma;
            Console.WriteLine("Ingrese un num");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un num");
            b = Convert.ToInt32(Console.ReadLine());

            suma = a + b;
            Console.WriteLine("El resultado es: {0}", suma);
        }


        //metodo que devuelve un valor 
        static int Restar()
        {
            int a, b, suma;
            Console.WriteLine("Ingrese un num");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un num");
            b = Convert.ToInt32(Console.ReadLine());

            suma = a - b;

            //para devolver un valor
            return suma;
        }


        //los parametros son variables que se crean dentro de los () de un metodo y contienen la copia del valor que se esta mandando desde Main, son variables que reciben información desde fuera
        //los argumentos son aquellas variables que envian una copia de su valor a los parametros PREUBA DOS


        //metodo con parametro que recibe un valor
        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {

            decimal resultado;
            resultado = num1Pa * num2Pa;
            Console.WriteLine("el resultado es: {0} ", resultado);
        }

        //metodo con parametro que recibe un valor y devuelve un valor
        static decimal Dividir(decimal num1, decimal num2)
        {
            decimal resultado = 0;
            if (num2 != 0)
            {
                resultado = num1 / num2;

            }
            else
            {
                Console.WriteLine("No se puede dividir con 0");

            }
            return resultado;
        }

        static decimal IngresarNumero(String peticion)
        {
            decimal num;
            Console.WriteLine(peticion);
            num = Convert.ToDecimal(Console.ReadLine());
            return num;
        }
    }
}
