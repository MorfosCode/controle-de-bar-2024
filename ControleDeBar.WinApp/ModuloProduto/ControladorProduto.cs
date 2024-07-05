using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeBar.WinApp.ModuloCompartilhado;

namespace ControleDeBar.WinApp.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        public override string TipoCadastro { get { return "Produtos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Produto"; } }

        public override string ToolTipEditar { get { return "Editar Produto"; } }

        public override string ToolTipExcluir { get { return "Excluir Produto"; } }

        public override UserControl ObterListagem()
        {
            return new ListagemProdutoControl();
        }

        public override void Adicionar()
        {
            TelaProdutoForm telaProdutoForm = new TelaProdutoForm();
            DialogResult result = telaProdutoForm.ShowDialog();

            if ( result == DialogResult.OK )
            {
                MessageBox.Show("Informação slava com sucesso!");
            }
        }
    }
}
