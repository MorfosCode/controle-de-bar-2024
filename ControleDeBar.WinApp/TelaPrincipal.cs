using ControleDeBar.WinApp.ModuloCompartilhado;
using ControleDeBar.WinApp.ModuloProduto;

namespace ControleDeBar.WinApp
{
    public partial class TelaPrincipal : Form
    {
        ControladorBase controlador;

        public TelaPrincipal()
        {
            InitializeComponent();

            lblTipoOperacao.Text = string.Empty;
        }

        #region Eventos de menuItem
        
        private void garconMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Adicionar Garçon";
            btnEditar.ToolTipText = "Editar Garçon";
            btnExcluir.ToolTipText = "Excluir Garçon";
        }

        private void mesaMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Adicionar Mesa";
            btnEditar.ToolTipText = "Editar Mesa";
            btnExcluir.ToolTipText = "Excluir Mesa";
        }

        //////////////////////////////////////////////////////////////
        private void produtoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto();

            lblTipoOperacao.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }
        
        #endregion

        #region Eventos de botões
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        #endregion

        #region Configura os testos de toolTips de acordo com a seleção do usuário
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }
        #endregion

        #region Configura a listagem que deve aparecer de acordo com a seleção do usuário
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemProduto = controlador.ObterListagem();
            listagemProduto.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(listagemProduto);
        }
        #endregion
    }
}
