using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    

    public partial class Form1 : Form
    {
        int sayi1;
        int sayi2;
        int sonuç;
        int seçim;


        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("8");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi2=int.Parse(textBox1.Text);

            if (seçim == 1) sonuç = sayi1 + sayi2; textBox1.Text=(""+sonuç);
            if (seçim == 2) sonuç = sayi1 - sayi2; textBox1.Text = ("" + sonuç);
            if (seçim == 3) sonuç = sayi1 * sayi2; textBox1.Text = ("" + sonuç);
            if (seçim == 4) sonuç = sayi1 / sayi2; textBox1.Text = ("" + sonuç);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+("2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1= int.Parse(textBox1.Text);
            seçim = 1;
            textBox1.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(textBox1.Text);
            seçim = 2;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(textBox1.Text);
            seçim = 3;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(textBox1.Text);
            seçim = 4;
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            textBox1.Text = "0";

        }
    }
}
