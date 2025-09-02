using System;
using System.ComponentModel;


namespace PasarporvalorVsPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAr = 20;
            Console.WriteLine("Valor argumento: {0}", numAr);
            Valor(ref numAr);// aca invocamos al metodo y le pasamos los argumentos
            Console.WriteLine("Valor argumento: {0}", numAr);

        }
        static void Valor(ref int numPa)
        {
            numPa = 30;

        }
    }
}
