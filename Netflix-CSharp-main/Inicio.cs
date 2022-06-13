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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = null;
            String strCon = Variaveis.strCon;
            String strSql = "";
            strSql = "select * from Cliente where cliente_email = @cliente_email and cliente_senha = @cliente_senha";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@cliente_email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@cliente_senha", SqlDbType.VarChar).Value = txtSenha.Text;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                Variaveis.NomeUsuario = Convert.ToString(dr["cliente_nome"]);
                Variaveis.EmailUsuario = Convert.ToString(dr["cliente_email"]);
                Form2 f2 = new Form2();
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = this.Location;
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cadastro não encontrado, cheque os campos ou registre-se já", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            sqlCon.Close();
    }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Registrese_Click(object sender, EventArgs e)
        {
            frmNetflix f1 = new frmNetflix();
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
