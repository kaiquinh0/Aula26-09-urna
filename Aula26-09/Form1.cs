using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula26_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Numero = "";
        Candidato alguem;
        Candidato[] lista = new Candidato[4];
        int branco = 0, nulo = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false;
            txtNum2.Enabled = false;
            btnConfirma.Enabled = false;
            lblMensagem.Enabled = false;
            insereCandidato();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Preencher("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Preencher("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Preencher("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Preencher("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Preencher("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Preencher("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Preencher("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Preencher("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Preencher("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Preencher("0");
        }
        private void insereCandidato()
        {
            alguem = new Candidato();
            alguem.Numero = 11;
            alguem.Nome = "Carlos Eduardo";
            alguem.Turma = "1ª ADS";
            alguem.Foto = "carlos.png";
            lista[0] = alguem;

            alguem = new Candidato();
            alguem.Numero = 12;
            alguem.Nome = "José Silva";
            alguem.Turma = "1ª ADS";
            alguem.Foto = "jose.png";
            lista[1] = alguem;

            alguem = new Candidato();
            alguem.Numero = 13;
            alguem.Nome = "Laura Simão";
            alguem.Turma = "1ª ADS";
            alguem.Foto = "laura.png";
            lista[2] = alguem;

            alguem = new Candidato();
            alguem.Numero = 14;
            alguem.Nome = "Maria Helena";
            alguem.Turma = "1ª ADS";
            alguem.Foto = "maria.png";
            lista[3] = alguem;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            lblCandidato.Text = null;
            lblTurma.Text = null;
            lblMensagem.Visible = false;
            btnConfirma.Enabled = false;
            Numero = "";
            pxFoto.Image = null;
        }

        private void Preencher(string n)
        {
            if (Numero.Length == 0)
            {
                txtNum1.Text = n;
                Numero += n;
            }
            else
            {
                txtNum2.Text = n;
                Numero += n;
                for (int i = 0; i < 4; i++)
                {
                    if (Convert.ToInt32(Numero) == lista[i].Numero)
                    {
                        lblCandidato.Text = lista[i].Nome;
                        lblTurma.Text = lista[i].Turma;
                        pxFoto.Image = Image.FromFile(@"C:\Users\Aluno.LAB06-49\Pictures\" + lista[i].Foto);
                        i = 3;
                    }
                    else
                    {
                        lblCandidato.Text = "VOTO NULO";
                    }
                    lblMensagem.Visible = true;
                    btnConfirma.Visible = true;
                }
            }
        }
    }
}
