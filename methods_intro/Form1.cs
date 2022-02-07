using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace methods_intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.result_textBox3.Text =sum_cal().ToString() ;
            Int32 fn;
            Int32 sn;
            //----------------------------
            Int32.TryParse(this.first_numtextBox1.Text, out fn);
            Int32.TryParse(this.second_numtextBox2.Text, out sn);

            this.result_textBox3.Text =my_class.sum_cal_par(fn, sn).ToString();
        }

      

        public Int32 sum_cal()
        {
            Int32 fn;
            Int32 sn;
            Int32 rn;
            //----------------------------
            Int32.TryParse(this.first_numtextBox1.Text, out fn);
            Int32.TryParse(this.second_numtextBox2.Text, out sn);
            //----------------------------
            rn = fn + sn;
            return rn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum_cal_2();
        }
        public void sum_cal_2()
        {
            Int32 fn;
            Int32 sn;
            Int32 rn;
            //----------------------------
            Int32.TryParse(this.first_numtextBox1.Text, out fn);
            Int32.TryParse(this.second_numtextBox2.Text, out sn);
            //----------------------------
            rn = fn + sn;
            this.result_textBox3.Text = rn.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // my_msg();
            my_class.my_msg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.result_textBox3.Text = my_class.sum_cal_textbox(this.first_numtextBox1 , this.second_numtextBox2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            my_class.msg_textbox(this.textBox1);
        }
    }
}
