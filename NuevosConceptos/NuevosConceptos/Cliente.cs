using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevosConceptos
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public uint CUIT { get; set; }
        public double Saldo { get; set; }

        public static Cliente operator -(Cliente primerCliente, Cliente segundoCliente)
        {
            Cliente clienteResultante = new Cliente();

            if (primerCliente.CUIT == segundoCliente.CUIT)
                clienteResultante.Saldo = primerCliente.Saldo - segundoCliente.Saldo;

            clienteResultante.Saldo = primerCliente.CUIT == segundoCliente.CUIT ?
                                      primerCliente.Saldo - segundoCliente.Saldo :
                                      Math.Min(primerCliente.Saldo, segundoCliente.Saldo);

            return clienteResultante;
        }
    }
}
