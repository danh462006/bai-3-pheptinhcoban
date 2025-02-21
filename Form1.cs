using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            tinhtongnew();
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

                txtketqua.Text = (so1 / so2).ToString();
            }

        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtso1.Text = trbSo1.Value.ToString();

        }

        private void trbSo2_Scroll(object sender, EventArgs e)
        {
            txtso2.Text = trbSo2.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            double so3 = Convert.ToDouble(txtSo3.Text);
            int so4 = Convert.ToInt32(txtSo4.Text);
            double kqluythua = so3;
           

            for (int i = 1; i < so4; i++)
            {
                
                kqluythua *=   so3;
               
            }
            
            Txtkqluythua.Text = kqluythua.ToString();
        } void tinhtongnew ()
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double kp = so1 + so2;
            txtketqua.Text = kp.ToString();
        }

    }
} 