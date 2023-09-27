using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07QueueExemplo
{
    internal class Pedido
    {
        public int NumeroPedido { get; set; }
        public double Valor { get; set; }

        public Pedido(int pedido, double preco)
        {
            NumeroPedido = pedido;
            Valor = preco;
        }
    }
}
