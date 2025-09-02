using System;

namespace TuplaParaDevolverValoresDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int num1, int num2, int resultado) RestaTupla; // se declara la tupla

            RestaTupla=Restar(); // lo devuelto del metodo se le asigna a la tupla
             
            Console.WriteLine("{0}-{1}= {2}",RestaTupla.num1, RestaTupla.num2,RestaTupla.resultado);

        }
        static (int,int,int) Restar() { // Aqui se declaran el tipo de datos de los campos
           
            int a, b, resta;
            Console.WriteLine("Ingrese un num");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un num");
            b = Convert.ToInt32(Console.ReadLine());

            resta = a - b;
            return (a, b, resta); //se devuelven los campos
        }
    }
}
