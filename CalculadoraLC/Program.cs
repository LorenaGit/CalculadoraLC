using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Uno:");//capturando datos por consola
            short nUno = short.Parse(Console.ReadLine());

            Console.WriteLine("Numero Dos:");
            short nDos = short.Parse(Console.ReadLine());

           // Operaciones realizarOperacion = new Operaciones();
            var realizarOperacion = new Operaciones();// esto es igual al imstaciar un objeto de una clase cualquiera

            realizarOperacion.numUno = nUno;
            realizarOperacion.numDos = nDos;

            //forma de mostrar los atributos de la clase
            Console.WriteLine(realizarOperacion.numUno + " y " + realizarOperacion.numDos);

            //invocar los metodos
            realizarOperacion.sumar(realizarOperacion.numUno, realizarOperacion.numDos);
            Console.ReadLine();
           

            // realizarOperacion.sumar(nUno, nDos);
        }
    }
}
