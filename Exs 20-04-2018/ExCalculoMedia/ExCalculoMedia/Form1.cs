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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAluno_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1Bim_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2Bim_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl4Bim_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txb1Bim.Text);
            double dNum2 = System.Convert.ToDouble(txb2Bim.Text);
            double dNum3 = System.Convert.ToDouble(txb3Bim.Text);
            double dNum4 = System.Convert.ToDouble(txb4Bim.Text);
            double dSoma = (dNum1 + dNum2 + dNum3 + dNum4) / 4;
            lblResultado.Text = dSoma.ToString();
            String sNome = System.Convert.ToString(txbNome.Text);
            lblNome.Text = sNome.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmMedia_Load(object sender, EventArgs e)
        {

        }
    }
}
