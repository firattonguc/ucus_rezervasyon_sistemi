using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucus_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("rota:" + comboBox1.Text + "-" + comboBox2.Text + "tarih:" + dateTimePicker1.Text + "saat:" + maskedTextBox1.Text + "yolcu bilgileri // ad:" + textBox1.Text + "tc:" + maskedTextBox2.Text + "telefon:" + maskedTextBox3.Text);
            MessageBox.Show("yolcu kaydı yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
