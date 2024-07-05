using ControleDeBar.WinApp.ModuloProduto;

namespace ControleDeBar.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void garconMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Adicionar Garçon";
            btnEditar.ToolTipText = "Editar Garçon";
            btnExcluir.ToolTipText = "Excluir Garçon";
        }

        private void produtoMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Adicionar Produto";
            btnEditar.ToolTipText = "Editar Produto";
            btnExcluir.ToolTipText = "Excluir Produto";

            ListagemProdutoControl listagemProduto = new ListagemProdutoControl();
            listagemProduto.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(listagemProduto);
        }

        private void mesaMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Adicionar Mesa";
            btnEditar.ToolTipText = "Editar Mesa";
            btnExcluir.ToolTipText = "Excluir Mesa";
        }
    }
}
