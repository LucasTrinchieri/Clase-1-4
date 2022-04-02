namespace NuevosConceptos
{
    public static class Estatica
    {
        public static int SepararPalabras(this string stringIngresado)
        {
            return stringIngresado.Split(' ').Length;
        }

        public static int SepararPalabras(this string stringIngresado, char separador)
        {
            return stringIngresado.Split(separador).Length;
        }

        public static decimal DiferenciaEntreFechas(this DateTime fechaPrimera, DateTime fechaSegunda)
        {
            return (fechaPrimera.Second - fechaSegunda.Second) / 60;
        }

        public static double Promedio(this List<int> listaEnteros)
        {
            return listaEnteros.Average();
        }
        public static int MultiplicacionLista(this List<int> listaEnteros)
        {
            int pares = 0;
            int impares = 0;

            foreach (int entero in listaEnteros)
            {
                if(entero % 2 == 0)
                {
                    pares += entero;
                }
                else { impares -= entero; }
            }

            return pares * impares;
        }

        public static DateTime RetornarStringComoFecha(this string stringIngresado)
        {
            try
            {
                return DateTime.Parse(stringIngresado);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public static string Invertido(this string stringINvertido)
        {
            return stringINvertido; //Mal
        }
    }
}