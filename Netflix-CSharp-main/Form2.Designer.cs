
namespace Netflix
{
    partial class Form2
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
            this.lstFilmes = new System.Windows.Forms.ListBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFilmes
            // 
            this.lstFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFilmes.FormattingEnabled = true;
            this.lstFilmes.ItemHeight = 20;
            this.lstFilmes.Location = new System.Drawing.Point(391, 180);
            this.lstFilmes.Name = "lstFilmes";
            this.lstFilmes.Size = new System.Drawing.Size(523, 424);
            this.lstFilmes.TabIndex = 0;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Comédia",
            "Romance",
            "Suspense",
            "Malucos",
            "Terror",
            "Drama",
            "Ação/Ficção/Fantasia/Policial",
            "Documentário"});
            this.cboGenero.Location = new System.Drawing.Point(79, 180);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(225, 28);
            this.cboGenero.TabIndex = 1;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBemVindo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(0, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(969, 62);
            this.lblBemVindo.TabIndex = 2;
            this.lblBemVindo.Text = "Bem vindo!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAssistir
            // 
            this.btnAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistir.Location = new System.Drawing.Point(79, 556);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(192, 48);
            this.btnAssistir.TabIndex = 3;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = true;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(7, 74);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(950, 39);
            this.lblEscolha.TabIndex = 4;
            this.lblEscolha.Text = "Escolha um gênero e um filme de seu interesse:";
            this.lblEscolha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackgroundImage = global::Netflix.Properties.Resources.settings;
            this.btnConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguracoes.ImageKey = "(nenhum/a)";
            this.btnConfiguracoes.Location = new System.Drawing.Point(14, 12);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(69, 65);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(907, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 32);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 661);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lstFilmes);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFilmes;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnAssistir;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSair;
    }
}