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
        public string value;
        public static Form1 instance;
        public string btn; //birleştirilecek

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_E_11.Visible = true;
            btn_E_12.Visible = true;
            btn_E_13.Visible = true;
            btn_E_14.Visible = true;
            btn_E_15.Visible = true;
            btn_E_16.Visible = true;
            btn_E_17.Visible = true;

            //BARIŞ
            //Elektrik elektrik = new Elektrik();
            //elektrik.ShowDialog();

            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }

        }
        private void btn_E_11_Click(object sender, EventArgs e)   //7 tane buton birleştirilecek
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "1";
            transformer1.Text = "Teias Eskisehir Trafo Merkezi.";
            transformer1.ShowDialog();




        }

        private void btn_E_12_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "2";
            transformer1.Text = "Camlica Tombakzade Sk. Trafo Merkezi.";
            transformer1.ShowDialog();
        }

        private void btn_E_13_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "3";
            transformer1.Text = "Buyukdere Nisan Sk. Trafo Merkezi.";
            transformer1.ShowDialog();
        }

        private void btn_E_14_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "4";
            transformer1.Text = "Istiklal Metin Bey Sk. Trafo Merkezi.";
            transformer1.ShowDialog();
        }

        private void btn_E_15_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "5";
            transformer1.Text = "Uluonder Ideal Sk. Trafo Merkezi.";
            transformer1.ShowDialog();
        }

        private void btn_E_16_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "6";
            transformer1.Text = "Orta Cumhuriyet Cad. Trafo Merkezi.";
            transformer1.ShowDialog();
        }

        private void btn_E_17_Click(object sender, EventArgs e)
        {
            Elektrik transformer1 = new Elektrik();
            transformer1.btn = "7";
            transformer1.Text = "75. Yil Mah. Gaziantep Sk. Trafo Merkezi.";
            transformer1.ShowDialog();
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
            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }
           

            btn_E_11.Visible = false;
            btn_E_12.Visible = false;
            btn_E_13.Visible = false;
            btn_E_14.Visible = false;
            btn_E_15.Visible = false;
            btn_E_16.Visible = false;
            btn_E_17.Visible = false;


        }
        private void btn_N_1_Click(object sender, EventArgs e)
        {
            selected_button = btn_N_1.Name;
            Doğalgaz d = new Doğalgaz();
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = true;
                WWL[i].Visible = true;
            }
            btn_E_11.Visible = false;
            btn_E_12.Visible = false;
            btn_E_13.Visible = false;
            btn_E_14.Visible = false;
            btn_E_15.Visible = false;
            btn_E_16.Visible = false;
            btn_E_17.Visible = false;

        }
        private void btn_WW_1_Click(object sender, EventArgs e)
        {
            value = "One";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_2_Click(object sender, EventArgs e)
        {
            value = "Two";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_3_Click(object sender, EventArgs e)
        {
            value = "Three";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_4_Click(object sender, EventArgs e)
        {
            value = "Four";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_5_Click(object sender, EventArgs e)
        {
            value = "Five";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_6_Click(object sender, EventArgs e)
        {
            value = "Six";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        private void btn_WW_7_Click(object sender, EventArgs e)
        {
            value = "Seven";
            WasteWater form3 = new WasteWater();
            form3.ShowDialog();
        }

        //////////////////////////////Sude Akkaya Kodları
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                btn_WD_1.Visible = true;
                btn_WD_2sarısungurgoleti.Visible = true;
                btn_WD_3porsukbarajı.Visible = true;
                btn_WD_4.Visible = true;
                btn_WD_5.Visible = true;
                btn_WD_6.Visible = true;
                btn_WD_7.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;
                lbl7.Visible = true;
            }
            else
            {
                btn_WD_1.Visible = false;
                btn_WD_2sarısungurgoleti.Visible = false;
                btn_WD_3porsukbarajı.Visible = false;
                btn_WD_4.Visible = false;
                btn_WD_5.Visible = false;
                btn_WD_6.Visible = false;
                btn_WD_7.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                lbl6.Visible = false;
                lbl7.Visible = false;
            }

            List<Button> WWB = new List<Button>() { btn_WW_1, btn_WW_2, btn_WW_3, btn_WW_4, btn_WW_5, btn_WW_6, btn_WW_7 };
            List<Label> WWL = new List<Label>() { label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < WWB.Count(); i++)
            {
                WWB[i].Visible = false;
                WWL[i].Visible = false;
            }
            btn_E_11.Visible = false;
            btn_E_12.Visible = false;
            btn_E_13.Visible = false;
            btn_E_14.Visible = false;
            btn_E_15.Visible = false;
            btn_E_16.Visible = false;
            btn_E_17.Visible = false;


        }
        private void btn_WD_6_Click(object sender, EventArgs e)
        {
            WaterDistribution2 w2 = new WaterDistribution2();
            w2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "";
        }

        private void btn_WD_5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Çukurhisar Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();
           
        }

        private void btn_WD_7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Gazipaşa Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();
           
        }

        private void btn_WD_3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Zincirlikuyu Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();

        }

        private void btn_WD_1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Karacahöyük Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();
        }

        private void btn_WD_2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Sarısungur Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();
        }

        private void btn_WD_4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btnName = "Porsuk Su Deposu";
            Properties.Settings.Default.Save();
            WaterDistribution w1 = new WaterDistribution();
            w1.Show();
        }

     
        //////////////////////////////Sude Akkaya Kodları
    }
}
