using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNP3_Simulation
{
    public partial class Form1 : Form
    {
        public static string selected_button;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_E_1.Visible = true;
            
            //BARIŞ
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                btn_N_1.Visible = true;
                btn_N_2.Visible = true;
                btn_N_3.Visible = true;
                btn_N_4.Visible = true;
                btn_N_5.Visible = true;
                btn_N_6.Visible = true;
                btn_N_7.Visible = true;
            }
            else
            {
                btn_N_1.Visible = false;
                btn_N_2.Visible = false;
                btn_N_3.Visible = false;
                btn_N_4.Visible = false;
                btn_N_5.Visible = false;
                btn_N_6.Visible = false;
                btn_N_7.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btn_WW_1.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            btn_WD_1.Visible = true;
        }

        private void btn_N_1_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_1.Name;
            Doğalgaz d=new Doğalgaz();
            d.Show();
        }
        private void btn_N_2_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_2.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();
            
        }
        private void btn_N_3_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_3.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();
       
        }
        private void btn_N_4_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_4.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();

        }
        private void btn_N_5_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_5.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();
        }
        private void btn_N_6_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_6.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();
        }
        private void btn_N_7_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_7.Name;
            Doğalgaz d = new Doğalgaz();
            d.Show();
        }
    }
}
