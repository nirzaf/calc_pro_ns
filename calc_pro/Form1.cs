using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // this.label1.Text = "";
            this.main_num_label1.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text =this.main_num_label1.Text+ "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            //----------------------------------
            if (this.main_num_label1.Text!="")
            {
                this.first_num_label .Text = this.main_num_label1.Text;
            }
           //-----------------------------------
            this.main_num_label1.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            //----------------------------------
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            //-----------------------------------
            this.main_num_label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            this.operator_label.Text = "*";
            //----------------------------------
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            //-----------------------------------
            this.main_num_label1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";
            //----------------------------------
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            //-----------------------------------
            this.main_num_label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r;
            //--------------------
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label1.Text, out sn);
            r = 0;
            //--------------------
            if (this.operator_label.Text=="+")
            {
                r = fn + sn;
            }
            //------------------------------
            if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }
            //------------------------------
            if (this.operator_label.Text == "*")
            {
                r = fn * sn;
            }
            //------------------------------
            if (this.operator_label.Text == "%")
            {
                r = fn / sn;
            }
            //---------------------------------
            this.main_num_label1.Text = r.ToString();
            this.operator_label.Text = "";
            this.first_num_label.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text = this.main_num_label1.Text + ".";
        }
    }
}
