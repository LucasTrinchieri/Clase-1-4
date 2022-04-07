using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public static class Rectangulo
    {
        public static int Area(int alto, int largo) //15
        {
            return alto * largo;
        }

        public static int Perietro(int alto, int largo)
        {
            return alto * 2 + largo * 2;
        }
    }
}
