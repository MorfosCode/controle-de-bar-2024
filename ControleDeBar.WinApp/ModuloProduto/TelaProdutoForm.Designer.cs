namespace ControleDeBar.WinApp.ModuloProduto
{
    partial class TelaProdutoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDescricao = new Label();
            textBoxDescricao = new TextBox();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            buttonCancel = new Button();
            labelId = new Label();
            textBoxId = new TextBox();
            label1 = new Label();
            textBoxPrecoProduto = new TextBox();
            SuspendLayout();
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescricao.Location = new Point(12, 73);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(112, 25);
            labelDescricao.TabIndex = 100;
            labelDescricao.Text = "DESCRIÇÃO:";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.CharacterCasing = CharacterCasing.Upper;
            textBoxDescricao.Font = new Font("Microsoft Sans Serif", 10.8F);
            textBoxDescricao.Location = new Point(127, 70);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(350, 28);
            textBoxDescricao.TabIndex = 0;
            // 
            // buttonSalvar
            // 
            buttonSalvar.AutoSize = true;
            buttonSalvar.DialogResult = DialogResult.OK;
            buttonSalvar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(165, 172);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 35);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.AutoSize = true;
            buttonLimpar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLimpar.Location = new Point(274, 172);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(94, 35);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(383, 172);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 35);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelId.Location = new Point(90, 23);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 25);
            labelId.TabIndex = 100;
            labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(127, 22);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 120);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 101;
            label1.Text = "PREÇO:";
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Font = new Font("Microsoft Sans Serif", 10.8F);
            textBoxPrecoProduto.Location = new Point(127, 118);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(100, 28);
            textBoxPrecoProduto.TabIndex = 1;
            textBoxPrecoProduto.TextAlign = HorizontalAlignment.Right;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 230);
            Controls.Add(textBoxPrecoProduto);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(labelId);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxDescricao);
            Controls.Add(labelDescricao);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaProdutoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SISTEMA GERENCIADOR DE BAR - Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDescricao;
        private TextBox textBoxDescricao;
        private Button buttonSalvar;
        private Button buttonLimpar;
        private Button buttonCancel;
        private Label labelId;
        private TextBox textBoxId;
        private Label label1;
        private TextBox textBoxPrecoProduto;
    }
}