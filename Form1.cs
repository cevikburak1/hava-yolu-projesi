using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("NEREDEN : " + comboBox1.Text);
            listBox1.Items.Add("NEREYE : " + comboBox2.Text);
            listBox1.Items.Add("TARİH : " + maskedTextBox1.Text);
            listBox1.Items.Add("SAAT : " + maskedTextBox2.Text);
            listBox1.Items.Add("YOLCU AD SOYAD : " + textBox1.Text);
            listBox1.Items.Add("TC: " + maskedTextBox3.Text);
            listBox1.Items.Add("TELEFON : " + maskedTextBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
