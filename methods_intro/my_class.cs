using System;
using System.Collections.Generic;
using System.Text;

namespace methods_intro
{
  public static  class my_class
    {
        public static void my_msg()
        {
            System.Windows.Forms.MessageBox.Show("Hi;I'm Within Happy Method!!!");
        }

        public static  Int32 sum_cal_par(Int32 f_num, Int32 s_num)
        {

            Int32 rn;
            //----------------------------
            rn = f_num +s_num;
            return rn;
        }

        public static Int32 sum_cal_textbox(  System.Windows.Forms.TextBox fn_textbox ,System.Windows.Forms.TextBox sn_textbox)
        {
            Int32 f_num;
            Int32 s_num;
            Int32.TryParse(fn_textbox.Text, out f_num);
            Int32.TryParse(sn_textbox.Text, out s_num);
            //----------------------------
            Int32 r;
            r = f_num + s_num;
            return r;
        }

        public static void msg_textbox(System.Windows.Forms.TextBox tb)
        {
            string t;
            t = tb.Text;
            System.Windows.Forms.MessageBox.Show(t);
        }

    }
}
