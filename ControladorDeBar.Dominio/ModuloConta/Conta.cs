using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControladorDeBar.Dominio.ModuloGarcon;
using ControladorDeBar.Dominio.ModuloMesa;
using ControladorDeBar.Dominio.ModuloPedido;

namespace ControladorDeBar.Dominio.ModuloConta
{
    internal class Conta
    {
        List<Pedido> Pedidos {  get; set; }

        public Mesa Mesa
        {
            get;
            set;
        }

        public Garcom Garcom
        {
            get;
            set;
        }
    }
}
