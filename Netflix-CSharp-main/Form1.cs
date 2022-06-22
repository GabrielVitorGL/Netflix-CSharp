using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                lblImagemHDMudar.ForeColor = System.Drawing.Color.Red;
                lblImagemUltraHDMudar.Text = "X";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblImagemUltraHDMudar.ForeColor = System.Drawing.Color.Red;
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
                lblImagemHDMudar.ForeColor = System.Drawing.Color.Green;
                lblImagemUltraHDMudar.Text = "X";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblImagemUltraHDMudar.ForeColor = System.Drawing.Color.Red;
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
                lblImagemHDMudar.ForeColor = System.Drawing.Color.Green;
                lblImagemUltraHDMudar.Text = "✓";
                lblImagemUltraHDMudar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblImagemUltraHDMudar.ForeColor = System.Drawing.Color.Green;
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
            txtCPF.Text = "";
            mtxtValidade.Text = "";
            rdbPadrao.Checked = true;
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            string email, senha, nome, cpf, plano;
            DateTime validade;
            long ncartao;
            int cvv;
            string validadeformat = mtxtValidade.Text.Insert(2, "/");
            validadeformat = validadeformat.Insert(5, "/");

            if (txtCVV.Text == "" ||
            txtEmail.Text == "" ||
            txtNCartao.Text == "" ||
            txtNome.Text == "" ||
            txtSenha.Text == "" ||
            txtCPF.Text == "" ||
            mtxtValidade.Text == "")
            {
                MessageBox.Show("Certifique-se que preencheu todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkTermos.Checked == false)
            {
                MessageBox.Show("Você precisa aceitar os termos para criar sua conta!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("Sua senha deve conter ao menos 6 caracteres!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (EmailValido(txtEmail.Text) == false)
            {
                MessageBox.Show("O Email que você digitou não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (long.TryParse(txtNCartao.Text, out long temp) == false)
            {
                MessageBox.Show("O valor que você digitou no Número do cartão não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.TryParse(txtCVV.Text, out int temp2) == false)
            {
                MessageBox.Show("O valor que você digitou no CVV não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (DateTime.TryParse(validadeformat, out validade) == false) {
                MessageBox.Show("O valor que você digitou na data não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCPF.Text.Length != 11)
            {
                MessageBox.Show("O valor que você digitou no CPF não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNCartao.Text.Length > 16 || txtNCartao.Text.Length < 13)
            {
                MessageBox.Show("O valor que você digitou no Número do Cartão não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("O valor que você digitou no CVV não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNome.Text.Length <= 2)
            {
                MessageBox.Show("Seu nome deve ter mais de 2 caracteres!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                email = txtEmail.Text;
                senha = txtSenha.Text;
                nome = txtNome.Text;
                cpf = txtCPF.Text;
                ncartao = Convert.ToInt64(txtNCartao.Text);
                cvv = Convert.ToInt32(txtCVV.Text);
                if (rdbBasico.Checked == true)
                {
                    plano = "Basico";
                }
                else if (rdbPadrao.Checked == true)
                {
                    plano = "Padrao";
                }
                else
                {
                    plano = "Premium";
                }

                String data = validade.ToString("yyyy-MM-dd");

                SqlConnection sqlCon = null;
                String strCon = Variaveis.strCon;
                String strSql = "";
                strSql = "insert into Cliente values(@email, @senha, @nome, @cpf, @ncartao, @data, @cvv, @plano)";
                sqlCon = new SqlConnection(strCon);                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                comando.Parameters.Add("@ncartao", SqlDbType.BigInt).Value = ncartao;
                comando.Parameters.Add("@data", SqlDbType.Date).Value = Convert.ToDateTime(data);
                comando.Parameters.Add("@cvv", SqlDbType.Int).Value = cvv;
                comando.Parameters.Add("@plano", SqlDbType.VarChar).Value = plano;
                try {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    Variaveis.NomeUsuario = nome;
                    Variaveis.EmailUsuario = email;
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    sqlCon.Close();
                    Form2 f2 = new Form2();
                    f2.StartPosition = FormStartPosition.Manual;
                    f2.Location = this.Location;
                    f2.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());
                    Console.WriteLine(ex.Number);
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Já existe uma conta com esse email, favor utilizar a opção de fazer login", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro desconhecido ao criar a conta, por favor tente novamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    sqlCon.Close();
                }
            }
        }

        private void btn_FacaLogin_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.StartPosition = FormStartPosition.Manual;
            i.Location = this.Location;
            i.Show();
            this.Hide();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((((TextBox)sender).Text.Length >= 11) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
        private void txtNCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((((TextBox)sender).Text.Length >= 16) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        public int primeiravez = 1;
        private void mtxtValidade_Click(object sender, EventArgs e)
        {
            if (primeiravez == 1)
            {
                mtxtValidade.Select(0, 0);
                primeiravez = 0;
            }
        }
        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((((TextBox)sender).Text.Length >= 3) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
        bool EmailValido(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
