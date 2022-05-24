using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class frmNetflix : Form
    {
        public frmNetflix()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBasico.Checked)
            {
                lblPrecoMudar.Text = "R$ 25,90";
                lblImagemHDMudar.Text = "X";
                lblImagemHDMudar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblImagemUltraHDMudar.Text = "X";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblTelasSimultaneasMudar.Text = "1";
            }
        }

        private void frmNetflix_Load(object sender, EventArgs e)
        {
            rdbPadrao.Checked = true;
        }

        private void rdbPadrao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPadrao.Checked)
            {
                lblPrecoMudar.Text = "R$ 39,90";
                lblImagemHDMudar.Text = "✓";
                lblImagemHDMudar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblImagemUltraHDMudar.Text = "X";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblTelasSimultaneasMudar.Text = "2";
            }
        }

        private void rdbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPremium.Checked)
            {
                lblPrecoMudar.Text = "R$ 55,90";
                lblImagemHDMudar.Text = "✓";
                lblImagemHDMudar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblImagemUltraHDMudar.Text = "✓";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblTelasSimultaneasMudar.Text = "4";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCVV.Text = "";
            txtEmail.Text = "";
            txtNCartao.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtSobrenome.Text = "";
            txtValidade.Text = "";
            rdbPadrao.Checked = true;
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (txtCVV.Text == "" ||
            txtEmail.Text == "" ||
            txtNCartao.Text == ""||
            txtNome.Text == ""||
            txtSenha.Text == ""||
            txtSobrenome.Text == ""||
            txtValidade.Text == "")
            {
                MessageBox.Show("Certifique-se que preencheu todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkTermos.Checked == false)
            {
                MessageBox.Show("Você precisa aceitar os termos para criar sua conta!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (long.TryParse(txtNCartao.Text, out long temp) == false)
            {
                MessageBox.Show("O valor que você digitou no Número do cartão não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.TryParse(txtCVV.Text, out int temp2) == false)
            {
                MessageBox.Show("O valor que você digitou no CVV não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Variaveis.NomeUsuario = txtNome.Text;
                Load1 l = new Load1();
                l.StartPosition = FormStartPosition.Manual;
                l.Location = this.Location;
                l.Show();
                this.Hide();
            }
        }
    }
}
