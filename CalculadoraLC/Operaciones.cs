using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLC
{
   public class Operaciones
    {
        //Atributos
        public short numUno;
        public short numDos;

        //Metodos
        
        public void sumar(int numeroUno, int numeroDos)
        {
            int suma = 0;
             suma = numeroUno + numeroDos;
            Console.WriteLine("la suma es: " + suma);
        }
        
    }
}
