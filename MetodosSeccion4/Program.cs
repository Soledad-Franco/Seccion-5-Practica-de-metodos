
using System;
namespace MetodosSeccion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            Console.WriteLine(a);
            ROut(out a); // out se usa para pasar un argumento a un parametro y que esete metodo devuelva el nuevo valor del argumento pero sin usar return;
            Console.WriteLine(a);
        }
        static void ROut(out int ap) {
            ap = 10;
        }
    }
}
