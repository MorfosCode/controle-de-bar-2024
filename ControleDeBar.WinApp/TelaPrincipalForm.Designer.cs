namespace ControleDeBar.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            fncionarioToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            mesasToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPagar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnRelatorio = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusLabelPrincipal = new StatusStrip();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fncionarioToolStripMenuItem, produtosToolStripMenuItem, mesasToolStripMenuItem, pedidosToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(84, 25);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // fncionarioToolStripMenuItem
            // 
            fncionarioToolStripMenuItem.Name = "fncionarioToolStripMenuItem";
            fncionarioToolStripMenuItem.Size = new Size(162, 26);
            fncionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(162, 26);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // mesasToolStripMenuItem
            // 
            mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            mesasToolStripMenuItem.Size = new Size(162, 26);
            mesasToolStripMenuItem.Text = "Mesas";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(162, 26);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, btnVisualizar, toolStripSeparator2, btnPagar, toolStripSeparator3, btnRelatorio, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Text = "btnAdicionar";
            btnAdicionar.ToolTipText = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Text = "btnEditar";
            btnEditar.ToolTipText = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Text = "btnExcluir";
            btnExcluir.ToolTipText = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.btnFiltrar1;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(5);
            btnFiltrar.Size = new Size(38, 38);
            btnFiltrar.Text = "btnFiltrar";
            btnFiltrar.ToolTipText = "Filtrar";
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Image = Properties.Resources.btnFiltrar;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(5);
            btnVisualizar.Size = new Size(38, 38);
            btnVisualizar.Text = "btnVisualizar";
            btnVisualizar.ToolTipText = "Visualizar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnPagar
            // 
            btnPagar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPagar.Enabled = false;
            btnPagar.Image = Properties.Resources.btnPagar;
            btnPagar.ImageScaling = ToolStripItemImageScaling.None;
            btnPagar.ImageTransparentColor = Color.Magenta;
            btnPagar.Name = "btnPagar";
            btnPagar.Padding = new Padding(5);
            btnPagar.Size = new Size(38, 38);
            btnPagar.Text = "btnPagar";
            btnPagar.ToolTipText = "Pagar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnRelatorio
            // 
            btnRelatorio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRelatorio.Image = Properties.Resources.btnRelatorio;
            btnRelatorio.ImageScaling = ToolStripItemImageScaling.None;
            btnRelatorio.ImageTransparentColor = Color.Magenta;
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Padding = new Padding(5);
            btnRelatorio.Size = new Size(38, 38);
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.ToolTipText = "Relatorio";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Location = new Point(0, 428);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(800, 22);
            statusLabelPrincipal.TabIndex = 2;
            statusLabelPrincipal.Text = "statusStrip1";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 70);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 358);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(statusLabelPrincipal);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem fncionarioToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem mesasToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnPagar;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnVisualizar;
        private ToolStripButton btnRelatorio;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel lblTipoCadastro;
        private StatusStrip statusLabelPrincipal;
        private Panel pnlRegistros;
    }
}
