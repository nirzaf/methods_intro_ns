using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace methods_intro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_class.my_msg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            //----------------------------
            Int32.TryParse(this.first_numtextBox1.Text, out fn);
            Int32.TryParse(this.second_numtextBox2.Text, out sn);

            this.result_textBox3.Text = my_class.sum_cal_par(fn, sn).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.result_textBox3.Text = my_class.sum_cal_textbox(this.first_numtextBox1, this.second_numtextBox2).ToString();
        }
    }
}
