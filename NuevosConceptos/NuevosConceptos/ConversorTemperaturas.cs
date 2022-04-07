using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public static class ConversorTemperaturas
    {
        const double constante = 2.12;

        public static double ConversorAFahrenheit(double gradosCelsius) //12
        {
            return gradosCelsius * constante;
        }

        public static double ConversorACelsius(double gradosFahrenheit)
        {
            return gradosFahrenheit / constante;
        }
    }
}
