using System.Text.RegularExpressions;

namespace NuevosConceptos
{
    public static class Principal
    {
        public static int SepararPalabras(this string stringIngresado) //1
        {
            return stringIngresado.Split(' ').Length;
        }

        public static int SepararPalabras(this string stringIngresado, char separador) //2
        {
            return stringIngresado.Split(separador).Length;
        }

        public static decimal DiferenciaEntreFechas(this DateTime fechaPrimera, DateTime fechaSegunda) //3
        {
            return (fechaPrimera.Second - fechaSegunda.Second) / 60;
        }

        public static double Promedio(this List<int> listaEnteros) //4
        {
            return listaEnteros.Average();
        }
        public static int MultiplicacionLista(this List<int> listaEnteros) //5
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

        public static DateTime RetornarStringComoFecha(this string stringIngresado) //6
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

        public static string Invertido(this string stringInvertido) //7
        {
            return stringInvertido.Reverse().ToString();
        }

        public static string UnionStrings(this string[] arrayString, char separadorChar) //8
        {
            return string.Join(separadorChar, arrayString);
        }

        public static bool EsCorreo(this string posibleCorreo) //9
        {
            string patron = @"^\w+[@]\w+[.]\w{2,}$";

            return Regex.IsMatch(posibleCorreo, patron);
        }

        public static bool EsCUIT(this string posibleCUIT) //10
        {
            string patron = @"^\d{2}-\d+-\d$";

            return Regex.IsMatch(posibleCUIT, patron);
        }

        //11

        public static Cliente DevolverSaldoCliente(Cliente primerCliente, Cliente segundoCliente)
        {
            return primerCliente - segundoCliente;
        }

        public static int RestaEnteros(this int numeroPrimero, int numeroSegundo)
        {
            return numeroPrimero - numeroSegundo;
        }
    }
}