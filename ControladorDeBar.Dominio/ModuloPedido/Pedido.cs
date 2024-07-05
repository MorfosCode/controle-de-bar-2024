using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDeBar.Dominio.ModuloPedido
{
    internal class Pedido
    {
        public int Quantidade { get; set; }

        public ModuloProduto.Produto Produto
        {
            get => default;
            set
            {
            }
        }
    }
}
