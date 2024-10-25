namespace PrjGerenciadorDePessoas
{
    partial class Form1
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
            lstPessoas = new ListBox();
            btnLimpar = new Button();
            btnGerar = new Button();
            pnlForm = new Panel();
            btnLimparCaixa = new Button();
            btnExcluir = new Button();
            btnVer = new Button();
            btnSalvar = new Button();
            btnCriar = new Button();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            lblIdade = new Label();
            lblNome = new Label();
            cbxTipoDoc = new ComboBox();
            label1 = new Label();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(605, 191);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(441, 184);
            lstPessoas.TabIndex = 7;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Red;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = Color.DimGray;
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.Window;
            btnLimpar.Location = new Point(879, 419);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(167, 33);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = " &Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = SystemColors.ActiveBorder;
            btnGerar.Cursor = Cursors.Hand;
            btnGerar.FlatAppearance.BorderColor = Color.DimGray;
            btnGerar.FlatAppearance.BorderSize = 2;
            btnGerar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerar.ForeColor = SystemColors.WindowFrame;
            btnGerar.Location = new Point(605, 461);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(264, 33);
            btnGerar.TabIndex = 11;
            btnGerar.Text = "&Gerar Documento";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.Gainsboro;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnLimparCaixa);
            pnlForm.Controls.Add(btnExcluir);
            pnlForm.Controls.Add(btnVer);
            pnlForm.Controls.Add(btnSalvar);
            pnlForm.Controls.Add(btnCriar);
            pnlForm.Controls.Add(txtIdade);
            pnlForm.Controls.Add(txtNome);
            pnlForm.Controls.Add(lblIdade);
            pnlForm.Controls.Add(lblNome);
            pnlForm.Location = new Point(120, 191);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(436, 261);
            pnlForm.TabIndex = 13;
            // 
            // btnLimparCaixa
            // 
            btnLimparCaixa.BackColor = Color.Red;
            btnLimparCaixa.Cursor = Cursors.Hand;
            btnLimparCaixa.FlatAppearance.BorderColor = Color.DimGray;
            btnLimparCaixa.FlatAppearance.BorderSize = 2;
            btnLimparCaixa.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparCaixa.ForeColor = SystemColors.Window;
            btnLimparCaixa.Location = new Point(26, 158);
            btnLimparCaixa.Name = "btnLimparCaixa";
            btnLimparCaixa.Size = new Size(388, 33);
            btnLimparCaixa.TabIndex = 21;
            btnLimparCaixa.Text = " Lim&par Caixa";
            btnLimparCaixa.UseVisualStyleBackColor = false;
            btnLimparCaixa.Click += btnLimparCaixa_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.DimGray;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.Window;
            btnExcluir.Location = new Point(26, 206);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(388, 33);
            btnExcluir.TabIndex = 20;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.ActiveBorder;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderColor = Color.DimGray;
            btnVer.FlatAppearance.BorderSize = 2;
            btnVer.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.WindowFrame;
            btnVer.Location = new Point(154, 110);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(118, 33);
            btnVer.TabIndex = 19;
            btnVer.Text = "&Ver Detalhes";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveBorder;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderColor = Color.DimGray;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.WindowFrame;
            btnSalvar.Location = new Point(279, 110);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 33);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "&Salvar Pessoa";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = SystemColors.ActiveBorder;
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.FlatAppearance.BorderColor = Color.DimGray;
            btnCriar.FlatAppearance.BorderSize = 2;
            btnCriar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriar.ForeColor = SystemColors.WindowFrame;
            btnCriar.Location = new Point(26, 110);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(121, 33);
            btnCriar.TabIndex = 17;
            btnCriar.Text = "&Criar Pessoa";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.ScrollBar;
            txtIdade.BorderStyle = BorderStyle.FixedSingle;
            txtIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.ForeColor = SystemColors.WindowFrame;
            txtIdade.Location = new Point(110, 53);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(304, 33);
            txtIdade.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ScrollBar;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.WindowFrame;
            txtNome.Location = new Point(110, 3);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 33);
            txtNome.TabIndex = 15;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = SystemColors.ActiveBorder;
            lblIdade.BorderStyle = BorderStyle.FixedSingle;
            lblIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.WindowFrame;
            lblIdade.Location = new Point(26, 63);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(60, 23);
            lblIdade.TabIndex = 14;
            lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ActiveBorder;
            lblNome.BorderStyle = BorderStyle.FixedSingle;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.WindowFrame;
            lblNome.Location = new Point(26, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 23);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome:";
            // 
            // cbxTipoDoc
            // 
            cbxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoDoc.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbxTipoDoc.FormattingEnabled = true;
            cbxTipoDoc.Items.AddRange(new object[] { ".TXT", ".JSON" });
            cbxTipoDoc.Location = new Point(605, 423);
            cbxTipoDoc.Name = "cbxTipoDoc";
            cbxTipoDoc.Size = new Size(264, 29);
            cbxTipoDoc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(605, 391);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 22;
            label1.Text = "Formato Relatório:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 662);
            Controls.Add(label1);
            Controls.Add(cbxTipoDoc);
            Controls.Add(pnlForm);
            Controls.Add(btnGerar);
            Controls.Add(btnLimpar);
            Controls.Add(lstPessoas);
            Name = "Form1";
            Text = "Gerenciador de Pessoa";
            Load += Form1_Load;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstPessoas;
        private Button btnLimpar;
        private Button btnGerar;
        private Panel pnlForm;
        private Button btnLimparCaixa;
        private Button btnExcluir;
        private Button btnVer;
        private Button btnSalvar;
        private Button btnCriar;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label lblIdade;
        private Label lblNome;
        private ComboBox cbxTipoDoc;
        private Label label1;
    }
}