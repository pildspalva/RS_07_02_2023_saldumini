using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS_07_02_2023_saldumuaprekinasana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void aprekinasana()
        {
            if (serenade.Checked == true) 
            {
                double naudas_daudzums = Convert.ToDouble(textBox1.Text);
                double nauda = naudas_daudzums;
                double cena = 6.55;
                double kilogramu_daudzums = naudas_daudzums / cena;
                label3.Text = kilogramu_daudzums.ToString();
            }

            else if (selga.Checked == true)
            {
                double naudas_daudzums = Convert.ToDouble(textBox1.Text);
                double nauda = naudas_daudzums;
                double cena = 7.64;
                double kilogramu_daudzums = naudas_daudzums / cena;
                label3.Text = kilogramu_daudzums.ToString();
            }

            else if (jurakonfekte.Checked == true)
            {
                double naudas_daudzums = Convert.ToDouble(textBox1.Text);
                double nauda = naudas_daudzums;
                double cena = 3.23;
                double kilogramu_daudzums = naudas_daudzums / cena;
                label3.Text = kilogramu_daudzums.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aprekinasana();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jurakonfekte_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
