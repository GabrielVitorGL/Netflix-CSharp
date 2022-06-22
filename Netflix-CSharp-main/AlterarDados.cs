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
    public partial class AlterarDados : Form
    {
        public AlterarDados()
        {
            InitializeComponent();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.StartPosition = FormStartPosition.Manual;
            s.Location = this.Location;
            s.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AlterarDados_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = null;
            String strCon = Variaveis.strCon;
            String strSql = "";
            strSql = "select * from Cliente where cliente_email = @cliente_email";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@cliente_email", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                txtEmail.Text = Convert.ToString(dr["cliente_email"]);
                txtSenha.Text = Convert.ToString(dr["cliente_senha"]);
                txtNome.Text = Convert.ToString(dr["cliente_nome"]);
                txtCPF.Text = Convert.ToString(dr["cliente_cpf"]);
                txtNCartao.Text = Convert.ToString(dr["cliente_ncartao"]);
                mtxtValidade.Text = Convert.ToString(dr["cliente_validade"]);
                txtCVV.Text = Convert.ToString(dr["cliente_cvv"]);
                if (Convert.ToString(dr["cliente_plano"]) == "Padrao")
                {
                    rdbPadrao.Checked = true;
                }
                else if (Convert.ToString(dr["cliente_plano"]) == "Basico")
                {
                    rdbBasico.Checked = true;
                }
                else
                {
                    rdbPremium.Checked = true;
                }
            }
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            string email, senha, nome, cpf, plano;
            DateTime validade;
            long ncartao;
            int cvv;
            string validadeformat = mtxtValidade.Text.Insert(2, "/");
            validadeformat = validadeformat.Insert(5, "/");
            Console.WriteLine(validadeformat);

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
            else if (long.TryParse(txtNCartao.Text, out long temp) == false)
            {
                MessageBox.Show("O valor que você digitou no Número do cartão não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("Sua senha deve conter ao menos 6 caracteres!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (EmailValido(txtEmail.Text) == false)
            {
                MessageBox.Show("O Email que você digitou não é válido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.TryParse(txtCVV.Text, out int temp2) == false)
            {
                MessageBox.Show("O valor que você digitou no CVV não é um número!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (DateTime.TryParse(validadeformat, out validade) == false)
            {
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
                strSql = "update Cliente set cliente_email=@email, cliente_senha=@senha, cliente_nome=@nome, cliente_cpf=@cpf, cliente_ncartao=@ncartao, cliente_validade=@data, cliente_cvv=@cvv, cliente_plano=@plano where cliente_email = @emailatual";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@emailatual", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                comando.Parameters.Add("@ncartao", SqlDbType.BigInt).Value = ncartao;
                comando.Parameters.Add("@data", SqlDbType.Date).Value = Convert.ToDateTime(data);
                comando.Parameters.Add("@cvv", SqlDbType.Int).Value = cvv;
                comando.Parameters.Add("@plano", SqlDbType.VarChar).Value = plano;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    Variaveis.NomeUsuario = nome;
                    Variaveis.EmailUsuario = email;
                    MessageBox.Show("Dados atualizados com sucesso");
                    sqlCon.Close();
                    Settings s = new Settings();
                    s.StartPosition = FormStartPosition.Manual;
                    s.Location = this.Location;
                    s.Show();
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
                    MessageBox.Show("Ocorreu um erro desconhecido ao atualizar seus dados, por favor tente novamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    sqlCon.Close();
                }
            }
        }
    }
}
