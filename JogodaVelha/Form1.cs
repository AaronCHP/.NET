using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {

        string Njogador1, Njogador2, jogada;
        int cont = 0, Pjogador1 = 0, Pjogador2 = 0, empate = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do jogo?","Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((txtJogador1.Text != "") && (txtJogador2.Text != ""))
            {
                Njogador1 = txtJogador1.Text;
                txtJogador1.Visible = false;
                lblJogador1.Text = Njogador1 + " joga com";

                Njogador2 = txtJogador2.Text;
                txtJogador2.Visible = false;
                lblJogador2.Text = Njogador2 + " joga com";

                if (rbX.Checked)
                {
                    lblJogador1.Text = lblJogador1.Text + " X";
                    lblJogador2.Text = lblJogador2.Text + " O";
                }
                else if (rbO.Checked)
                {
                    lblJogador1.Text = lblJogador1.Text + " O";
                    lblJogador2.Text = lblJogador2.Text + " X";
                }

                gbOpcoes.Enabled = false;
                gbEmpate.Enabled = true;

                lblPlacar1.Text = Pjogador1 + " - Vitórias";
                lblPlacar2.Text = Pjogador2 + " - Vitórias";
                lblEmpate.Text = empate + " - Empates";
            } else
            {
                MessageBox.Show("Informe os nomes de ambos os jogadores", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        public void vencedor()
        {
            if ((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Text == "O") ||
                (btn4.Text == "O") && (btn5.Text == "O") && (btn6.Text == "O") ||
                (btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O") )
            {
                MessageBox.Show("GANHOU", "VITÓRIA DAS BOLINHAS!!!");
                limpar();
                Pjogador2 = Pjogador2 + 1;
                lblPlacar2.Text = Pjogador2.ToString() + " - Vitórias";
            }
            else if ((btn1.Text == "O") && (btn4.Text == "O") && (btn7.Text == "O") ||
                (btn2.Text == "O") && (btn5.Text == "O") && (btn8.Text == "O") ||
                (btn3.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O"))
            {
                MessageBox.Show("GANHOU", "VITÓRIA DAS BOLINHAS!!!");
                limpar();
                Pjogador2 = Pjogador2 + 1;
                lblPlacar2.Text = Pjogador2.ToString() + " - Vitórias";
            }
            else if ((btn1.Text == "O") && (btn5.Text == "O") && (btn9.Text == "O") ||
                (btn3.Text == "O") && (btn5.Text == "O") && (btn7.Text == "O"))
            {
                MessageBox.Show("GANHOU", "VITÓRIA DAS BOLINHAS!!!");
                limpar();
                Pjogador2 = Pjogador2 + 1;
                lblPlacar2.Text = Pjogador2.ToString() + " - Vitórias";
            }
            else if ((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Text == "X") ||
                    (btn4.Text == "X") && (btn5.Text == "X") && (btn6.Text == "X") ||
                    (btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X"))
            {
                MessageBox.Show("GANHOU", "VITÓRIA DOS XIS!!!");
                limpar();
                Pjogador1 = Pjogador1 + 1;
                lblPlacar1.Text = Pjogador1.ToString() + " - Vitórias";
            }
            else if ((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X") ||
                (btn2.Text == "X") && (btn5.Text == "X") && (btn8.Text == "X") ||
                (btn3.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X"))
            {
                MessageBox.Show("GANHOU", "VITÓRIA DOS XIS!!!");
                limpar();
                Pjogador1 = Pjogador1 + 1;
                lblPlacar1.Text = Pjogador1.ToString() + " - Vitórias";
            }
            else if ((btn1.Text == "X") && (btn5.Text == "X") && (btn9.Text == "X") ||
                (btn3.Text == "X") && (btn5.Text == "X") && (btn7.Text == "X"))
            {
                MessageBox.Show("GANHOU", "VITÓRIA DOS XIS!!!");
                limpar();
                Pjogador1 = Pjogador1 + 1;
                lblPlacar1.Text = Pjogador1.ToString() + " - Vitórias";
            } else if (cont >= 9)
            {
                MessageBox.Show("EMPATOU");
                empate = empate + 1;
                lblEmpate.Text = empate.ToString() + " - Empates";
                limpar();
            }
        }

        

        public void limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            gbEmpate.Enabled = true;
            Habilitar_botoes();
            cont = 0;
        }

        

        public void Habilitar_botoes()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn1.Text = jogada;
                btn1.Enabled = false;
            } else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn1.Text = jogada;
                btn1.Enabled = false;
            }
            cont++;
            vencedor();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn2.Text = jogada;
                btn2.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn2.Text = jogada;
                btn2.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn3.Text = jogada;
                btn3.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn3.Text = jogada;
                btn3.Enabled = false;
            }
            cont++;
            vencedor();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn4.Text = jogada;
                btn4.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn4.Text = jogada;
                btn4.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn5.Text = jogada;
                btn5.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn5.Text = jogada;
                btn5.Enabled = false;
            }
            cont++;
            vencedor();
        }

        

        private void btn6_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn6.Text = jogada;
                btn6.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn6.Text = jogada;
                btn6.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn7.Text = jogada;
                btn7.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn7.Text = jogada;
                btn7.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn8.Text = jogada;
                btn8.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn8.Text = jogada;
                btn8.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (rbX.Checked)
            {
                jogada = rbX.Text;
                rbO.Checked = true;
                btn9.Text = jogada;
                btn9.Enabled = false;
            }
            else if (rbO.Checked)
            {
                jogada = rbO.Text;
                rbX.Checked = true;
                btn9.Text = jogada;
                btn9.Enabled = false;
            }
            cont++;
            vencedor();
        }

    }
}
