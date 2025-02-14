using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bai_3_pheptinhcoban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 + so2;
            txtketqua.Text = tong.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 - so2;
            txtketqua.Text = tong.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 * so2;
            txtketqua.Text = tong.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
          if (so2 == 0)
            {
                MessageBox.Show("không thế chia cho 0");
                txtso2.Text = "";
            }
            else
            {
                
               txtketqua.Text = (so1/so2) . ToString();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            if (so1 == 0)
            {
                if (so2 == 0)
                {
                    Console.WriteLine("phương trình có vô số nghiệm ");
                }
                else
                {
                    Console.WriteLine("phương trình vô nghiệm");
                }
            }
            else
            {
                txtketqua.Text = (-so2 / so1).ToString();      
                Console.WriteLine("phương trình có nhiệm là : " + x);
            }
        }
}
