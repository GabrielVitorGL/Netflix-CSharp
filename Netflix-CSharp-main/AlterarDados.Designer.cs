namespace Netflix
{
    partial class AlterarDados
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCartao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpPlano = new System.Windows.Forms.GroupBox();
            this.lblCanceleMudar = new System.Windows.Forms.Label();
            this.lblMesGratuitoMudar = new System.Windows.Forms.Label();
            this.lblFilmesMudar = new System.Windows.Forms.Label();
            this.lblAssistaNaTvMudar = new System.Windows.Forms.Label();
            this.lblTelasSimultaneasMudar = new System.Windows.Forms.Label();
            this.lblImagemUltraHDMudar = new System.Windows.Forms.Label();
            this.lblImagemHDMudar = new System.Windows.Forms.Label();
            this.lblPrecoMudar = new System.Windows.Forms.Label();
            this.lblMesGratuito = new System.Windows.Forms.Label();
            this.lblCancele = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblAssistirNaTv = new System.Windows.Forms.Label();
            this.lblTelasSimultaneas = new System.Windows.Forms.Label();
            this.lblImagemUltraHD = new System.Windows.Forms.Label();
            this.lblImagemHD = new System.Windows.Forms.Label();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.rdbPadrao = new System.Windows.Forms.RadioButton();
            this.rdbBasico = new System.Windows.Forms.RadioButton();
            this.lblPreco = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPlano.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(64, 574);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(165, 48);
            this.btn_Cancelar.TabIndex = 23;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.Location = new System.Drawing.Point(723, 574);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(181, 48);
            this.btnAtualizarDados.TabIndex = 22;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtValidade);
            this.groupBox1.Controls.Add(this.txtCVV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNCartao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(64, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 292);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Location = new System.Drawing.Point(139, 194);
            this.mtxtValidade.Mask = "00/00/0000";
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(166, 20);
            this.mtxtValidade.SkipLiterals = false;
            this.mtxtValidade.TabIndex = 14;
            this.mtxtValidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(139, 243);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(166, 20);
            this.txtCVV.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "CVV";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(139, 98);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(166, 20);
            this.txtCPF.TabIndex = 11;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(30, 99);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Validade";
            // 
            // txtNCartao
            // 
            this.txtNCartao.Location = new System.Drawing.Point(139, 145);
            this.txtNCartao.Name = "txtNCartao";
            this.txtNCartao.Size = new System.Drawing.Size(166, 20);
            this.txtNCartao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nº do Cartão";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(139, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(30, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // grpPlano
            // 
            this.grpPlano.Controls.Add(this.lblCanceleMudar);
            this.grpPlano.Controls.Add(this.lblMesGratuitoMudar);
            this.grpPlano.Controls.Add(this.lblFilmesMudar);
            this.grpPlano.Controls.Add(this.lblAssistaNaTvMudar);
            this.grpPlano.Controls.Add(this.lblTelasSimultaneasMudar);
            this.grpPlano.Controls.Add(this.lblImagemUltraHDMudar);
            this.grpPlano.Controls.Add(this.lblImagemHDMudar);
            this.grpPlano.Controls.Add(this.lblPrecoMudar);
            this.grpPlano.Controls.Add(this.lblMesGratuito);
            this.grpPlano.Controls.Add(this.lblCancele);
            this.grpPlano.Controls.Add(this.lblFilmes);
            this.grpPlano.Controls.Add(this.lblAssistirNaTv);
            this.grpPlano.Controls.Add(this.lblTelasSimultaneas);
            this.grpPlano.Controls.Add(this.lblImagemUltraHD);
            this.grpPlano.Controls.Add(this.lblImagemHD);
            this.grpPlano.Controls.Add(this.rdbPremium);
            this.grpPlano.Controls.Add(this.rdbPadrao);
            this.grpPlano.Controls.Add(this.rdbBasico);
            this.grpPlano.Controls.Add(this.lblPreco);
            this.grpPlano.Location = new System.Drawing.Point(475, 39);
            this.grpPlano.Name = "grpPlano";
            this.grpPlano.Size = new System.Drawing.Size(429, 488);
            this.grpPlano.TabIndex = 20;
            this.grpPlano.TabStop = false;
            this.grpPlano.Text = "Plano";
            // 
            // lblCanceleMudar
            // 
            this.lblCanceleMudar.AutoSize = true;
            this.lblCanceleMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceleMudar.ForeColor = System.Drawing.Color.Green;
            this.lblCanceleMudar.Location = new System.Drawing.Point(368, 386);
            this.lblCanceleMudar.Name = "lblCanceleMudar";
            this.lblCanceleMudar.Size = new System.Drawing.Size(19, 20);
            this.lblCanceleMudar.TabIndex = 19;
            this.lblCanceleMudar.Text = "✓";
            // 
            // lblMesGratuitoMudar
            // 
            this.lblMesGratuitoMudar.AutoSize = true;
            this.lblMesGratuitoMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesGratuitoMudar.ForeColor = System.Drawing.Color.Green;
            this.lblMesGratuitoMudar.Location = new System.Drawing.Point(368, 430);
            this.lblMesGratuitoMudar.Name = "lblMesGratuitoMudar";
            this.lblMesGratuitoMudar.Size = new System.Drawing.Size(19, 20);
            this.lblMesGratuitoMudar.TabIndex = 18;
            this.lblMesGratuitoMudar.Text = "✓";
            // 
            // lblFilmesMudar
            // 
            this.lblFilmesMudar.AutoSize = true;
            this.lblFilmesMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmesMudar.ForeColor = System.Drawing.Color.Green;
            this.lblFilmesMudar.Location = new System.Drawing.Point(368, 345);
            this.lblFilmesMudar.Name = "lblFilmesMudar";
            this.lblFilmesMudar.Size = new System.Drawing.Size(19, 20);
            this.lblFilmesMudar.TabIndex = 17;
            this.lblFilmesMudar.Text = "✓";
            // 
            // lblAssistaNaTvMudar
            // 
            this.lblAssistaNaTvMudar.AutoSize = true;
            this.lblAssistaNaTvMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistaNaTvMudar.ForeColor = System.Drawing.Color.Green;
            this.lblAssistaNaTvMudar.Location = new System.Drawing.Point(370, 301);
            this.lblAssistaNaTvMudar.Name = "lblAssistaNaTvMudar";
            this.lblAssistaNaTvMudar.Size = new System.Drawing.Size(19, 20);
            this.lblAssistaNaTvMudar.TabIndex = 16;
            this.lblAssistaNaTvMudar.Text = "✓";
            // 
            // lblTelasSimultaneasMudar
            // 
            this.lblTelasSimultaneasMudar.AutoSize = true;
            this.lblTelasSimultaneasMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelasSimultaneasMudar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelasSimultaneasMudar.Location = new System.Drawing.Point(371, 254);
            this.lblTelasSimultaneasMudar.Name = "lblTelasSimultaneasMudar";
            this.lblTelasSimultaneasMudar.Size = new System.Drawing.Size(15, 16);
            this.lblTelasSimultaneasMudar.TabIndex = 15;
            this.lblTelasSimultaneasMudar.Text = "1";
            // 
            // lblImagemUltraHDMudar
            // 
            this.lblImagemUltraHDMudar.AutoSize = true;
            this.lblImagemUltraHDMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemUltraHDMudar.ForeColor = System.Drawing.Color.Red;
            this.lblImagemUltraHDMudar.Location = new System.Drawing.Point(371, 209);
            this.lblImagemUltraHDMudar.Name = "lblImagemUltraHDMudar";
            this.lblImagemUltraHDMudar.Size = new System.Drawing.Size(16, 16);
            this.lblImagemUltraHDMudar.TabIndex = 14;
            this.lblImagemUltraHDMudar.Text = "X";
            // 
            // lblImagemHDMudar
            // 
            this.lblImagemHDMudar.AutoSize = true;
            this.lblImagemHDMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemHDMudar.ForeColor = System.Drawing.Color.Red;
            this.lblImagemHDMudar.Location = new System.Drawing.Point(371, 162);
            this.lblImagemHDMudar.Name = "lblImagemHDMudar";
            this.lblImagemHDMudar.Size = new System.Drawing.Size(16, 16);
            this.lblImagemHDMudar.TabIndex = 13;
            this.lblImagemHDMudar.Text = "X";
            // 
            // lblPrecoMudar
            // 
            this.lblPrecoMudar.AutoSize = true;
            this.lblPrecoMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoMudar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecoMudar.Location = new System.Drawing.Point(325, 116);
            this.lblPrecoMudar.Name = "lblPrecoMudar";
            this.lblPrecoMudar.Size = new System.Drawing.Size(66, 16);
            this.lblPrecoMudar.TabIndex = 12;
            this.lblPrecoMudar.Text = "R$ 25,90";
            // 
            // lblMesGratuito
            // 
            this.lblMesGratuito.AutoSize = true;
            this.lblMesGratuito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesGratuito.Location = new System.Drawing.Point(48, 431);
            this.lblMesGratuito.Name = "lblMesGratuito";
            this.lblMesGratuito.Size = new System.Drawing.Size(149, 19);
            this.lblMesGratuito.TabIndex = 11;
            this.lblMesGratuito.Text = "Mês gratuito de teste";
            // 
            // lblCancele
            // 
            this.lblCancele.AutoSize = true;
            this.lblCancele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancele.Location = new System.Drawing.Point(48, 387);
            this.lblCancele.Name = "lblCancele";
            this.lblCancele.Size = new System.Drawing.Size(157, 19);
            this.lblCancele.TabIndex = 9;
            this.lblCancele.Text = "Cancele quando quiser";
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmes.Location = new System.Drawing.Point(48, 346);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(174, 19);
            this.lblFilmes.TabIndex = 7;
            this.lblFilmes.Text = "Filmes e séries ilimitados";
            // 
            // lblAssistirNaTv
            // 
            this.lblAssistirNaTv.AutoSize = true;
            this.lblAssistirNaTv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistirNaTv.Location = new System.Drawing.Point(48, 299);
            this.lblAssistirNaTv.Name = "lblAssistirNaTv";
            this.lblAssistirNaTv.Size = new System.Drawing.Size(279, 19);
            this.lblAssistirNaTv.TabIndex = 6;
            this.lblAssistirNaTv.Text = "Assistir na TV, notebook, celular ou tablet";
            // 
            // lblTelasSimultaneas
            // 
            this.lblTelasSimultaneas.AutoSize = true;
            this.lblTelasSimultaneas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelasSimultaneas.Location = new System.Drawing.Point(48, 252);
            this.lblTelasSimultaneas.Name = "lblTelasSimultaneas";
            this.lblTelasSimultaneas.Size = new System.Drawing.Size(126, 19);
            this.lblTelasSimultaneas.TabIndex = 5;
            this.lblTelasSimultaneas.Text = "Telas simultâneas";
            // 
            // lblImagemUltraHD
            // 
            this.lblImagemUltraHD.AutoSize = true;
            this.lblImagemUltraHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemUltraHD.Location = new System.Drawing.Point(48, 207);
            this.lblImagemUltraHD.Name = "lblImagemUltraHD";
            this.lblImagemUltraHD.Size = new System.Drawing.Size(215, 19);
            this.lblImagemUltraHD.TabIndex = 4;
            this.lblImagemUltraHD.Text = "Imagem em Ultra HD disponível";
            // 
            // lblImagemHD
            // 
            this.lblImagemHD.AutoSize = true;
            this.lblImagemHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemHD.Location = new System.Drawing.Point(48, 160);
            this.lblImagemHD.Name = "lblImagemHD";
            this.lblImagemHD.Size = new System.Drawing.Size(179, 19);
            this.lblImagemHD.TabIndex = 3;
            this.lblImagemHD.Text = "Imagem em HD disponível";
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPremium.Location = new System.Drawing.Point(313, 56);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(78, 20);
            this.rdbPremium.TabIndex = 2;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Premium";
            this.rdbPremium.UseVisualStyleBackColor = true;
            this.rdbPremium.CheckedChanged += new System.EventHandler(this.rdbPremium_CheckedChanged);
            // 
            // rdbPadrao
            // 
            this.rdbPadrao.AutoSize = true;
            this.rdbPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPadrao.Location = new System.Drawing.Point(179, 57);
            this.rdbPadrao.Name = "rdbPadrao";
            this.rdbPadrao.Size = new System.Drawing.Size(70, 20);
            this.rdbPadrao.TabIndex = 1;
            this.rdbPadrao.TabStop = true;
            this.rdbPadrao.Text = "Padrão";
            this.rdbPadrao.UseVisualStyleBackColor = true;
            this.rdbPadrao.CheckedChanged += new System.EventHandler(this.rdbPadrao_CheckedChanged);
            // 
            // rdbBasico
            // 
            this.rdbBasico.AutoSize = true;
            this.rdbBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBasico.Location = new System.Drawing.Point(52, 56);
            this.rdbBasico.Name = "rdbBasico";
            this.rdbBasico.Size = new System.Drawing.Size(67, 20);
            this.rdbBasico.TabIndex = 0;
            this.rdbBasico.TabStop = true;
            this.rdbBasico.Text = "Básico";
            this.rdbBasico.UseVisualStyleBackColor = true;
            this.rdbBasico.CheckedChanged += new System.EventHandler(this.rdbBasico_CheckedChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(48, 114);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(96, 19);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço mensal";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtSenha);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.lblSenha);
            this.grpLogin.Location = new System.Drawing.Point(64, 39);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(339, 140);
            this.grpLogin.TabIndex = 19;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(120, 87);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(179, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(30, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(907, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 32);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // AlterarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 661);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPlano);
            this.Controls.Add(this.grpLogin);
            this.Name = "AlterarDados";
            this.Text = "Alterar Dados";
            this.Load += new System.EventHandler(this.AlterarDados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPlano.ResumeLayout(false);
            this.grpPlano.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpPlano;
        private System.Windows.Forms.Label lblCanceleMudar;
        private System.Windows.Forms.Label lblMesGratuitoMudar;
        private System.Windows.Forms.Label lblFilmesMudar;
        private System.Windows.Forms.Label lblAssistaNaTvMudar;
        private System.Windows.Forms.Label lblTelasSimultaneasMudar;
        private System.Windows.Forms.Label lblImagemUltraHDMudar;
        private System.Windows.Forms.Label lblImagemHDMudar;
        private System.Windows.Forms.Label lblPrecoMudar;
        private System.Windows.Forms.Label lblMesGratuito;
        private System.Windows.Forms.Label lblCancele;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblAssistirNaTv;
        private System.Windows.Forms.Label lblTelasSimultaneas;
        private System.Windows.Forms.Label lblImagemUltraHD;
        private System.Windows.Forms.Label lblImagemHD;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbPadrao;
        private System.Windows.Forms.RadioButton rdbBasico;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnSair;
    }
}