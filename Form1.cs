using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown_EkranAlintisiAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt32(numericUpDown1.Value);
            int ikinci = Convert.ToInt32(numericUpDown2.Value);
            int toplam = ilk + ikinci;
            label5.Text=toplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt32(numericUpDown1.Value);
            int ikinci = Convert.ToInt32(numericUpDown2.Value);
            int toplam = ilk - ikinci;
            label5.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt32(numericUpDown1.Value);
            int ikinci = Convert.ToInt32(numericUpDown2.Value);
            int toplam = ilk * ikinci;
            label5.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt32(numericUpDown1.Value);
            int ikinci = Convert.ToInt32(numericUpDown2.Value);
            int toplam = ilk / ikinci;
            label5.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 git=new Form2();
            git.Show();
            this.Hide();
        }
    }
}
