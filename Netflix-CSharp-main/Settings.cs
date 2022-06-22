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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void txtAmigo_Enter(object sender, EventArgs e)
        {
            if (txtAmigo.Text == "Email do seu amigo")
            {
                txtAmigo.Text = "";
                txtAmigo.ForeColor = Color.Black;
            }
        }

        private void txtAmigo_Leave(object sender, EventArgs e)
        {
            if (txtAmigo.Text == "")
            {
                txtAmigo.Text = "Email do seu amigo";
                txtAmigo.ForeColor = Color.DimGray;
            }
        }

        private void btnAdicionarAmigo_Click(object sender, EventArgs e)
        {
            if (txtAmigo.Text != Variaveis.EmailUsuario)
            {
                SqlConnection sqlCon = null;
                String strCon = Variaveis.strCon;
                String strSql = "";
                strSql = "select * from Cliente where cliente_email = @cliente_email";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@cliente_email", SqlDbType.VarChar).Value = txtAmigo.Text;
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    if (MessageBox.Show("Deseja adicionar " + Convert.ToString(dr["cliente_nome"]) + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        strSql = "insert into Amigos values(@email_usuario1, @nome_usuario1, @email_usuario2, @nome_usuario2);insert into Amigos values(@email_usuario2, @nome_usuario2, @email_usuario1, @nome_usuario1)";
                        sqlCon = new SqlConnection(strCon);
                        SqlCommand comando2 = new SqlCommand(strSql, sqlCon);
                        comando2.Parameters.Add("@email_usuario1", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
                        comando2.Parameters.Add("@email_usuario2", SqlDbType.VarChar).Value = dr["cliente_email"];
                        comando2.Parameters.Add("@nome_usuario1", SqlDbType.VarChar).Value = Variaveis.NomeUsuario;
                        comando2.Parameters.Add("@nome_usuario2", SqlDbType.VarChar).Value = dr["cliente_nome"];
                        try
                        {
                            sqlCon.Open();
                            comando2.ExecuteNonQuery();
                            MessageBox.Show("Amigo adicionado");
                            txtAmigo.Text = "";
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
                                MessageBox.Show("Essa pessoa já é seu amigo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro desconhecido ao adicionar essa pessoa, por favor tente novamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        sqlCon.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("Você não pode adicionar sua própria conta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            atualizarListaAmigos();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            atualizarListaAmigos();
        }

        private void btnExcluirAmigo_Click(object sender, EventArgs e)
        {
            if (txtAmigo.Text != Variaveis.EmailUsuario)
            {
                SqlConnection sqlCon = null;
                String strCon = Variaveis.strCon;
                String strSql = "";
                strSql = "select * from Amigos where (amigos_email_usuario1 = @usuario1 and amigos_email_usuario2 = @usuario2) or (amigos_email_usuario1 = @usuario2 and amigos_email_usuario2 = @usuario1)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@usuario1", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
                comando.Parameters.Add("@usuario2", SqlDbType.VarChar).Value = txtAmigo.Text;
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    String deseja_remover;
                    if (Convert.ToString(dr["amigos_email_usuario1"])==Variaveis.EmailUsuario)
                    {
                        deseja_remover = Convert.ToString(dr["amigos_nome_usuario2"]);
                    }
                    else
                    {
                        deseja_remover = Convert.ToString(dr["amigos_nome_usuario1"]);
                    }
                    if (MessageBox.Show("Deseja remover " + deseja_remover + " da sua lisa de amigos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sqlCon.Close();
                        strSql = "delete from Amigos where (amigos_email_usuario1 = @usuario1 and amigos_email_usuario2 = @usuario2) or (amigos_email_usuario1 = @usuario2 and amigos_email_usuario2 = @usuario1)";
                        comando = new SqlCommand(strSql, sqlCon);
                        comando.Parameters.Add("@usuario1", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
                        comando.Parameters.Add("@usuario2", SqlDbType.VarChar).Value = txtAmigo.Text;
                        try
                        {
                            sqlCon.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Amigo excluído com sucesso");
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
                            MessageBox.Show("Ocorreu um erro desconhecido ao excluir esse amigo, por favor tente novamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        sqlCon.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                sqlCon.Close();
            }
            else
            {
                MessageBox.Show("Essa é sua própria conta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lstAmigos.Items.Clear();
            atualizarListaAmigos();
        }

        private void atualizarListaAmigos()
        {
            SqlConnection sqlCon = null;
            String strCon = Variaveis.strCon;
            String strSql = "";
            strSql = "select * from Amigos where amigos_email_usuario1 = @email";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Variaveis.EmailUsuario;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    if (!lstAmigos.Items.Contains("Email: " + dr["amigos_email_usuario2"]))
                    {
                        lstAmigos.Items.Add("Nome: " + dr["amigos_nome_usuario2"]);
                        lstAmigos.Items.Add("Email: " + dr["amigos_email_usuario2"]);
                        lstAmigos.Items.Add("");
                    }
                }
            }
        }

        private void txtAmigo_TextChanged(object sender, EventArgs e)
        {
            if (txtAmigo.Text != "")
            {
                btnAdicionarAmigo.Enabled = true;
                btnExcluirAmigo.Enabled = true;
            }
            else
            {
                btnAdicionarAmigo.Enabled = false;
                btnExcluirAmigo.Enabled = false;
            }
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            Verification v = new Verification();
            v.StartPosition = FormStartPosition.Manual;
            v.Location = this.Location;
            v.Show();
        }
    }
}
