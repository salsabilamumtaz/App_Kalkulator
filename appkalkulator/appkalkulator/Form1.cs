using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appkalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;
            bil1 = int.Parse(txt_bil1.Text);
            bil2 = int.Parse(txt_bil2.Text);
            hasil = bil1 + bil2;
            txt_hasil.Text = hasil.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;
            bil1 = int.Parse(txt_bil1.Text);
            bil2 = int.Parse(txt_bil2.Text);
            hasil = bil1 - bil2;
            txt_hasil.Text = hasil.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;
            bil1 = int.Parse(txt_bil1.Text);
            bil2 = int.Parse(txt_bil2.Text);
            hasil = bil1 * bil2;
            txt_hasil.Text = hasil.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bil1 ;
            double bil2, hasil;
            bil1 = int.Parse(txt_bil1.Text);
            bil2 = int.Parse(txt_bil2.Text);
            hasil = bil1 / bil2;
            txt_hasil.Text = hasil.ToString();

        }
    }
}
