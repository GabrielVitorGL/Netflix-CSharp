namespace Netflix
{
    partial class Settings
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
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmigo = new System.Windows.Forms.TextBox();
            this.btnAdicionarAmigo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.lblJaTemConta = new System.Windows.Forms.Label();
            this.lstAmigos = new System.Windows.Forms.ListBox();
            this.btnExcluirAmigo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(969, 62);
            this.lblConfiguracoes.TabIndex = 3;
            this.lblConfiguracoes.Text = "Configurações";
            this.lblConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblJaTemConta);
            this.groupBox1.Controls.Add(this.lstAmigos);
            this.groupBox1.Location = new System.Drawing.Point(59, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 562);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações gerais";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcluirAmigo);
            this.groupBox3.Controls.Add(this.txtAmigo);
            this.groupBox3.Controls.Add(this.btnAdicionarAmigo);
            this.groupBox3.Location = new System.Drawing.Point(32, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 171);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Amigo";
            // 
            // txtAmigo
            // 
            this.txtAmigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtAmigo.Location = new System.Drawing.Point(34, 51);
            this.txtAmigo.Name = "txtAmigo";
            this.txtAmigo.Size = new System.Drawing.Size(347, 20);
            this.txtAmigo.TabIndex = 21;
            this.txtAmigo.Text = "Email do seu amigo";
            this.txtAmigo.Enter += new System.EventHandler(this.txtAmigo_Enter);
            this.txtAmigo.Leave += new System.EventHandler(this.txtAmigo_Leave);
            // 
            // btnAdicionarAmigo
            // 
            this.btnAdicionarAmigo.Location = new System.Drawing.Point(205, 102);
            this.btnAdicionarAmigo.Name = "btnAdicionarAmigo";
            this.btnAdicionarAmigo.Size = new System.Drawing.Size(176, 40);
            this.btnAdicionarAmigo.TabIndex = 7;
            this.btnAdicionarAmigo.Text = "Adicionar amigo";
            this.btnAdicionarAmigo.UseVisualStyleBackColor = true;
            this.btnAdicionarAmigo.Click += new System.EventHandler(this.btnAdicionarAmigo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluirConta);
            this.groupBox2.Controls.Add(this.btnAlterarDados);
            this.groupBox2.Location = new System.Drawing.Point(32, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 290);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações da conta";
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Location = new System.Drawing.Point(45, 200);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(336, 46);
            this.btnExcluirConta.TabIndex = 6;
            this.btnExcluirConta.Text = "Excluir conta";
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Location = new System.Drawing.Point(45, 87);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(336, 46);
            this.btnAlterarDados.TabIndex = 6;
            this.btnAlterarDados.Text = "Alterar dados cadastrais";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            // 
            // lblJaTemConta
            // 
            this.lblJaTemConta.AutoSize = true;
            this.lblJaTemConta.Location = new System.Drawing.Point(502, 31);
            this.lblJaTemConta.Name = "lblJaTemConta";
            this.lblJaTemConta.Size = new System.Drawing.Size(67, 13);
            this.lblJaTemConta.TabIndex = 20;
            this.lblJaTemConta.Text = "Seus amigos";
            // 
            // lstAmigos
            // 
            this.lstAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAmigos.FormattingEnabled = true;
            this.lstAmigos.ItemHeight = 20;
            this.lstAmigos.Location = new System.Drawing.Point(505, 56);
            this.lstAmigos.Name = "lstAmigos";
            this.lstAmigos.Size = new System.Drawing.Size(336, 484);
            this.lstAmigos.TabIndex = 8;
            // 
            // btnExcluirAmigo
            // 
            this.btnExcluirAmigo.Location = new System.Drawing.Point(34, 102);
            this.btnExcluirAmigo.Name = "btnExcluirAmigo";
            this.btnExcluirAmigo.Size = new System.Drawing.Size(118, 40);
            this.btnExcluirAmigo.TabIndex = 22;
            this.btnExcluirAmigo.Text = "Excluir amigo";
            this.btnExcluirAmigo.UseVisualStyleBackColor = true;
            this.btnExcluirAmigo.Click += new System.EventHandler(this.btnExcluirAmigo_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConfiguracoes);
            this.Name = "Settings";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarAmigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.ListBox lstAmigos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmigo;
        private System.Windows.Forms.Label lblJaTemConta;
        private System.Windows.Forms.Button btnExcluirAmigo;
    }
}