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
        public string value;
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_E_1.Visible = true;
            
            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_N_1.Visible = true;
           
            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = true;
                WWL[i].Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            btn_WD_1.Visible = true;

            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }
        }

        private void btn_WW_1_Click(object sender, EventArgs e)
        {
            value = "0ne";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_2_Click(object sender, EventArgs e)
        {
            value = "Two";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_3_Click(object sender, EventArgs e)
        {
            value = "Three";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_4_Click(object sender, EventArgs e)
        {
            value = "Four";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_5_Click(object sender, EventArgs e)
        {
            value = "Five";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_6_Click(object sender, EventArgs e)
        {
            value = "Six";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_7_Click(object sender, EventArgs e)
        {
            value = "Seven";
            Hide();
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }
    }
}
