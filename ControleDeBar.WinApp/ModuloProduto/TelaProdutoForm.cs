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
    public partial class TelaProdutoForm : Form
    {
        public TelaProdutoForm()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxDescricao.Clear();
            textBoxPrecoProduto.Clear();
            textBoxDescricao.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (!ValidarCampo())
                {
                    DialogResult = DialogResult.None;

                    break;
                }

                string descricao = textBoxDescricao.Text;

                decimal precoProduto = Convert.ToDecimal(textBoxPrecoProduto);

                Produto produto = new Produto(descricao, precoProduto);

                break;
            }
        }

        private bool ValidarCampo()
        {
            if( textBoxDescricao.Text == "")
            {
                MessageBox.Show("O campo \"DESCRIÇÃO\" deve ser preenchido!");
                textBoxDescricao.Focus();

                return false;
            }

            if ( textBoxPrecoProduto.Text == "")
            {
                MessageBox.Show("O campo \"PREÇO DO PRODUTO\" deve ser preenchido!");
                textBoxPrecoProduto.Focus();

                return false;
            }

            return true;
        }
    }
}
