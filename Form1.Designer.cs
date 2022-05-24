
namespace Netflix
{
    partial class frmNetflix
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.chkTermos = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCartao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.grpPlano.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblSenha.Location = new System.Drawing.Point(30, 87);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
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
            this.grpLogin.Controls.Add(this.chkTermos);
            this.grpLogin.Controls.Add(this.txtSenha);
            this.grpLogin.Controls.Add(this.txtEmail);
            this.grpLogin.Controls.Add(this.lblEmail);
            this.grpLogin.Controls.Add(this.lblSenha);
            this.grpLogin.Location = new System.Drawing.Point(72, 45);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(339, 169);
            this.grpLogin.TabIndex = 9;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // chkTermos
            // 
            this.chkTermos.AutoSize = true;
            this.chkTermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTermos.Location = new System.Drawing.Point(33, 130);
            this.chkTermos.Name = "chkTermos";
            this.chkTermos.Size = new System.Drawing.Size(207, 19);
            this.chkTermos.TabIndex = 4;
            this.chkTermos.Text = "Concordo com os Termos de uso";
            this.chkTermos.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(120, 86);
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
            this.grpPlano.Location = new System.Drawing.Point(483, 45);
            this.grpPlano.Name = "grpPlano";
            this.grpPlano.Size = new System.Drawing.Size(429, 488);
            this.grpPlano.TabIndex = 10;
            this.grpPlano.TabStop = false;
            this.grpPlano.Text = "Plano";
            // 
            // lblCanceleMudar
            // 
            this.lblCanceleMudar.AutoSize = true;
            this.lblCanceleMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblImagemHD.Click += new System.EventHandler(this.label1_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCVV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNCartao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(72, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 292);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
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
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(139, 98);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(166, 20);
            this.txtSobrenome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sobrenome";
            // 
            // txtValidade
            // 
            this.txtValidade.Location = new System.Drawing.Point(139, 193);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(166, 20);
            this.txtValidade.TabIndex = 9;
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
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(72, 580);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(181, 48);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(483, 580);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(181, 48);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(731, 580);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(181, 48);
            this.btnCriarConta.TabIndex = 14;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // frmNetflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 661);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPlano);
            this.Controls.Add(this.grpLogin);
            this.MaximizeBox = false;
            this.Name = "frmNetflix";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmNetflix_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpPlano.ResumeLayout(false);
            this.grpPlano.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpPlano;
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
        private System.Windows.Forms.Label lblPrecoMudar;
        private System.Windows.Forms.Label lblCanceleMudar;
        private System.Windows.Forms.Label lblMesGratuitoMudar;
        private System.Windows.Forms.Label lblFilmesMudar;
        private System.Windows.Forms.Label lblAssistaNaTvMudar;
        private System.Windows.Forms.Label lblTelasSimultaneasMudar;
        private System.Windows.Forms.Label lblImagemUltraHDMudar;
        private System.Windows.Forms.Label lblImagemHDMudar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.CheckBox chkTermos;
    }
}

