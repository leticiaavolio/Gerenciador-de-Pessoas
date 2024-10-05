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
            lblNome = new Label();
            lblIdade = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnCriar = new Button();
            btnSalvar = new Button();
            lblMensagem = new Label();
            lstPessoas = new ListBox();
            btnVer = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ActiveBorder;
            lblNome.BorderStyle = BorderStyle.FixedSingle;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.WindowFrame;
            lblNome.Location = new Point(163, 220);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = SystemColors.ActiveBorder;
            lblIdade.BorderStyle = BorderStyle.FixedSingle;
            lblIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.WindowFrame;
            lblIdade.Location = new Point(163, 270);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(60, 23);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ScrollBar;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.WindowFrame;
            txtNome.Location = new Point(247, 210);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 33);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.ScrollBar;
            txtIdade.BorderStyle = BorderStyle.FixedSingle;
            txtIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.ForeColor = SystemColors.WindowFrame;
            txtIdade.Location = new Point(247, 260);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(79, 33);
            txtIdade.TabIndex = 3;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = SystemColors.ActiveBorder;
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.FlatAppearance.BorderColor = Color.DimGray;
            btnCriar.FlatAppearance.BorderSize = 2;
            btnCriar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriar.ForeColor = SystemColors.WindowFrame;
            btnCriar.Location = new Point(163, 317);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(121, 33);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "&Criar Pessoa";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveBorder;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderColor = Color.DimGray;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.WindowFrame;
            btnSalvar.Location = new Point(416, 317);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 33);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "&Salvar Pessoa";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = SystemColors.ActiveBorder;
            lblMensagem.BorderStyle = BorderStyle.FixedSingle;
            lblMensagem.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.WindowFrame;
            lblMensagem.Location = new Point(572, 434);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(2, 23);
            lblMensagem.TabIndex = 6;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(572, 205);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(441, 184);
            lstPessoas.TabIndex = 7;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.ActiveBorder;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderColor = Color.DimGray;
            btnVer.FlatAppearance.BorderSize = 2;
            btnVer.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.WindowFrame;
            btnVer.Location = new Point(292, 317);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(118, 33);
            btnVer.TabIndex = 8;
            btnVer.Text = "&Ver Detalhes";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.DimGray;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.Window;
            btnExcluir.Location = new Point(163, 356);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(194, 33);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Red;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = Color.DimGray;
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.Window;
            btnLimpar.Location = new Point(363, 356);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(188, 33);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = " &Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 662);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVer);
            Controls.Add(lstPessoas);
            Controls.Add(lblMensagem);
            Controls.Add(btnSalvar);
            Controls.Add(btnCriar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Gerenciador de Pessoa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblIdade;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnCriar;
        private Button btnSalvar;
        private Label lblMensagem;
        private ListBox lstPessoas;
        private Button btnVer;
        private Button btnExcluir;
        private Button btnLimpar;
    }
}