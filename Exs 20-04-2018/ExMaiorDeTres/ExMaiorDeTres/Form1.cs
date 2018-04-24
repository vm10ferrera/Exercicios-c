using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbValorA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbValorB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbValorC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);
            double ValorC = System.Convert.ToDouble(txbValorC.Text);
            
            if (ValorA > ValorB && ValorA > ValorC)
            {
            lblResposta.Text = "O maior valor é A.";
            }

            if (ValorB > ValorA && ValorB > ValorC)
            {
                lblResposta.Text = "O maior valor é B.";
            }
            
            if (ValorC > ValorA && ValorC > ValorB)
            {
                lblResposta.Text = "O maior valor é C.";
            }
            
            if (ValorA == ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "Os maiores valores são A e B.";
            }

            if (ValorA == ValorC && ValorA > ValorB)
            {
                lblResposta.Text = "Os maiores valores são A e C.";
            }

            if (ValorB == ValorC && ValorB > ValorA)
            {
                lblResposta.Text = "Os maiores valores são B e C.";
            }

            if (ValorA == ValorB && ValorA == ValorC)
            {
                lblResposta.Text = "Os valores são iguais.";
            }

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
