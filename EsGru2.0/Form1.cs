using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace EsGru2._0
{
    public partial class Form1 : Form
    {
        private Carta carta1;
        private ContoCorrente conto;
        public Form1()
        {
            InitializeComponent();
            conto = new ContoCorrente("giovanni", "no", 1000.0);
            carta1 = new Carta(conto, "12345", "777");
            label2.Text = Convert.ToString(conto.Saldo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void InviaDenaro_Click(object sender, EventArgs e)
        {
            carta1.InviaDenaro(Convert.ToDouble(numericUpDown1.Value));
            label2.Text = Convert.ToString(conto.Saldo);

        }

        private void RiceviDenaro_Click(object sender, EventArgs e)
        {
            decimal quantitaDenaro = numericUpDown1.Value;
            double denaroDouble = (double)quantitaDenaro;
            carta1.PrelevaDenaro(denaroDouble);
            label2.Text = Convert.ToString(conto.Saldo);

        }

        private void QTAdenaro_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
