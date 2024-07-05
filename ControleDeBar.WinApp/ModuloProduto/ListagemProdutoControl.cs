using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControladorDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.WinApp.ModuloProduto
{
    public partial class ListagemProdutoControl : UserControl
    {
        public ListagemProdutoControl()
        {
            InitializeComponent();

            listBoxProdutos.Items.Add(new Produto("Campari 1l", 1));
        }
    }
}
