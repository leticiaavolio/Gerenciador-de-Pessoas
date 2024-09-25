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
            btnVer = new Button();
            ldlMensagem = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.ActiveBorder;
            lblNome.BorderStyle = BorderStyle.FixedSingle;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.WindowFrame;
            lblNome.Location = new Point(206, 218);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += label1_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = SystemColors.ActiveBorder;
            lblIdade.BorderStyle = BorderStyle.FixedSingle;
            lblIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.WindowFrame;
            lblIdade.Location = new Point(206, 268);
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
            txtNome.Location = new Point(290, 208);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 33);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.ScrollBar;
            txtIdade.BorderStyle = BorderStyle.FixedSingle;
            txtIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.ForeColor = SystemColors.WindowFrame;
            txtIdade.Location = new Point(290, 258);
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
            btnCriar.Location = new Point(206, 309);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(135, 33);
            btnCriar.TabIndex = 4;
            btnCriar.Text = "&Criar Pessoa";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.ActiveBorder;
            btnVer.Cursor = Cursors.Hand;
            btnVer.FlatAppearance.BorderColor = Color.DimGray;
            btnVer.FlatAppearance.BorderSize = 2;
            btnVer.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.WindowFrame;
            btnVer.Location = new Point(459, 309);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(135, 33);
            btnVer.TabIndex = 5;
            btnVer.Text = "&Ver Pessoa";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // ldlMensagem
            // 
            ldlMensagem.AutoSize = true;
            ldlMensagem.BackColor = SystemColors.ActiveBorder;
            ldlMensagem.BorderStyle = BorderStyle.FixedSingle;
            ldlMensagem.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ldlMensagem.ForeColor = SystemColors.WindowFrame;
            ldlMensagem.Location = new Point(399, 431);
            ldlMensagem.Name = "ldlMensagem";
            ldlMensagem.Size = new Size(2, 23);
            ldlMensagem.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 662);
            Controls.Add(ldlMensagem);
            Controls.Add(btnVer);
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
        private Button btnVer;
        private Label ldlMensagem;
    }
}