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
    public partial class Load1 : Form
    {
        public Load1()
        {
            InitializeComponent();
        }

        private void lblCriandoConta_Click(object sender, EventArgs e)
        {
        }

        private async void Load1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != 3)
                {
                    lblCriandoConta.Text += ".";
                    await Task.Delay(300);   
                }
                else
                {
                    lblCriandoConta.Text = "Criando Conta.";
                    await Task.Delay(300);
                }
            }
            await Task.Delay(300);
            lblCriandoConta.Text = "Conta Criada!";
            pctBox.Image = Netflix.Properties.Resources.check;
            await Task.Delay(1500);
            Form2 f2 = new Form2();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }
    }
}
