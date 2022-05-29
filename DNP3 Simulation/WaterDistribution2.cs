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
    public partial class WaterDistribution2 : Form
    {
        public WaterDistribution2()
        {
            InitializeComponent();
        }

       
        DataTable tablo = new DataTable();
        private void WaterDistribution2_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Madde", typeof(string));
            tablo.Columns.Add("Miktar", typeof(string));
            tablo.Columns.Add("MaxMiktar", typeof(string));
            
            tablo.Rows.Add("NTU", "0129", "1.0");
            tablo.Rows.Add("pH", "7,41", "6.5 - 7.5");
            tablo.Rows.Add("Amonyum mg/L", "<0,05", "0,5");
            tablo.Rows.Add("Nitrit mg/L", "0.02", "0,5");
            tablo.Rows.Add("Klorür mg/L", "28", "250");
            tablo.Rows.Add("Demir mg/L", "7,7", "200");
            tablo.Rows.Add("Civa mg/L", "<0,2", "1,0");
            tablo.Rows.Add("Siyanür mg/L", "0.29", "1");
            tablo.Rows.Add("Toplam Sertlik FR°", "16", "-");
            tablo.Rows.Add("İletkenlik µS/cm", "534", "2500");
            dataGridView1.DataSource = tablo;

            
        }

       
    }
}
