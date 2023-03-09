using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RS_07_02_2023_saldumuaprekinasana
{
    public partial class Form1 : Form
    {
        double cena = 0.00;
        public Form1()
        {
            InitializeComponent();
        }

        // tiek piefikseta informacija no ievades lodziniem, ierakstita .txt faila un pec pogas nospiesanas saglabata mape
        public void ceks()

        {
            string vards = this.varda_tbox.Text;
            string failanosaukums = vards + "_" + DateTime.Now.ToString("dd_MM_yyyy") + "_ceks.txt";
            string ceka_izdrukas_laiks = DateTime.Now.ToString("dd.MM.yyyy HH.MM.ss");
            string naudas_daudzums = Convert.ToString(naudas_daudzums_tbox.Text);
            string kg_daudzums = Convert.ToString(kg_daudzums_tbox.Text);

            StreamWriter ierakstisana_faila = new StreamWriter(failanosaukums);
            ierakstisana_faila.WriteLine("Čeks izdrukāts:" + ceka_izdrukas_laiks);
            ierakstisana_faila.WriteLine("Klienta vārds:" + vards);
            ierakstisana_faila.WriteLine("Klients iegādājās:" + kg_daudzums + " KG konfekšu");
            ierakstisana_faila.WriteLine("Samaksa par iegādātajām konfektēm:" + naudas_daudzums + " EUR");
            ierakstisana_faila.Close();
        }
        // globala funkcija aprekinu veiksanai
        public void aprekinasana(double cena)
        {
            double naudas_daudzums = Convert.ToDouble(naudas_daudzums_tbox.Text);
            double kilogramu_daudzums = naudas_daudzums / cena;
            kilogramu_daudzums = Math.Round(kilogramu_daudzums, 2);
            this.kg_daudzums_tbox.Text = kilogramu_daudzums.ToString();
        }

        // funkcija, kas parbauda iezimetos checkboxus, pec ta nosaka kopejo cenu un veic aprekinus
        public void aprekinu_izpilde()
        {   
            
             if (selga.Checked == false && jurakonfekte.Checked == false && serenade.Checked == false)
            {
                MessageBox.Show("Jus neesat atzimejis nevienu lodzinu");
            }
            else if (jurakonfekte.Checked == false && selga.Checked == false && serenade.Checked == true)
            {
                cena = 6.55;
                aprekinasana(cena);
            }

            else if (jurakonfekte.Checked == false && selga.Checked == true && serenade.Checked == false)
            {
                cena = 7.64;
                aprekinasana(cena);
            }

            else if (jurakonfekte.Checked == true && selga.Checked == false && serenade.Checked == false)
            {
                cena = 3.23;
                aprekinasana(cena);
            }
            else if (jurakonfekte.Checked == true && selga.Checked == true && serenade.Checked == false)
            {
                cena = 3.23 + 7.64;
                aprekinasana(cena);
            }
            else if (jurakonfekte.Checked == true && selga.Checked == true && serenade.Checked == true)
            {
                cena = 3.23 + 7.64 + 6.55;
                aprekinasana(cena);
            }
            else if (jurakonfekte.Checked == true && serenade.Checked == true && selga.Checked == false)
            {
                cena = 3.23 + 6.55;
                aprekinasana(cena);
            }
            else if (selga.Checked == true && serenade.Checked == true && jurakonfekte.Checked == false)
            {
                cena = 7.64 + 6.55;
                aprekinasana(cena);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // pec pogas nospiesanas veic aprekinus, piefikse datus un izdruka ceku
        private void button1_Click(object sender, EventArgs e)
        {
            aprekinu_izpilde();
            ceks();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
