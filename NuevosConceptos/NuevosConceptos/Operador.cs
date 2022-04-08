using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public class Operador //EXCELENTE!!
    {
        public int Numero { get; set; }
        public static decimal operator /(Operador numeroPrimero, Operador numeroSegundo) //14
        {
            Operador resultado = new Operador();

            resultado.Numero = numeroPrimero.Numero / numeroSegundo.Numero;

            return (decimal)resultado.Numero;
        }
    }
}
