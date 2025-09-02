using System;


namespace TipoDeDatoTupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(tipo de datos)identificador(valores)
            // El tipo de dato tupla sirve para guardar varios valores de distintos tipos dentro de una misma estructura
            (String, int, double) prueba = ("Cloe", 10, 12.4);

            var prueba2 = (nombre: "cloe", numero: 1223324536, 2.4f);
            // Campos 

            (String nombre, int numero, double) prueba3 = ("Cloe", 10, 12.4);

            Console.WriteLine(prueba.Item1);

            Console.WriteLine(prueba2.nombre);

        }
         
        

        
    }
}
