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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenero.SelectedIndex == 0)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("Nada a Esconder");
                lstFilmes.Items.Add("Lolo, o Filho da Minha Namorada");
                lstFilmes.Items.Add("Em Toda Parte");
                lstFilmes.Items.Add("4th Man Out");
                lstFilmes.Items.Add("Frances Ha");
                lstFilmes.Items.Add("Minha Obra-Prima");
                lstFilmes.Items.Add("O Cidadão Ilustre");
            }
            else if(cboGenero.SelectedIndex == 1)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("La La Land");
                lstFilmes.Items.Add("Quem Você Levaria para uma Ilha Deserta");
                lstFilmes.Items.Add("Monsieur & Madame Adelman");
                lstFilmes.Items.Add("A Rainha da Espanha");
                lstFilmes.Items.Add("Palmeiras na Neve");
                lstFilmes.Items.Add("Sierra Burgess É uma Loser");
                lstFilmes.Items.Add("Handsome Devil");
                lstFilmes.Items.Add("O Date Perfeito");
            }
            else if(cboGenero.SelectedIndex == 2)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("Corra!");
                lstFilmes.Items.Add("Um Contratempo");
                lstFilmes.Items.Add("Quando os Anjos Dormem");
                lstFilmes.Items.Add("Garota Exemplar");
                lstFilmes.Items.Add("Neve Negra");
                lstFilmes.Items.Add("Versões de um Crime");
            }
            else if(cboGenero.SelectedIndex == 3)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("Birdman");
                lstFilmes.Items.Add("Mi Gran Noche");
                lstFilmes.Items.Add("Climax");
                lstFilmes.Items.Add("O Bar");
                lstFilmes.Items.Add("O Aviso");
                lstFilmes.Items.Add("Thelma");
            }
            else if(cboGenero.SelectedIndex == 4)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("Invasão Zumbi");
                lstFilmes.Items.Add("Raw");
                lstFilmes.Items.Add("O Hospedeiro");
                lstFilmes.Items.Add("Hush — A Morte Ouve");
                lstFilmes.Items.Add("Quando as Luzes se Apagam");
                lstFilmes.Items.Add("Uma Noite de Crime");
            }
            else if(cboGenero.SelectedIndex == 5)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("História de um Casamento");
                lstFilmes.Items.Add("Invencível");
                lstFilmes.Items.Add("Ted Bundy – A Irresistível Face do Mal");
                lstFilmes.Items.Add("Joias Brutas");
                lstFilmes.Items.Add("Manchester à Beira-Mar");
                lstFilmes.Items.Add("Sully");
                lstFilmes.Items.Add("Lion");
                lstFilmes.Items.Add("22 de Julho");
                lstFilmes.Items.Add("Assunto de Família");
                lstFilmes.Items.Add("Uma Noite de 12 Anos");
                lstFilmes.Items.Add("Sob a Pele do Lobo");
                lstFilmes.Items.Add("Eu Sou Michael");
                lstFilmes.Items.Add("The Fury of a Patient Man");
                lstFilmes.Items.Add("Loev");
                lstFilmes.Items.Add("O Vazio do Domingo");
                lstFilmes.Items.Add("Divinas");
                lstFilmes.Items.Add("A Próxima Pele");
                lstFilmes.Items.Add("O Preço do Sucesso");
                lstFilmes.Items.Add("Handia");
                lstFilmes.Items.Add("Árvore de Sangue");
            }
            else if(cboGenero.SelectedIndex == 6)
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("Gravidade");
                lstFilmes.Items.Add("Morte em Buenos Aires");
                lstFilmes.Items.Add("Durante a Tormenta");
                lstFilmes.Items.Add("Ares");
                lstFilmes.Items.Add("Toro");
            }
            else
            {
                lstFilmes.Items.Clear();
                lstFilmes.Items.Add("O Barato de Iacanga");
                lstFilmes.Items.Add("Holy Hell");
                lstFilmes.Items.Add("Fyre Festival — Fiasco no Caribe");
                lstFilmes.Items.Add("A Gray State");
                lstFilmes.Items.Add("One of Us");
                lstFilmes.Items.Add("Voyeur");
                lstFilmes.Items.Add("Ícaro");
                lstFilmes.Items.Add("Indústria Americana");
                lstFilmes.Items.Add("Privacidade Hackeada");
                lstFilmes.Items.Add("Elena");
                lstFilmes.Items.Add("Histórias que Nossos Cinemas Não Contavam");
            }
        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(lstFilmes.SelectedItem) != "")
            {
                if (MessageBox.Show("Deseja assitir " + Convert.ToString(lstFilmes.SelectedItem) + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (Convert.ToString(lstFilmes.SelectedItem))
                    {
                        case "Nada a Esconder":
                            Variaveis.idfilme = "WjiDs1eeTMo";
                            break;
                        case "Lolo, o Filho da Minha Namorada":
                            Variaveis.idfilme = "HRgMbS7pVA4";
                            break;
                        case "Em Toda Parte":
                            Variaveis.idfilme = "gXtvFqPQwR0";
                            break;
                        case "4th Man Out":
                            Variaveis.idfilme = "Ilt0SwJ4374";
                            break;
                        case "Frances Ha":
                            Variaveis.idfilme = "e_RRsPtY-cI";
                            break;
                        case "Minha Obra-Prima":
                            Variaveis.idfilme = "a79tsdYaM84";
                            break;
                        case "O Cidadão Ilustre":
                            Variaveis.idfilme = "B-sWCVFshYI";
                            break;
                        case "La La Land":
                            Variaveis.idfilme = "zXvgkkNMi-4";
                            break;
                        case "Quem Você Levaria para uma Ilha Deserta":
                            Variaveis.idfilme = "pCJsXJxgZV8";
                            break;
                        case "Monsieur & Madame Adelman":
                            Variaveis.idfilme = "X-OpU8bmk8Q";
                            break;
                        case "A Rainha da Espanha":
                            Variaveis.idfilme = "A2RRNDFPpnM";
                            break;
                        case "Palmeiras na Neve":
                            Variaveis.idfilme = "q9gbEHvW-PU";
                            break;
                        case "Sierra Burgess É uma Loser":
                            Variaveis.idfilme = "-rpRbmFcAnE";
                            break;
                        case "Handsome Devil":
                            Variaveis.idfilme = "V6EvMq0Xwbs";
                            break;
                        case "O Date Perfeito":
                            Variaveis.idfilme = "r4PiUSYn-D0";
                            break;
                        case "Corra!":
                            Variaveis.idfilme = "mDGV5UucTu8";
                            break;
                        case "Um Contratempo":
                            Variaveis.idfilme = "4DTjlmNYMEo";
                            break;
                        case "Quando os Anjos Dormem":
                            Variaveis.idfilme = "Yqc43YSFYxM";
                            break;
                        case "Garota Exemplar":
                            Variaveis.idfilme = "8qrbA8WjJJo";
                            break;
                        case "Neve Negra":
                            Variaveis.idfilme = "YzOkCNQy-gQ";
                            break;
                        case "Versões de um Crime":
                            Variaveis.idfilme = "x234pdjrzA8";
                            break;
                        case "Birdman":
                            Variaveis.idfilme = "n7kPKVxuz6k";
                            break;
                        case "Mi Gran Noche":
                            Variaveis.idfilme = "KBahnqECT7o";
                            break;
                        case "Climax":
                            Variaveis.idfilme = "lq05aIRMsZ0";
                            break;
                        case "O Bar":
                            Variaveis.idfilme = "wcOqUb5Z7xg";
                            break;
                        case "O Aviso":
                            Variaveis.idfilme = "Ozae5C4eyGA";
                            break;
                        case "Thelma":
                            Variaveis.idfilme = "k7dM9adQFV4";
                            break;
                        case "Invasão Zumbi":
                            Variaveis.idfilme = "Ekp-Cz41Pvw";
                            break;
                        case "Raw":
                            Variaveis.idfilme = "gFlXVX2af_Y";
                            break;
                        case "O Hospedeiro":
                            Variaveis.idfilme = "HzqQVsgQu9g";
                            break;
                        case "Hush — A Morte Ouve":
                            Variaveis.idfilme = "j31Ucc2eAvo";
                            break;
                        case "Quando as Luzes se Apagam":
                            Variaveis.idfilme = "aH3lLOumNoQ";
                            break;
                        case "Uma Noite de Crime":
                            Variaveis.idfilme = "faQYgdXPRnU";
                            break;
                        case "História de um Casamento":
                            Variaveis.idfilme = "ZzSomaJAIMc";
                            break;
                        case "Invencível":
                            Variaveis.idfilme = "leTOl5DGBIg";
                            break;
                        case "Ted Bundy – A Irresistível Face do Mal":
                            Variaveis.idfilme = "VrePOzNfYHE";
                            break;
                        case "Joias Brutas":
                            Variaveis.idfilme = "IOSP5uEbTUc";
                            break;
                        case "Manchester à Beira-Mar":
                            Variaveis.idfilme = "q5T6XWtcmH0";
                            break;
                        case "Sully":
                            Variaveis.idfilme = "mjKEXxO2KNE";
                            break;
                        case "Lion":
                            Variaveis.idfilme = "-RNI9o06vqo";
                            break;
                        case "22 de Julho":
                            Variaveis.idfilme = "sGJFL0HGfA4";
                            break;
                        case "Assunto de Família":
                            Variaveis.idfilme = "PsSQaoGs-6s";
                            break;
                        case "Uma Noite de 12 Anos":
                            Variaveis.idfilme = "1qy2_cwrRyU";
                            break;
                        case "Sob a Pele do Lobo":
                            Variaveis.idfilme = "p4XVauabahg";
                            break;
                        case "Eu Sou Michael":
                            Variaveis.idfilme = "U1HUR02-mhw";
                            break;
                        case "The Fury of a Patient Man":
                            Variaveis.idfilme = "xUs3snEcQNA";
                            break;
                        case "Loev":
                            Variaveis.idfilme = "pDndThLxxvk";
                            break;
                        case "O Vazio do Domingo":
                            Variaveis.idfilme = "TobcTRoHlmY";
                            break;
                        case "Divinas":
                            Variaveis.idfilme = "NaKpfEJ5NMc";
                            break;
                        case "A Próxima Pele":
                            Variaveis.idfilme = "TRR51GjL8cA";
                            break;
                        case "O Preço do Sucesso":
                            Variaveis.idfilme = "hFDgo0TZwgM";
                            break;
                        case "Handia":
                            Variaveis.idfilme = "zx_pcgZi5h4";
                            break;
                        case "Árvore de Sangue":
                            Variaveis.idfilme = "QYPE4ijfCEs";
                            break;
                        case "Gravidade":
                            Variaveis.idfilme = "46FXVu9foqo";
                            break;
                        case "Morte em Buenos Aires":
                            Variaveis.idfilme = "k-CB7GLfhMk";
                            break;
                        case "Durante a Tormenta":
                            Variaveis.idfilme = "6Y8tn-2u3yg";
                            break;
                        case "Ares":
                            Variaveis.idfilme = "QnrT1e2W10w";
                            break;
                        case "Toro":
                            Variaveis.idfilme = "1SpecgPl8lw";
                            break;
                        case "O Barato de Iacanga":
                            Variaveis.idfilme = "sqf3wtpFpRA";
                            break;
                        case "Holy Hell":
                            Variaveis.idfilme = "2f2BG43JW0o";
                            break;
                        case "Fyre Festival — Fiasco no Caribe":
                            Variaveis.idfilme = "fYtJ2W5y8vQ";
                            break;
                        case "A Gray State":
                            Variaveis.idfilme = "kNv9ipjU5Pw";
                            break;
                        case "One of Us":
                            Variaveis.idfilme = "uBPn5oQNutI";
                            break;
                        case "Voyeur":
                            Variaveis.idfilme = "kTAYqsT05Dc";
                            break;
                        case "Ícaro":
                            Variaveis.idfilme = "vYN5QM2OPjs";
                            break;
                        case "Indústria Americana":
                            Variaveis.idfilme = "5sFFttgfljU";
                            break;
                        case "Privacidade Hackeada":
                            Variaveis.idfilme = "wjXYCrxRWqc";
                            break;
                        case "Elena":
                            Variaveis.idfilme = "drDu9Ta1JWc";
                            break;
                        case "Histórias que Nossos Cinemas Não Contavam":
                            Variaveis.idfilme = "dMqgPVxCV9Y";
                            break;
                    }
                    Form3 f3 = new Form3();
                    f3.StartPosition = FormStartPosition.Manual;
                    f3.Location = this.Location;
                    f3.Show();
                    f3.Text = Convert.ToString(lstFilmes.SelectedItem);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Escolha um filme para assistir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Bem vindo, " + Variaveis.NomeUsuario + "!";
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
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
    }
}
