using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DNP3_Simulation
{
    public partial class WaterDistribution : Form
    {
        public WaterDistribution()
        {
            InitializeComponent();
       
        }
        int sayac1,sayac2;
        int flag = 0;
        
        //SU SEVİYESİNİ RANDOM HESAPLAYAN FONKSİYON
        private void Random_Su_Seviyesi_Debi()
        {
            if (flag == 0)
            {

                Random random = new Random();
                int number1 = random.Next(65, 75);
                int number2 = random.Next(94, 96);
                XML_Su(number1,number2);
            }
        }
        private void Random_Hata()
        {
            if (flag == 0)
            {
                Random random = new Random();
                int hataOran = random.Next(0, 6);
                if (hataOran == 5)
                {
                    flag = 1;
                    label13.Text = "43 L/sn";

                    MessageBox.Show("Debi Çok Düşük! Fiziki Kaçak Kontrol Ekibi Yönlendiriliyor.");
                    flag = 0;
                    
                }
            }
        }
        //SUYUN KİRLİLİK SEVİYESİNİ RANDOM HESAPLAYAN FONKSİYON
        private void Random_Bulanıklık_Seviyesi()
        {
            if (flag == 0)
            {
                Random random = new Random();
                int number = random.Next(28, 33);
                XML_Bulaniklik(number);
            }
        }
       
        //XML DOSYALARI AÇILMAZSA AÇAN VE TIMER BAŞLATAN FONKSİYON
        private void WaterDistribution_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.btnName;
            timer1.Interval = 1500;
            timer1.Start();
            timer2.Interval = 2000;
            timer2.Start();
            timer3.Interval = 3000;
            timer3.Start();
            
            if (!File.Exists("WaterDistribution.xml"))
            {
                XmlTextWriter dosya = new XmlTextWriter(@"WaterDistribution.xml", Encoding.UTF8);
                dosya.Formatting = Formatting.Indented;
                dosya.WriteStartDocument();
                dosya.WriteStartElement("Info");
                dosya.WriteEndElement();
                dosya.Close();
            }
            if (!File.Exists("WaterDistribution2.xml"))
            {
                XmlTextWriter dosya = new XmlTextWriter(@"WaterDistribution2.xml", Encoding.UTF8);
                dosya.Formatting = Formatting.Indented;
                dosya.WriteStartDocument();
                dosya.WriteStartElement("Info");
                dosya.WriteEndElement();
                dosya.Close();
            }
        }
       //TIMER VE SAYAÇ SIFIRLAYAN FONKSİYON
        private void WaterDistribution_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            sayac1 = 0;
            sayac2 = 0;
         
        }
        //TIMER İLERLETEN FONKSİYON
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random_Su_Seviyesi_Debi();

            sayac1++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random_Bulanıklık_Seviyesi();
            Random_Hata();
            sayac2++;
        }
        ////VANALARI AÇIP KAPATAN FONKSİYON
        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "Kapalı";
            label11.Visible = true;
            label14.Visible = true;
            flag = 1;
            
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "Açık";
            flag = 0;
            label11.Visible = false;
        }


        int batarya = 100;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                batarya--;
                label17.Text = "%" + batarya.ToString();

                if (batarya <= 35)
                {
                    MessageBox.Show("Batarya Dolumu Yapılıyor Birkaç Saniye Bekleyin");
                    batarya = 100;
                    MessageBox.Show("Batarya Dolumu Yapıldı");
                }
            }
        }

        //XML DOSYALARINA YAZMA VE OKUMA YAPAN FONKSİYON
        private void XML_Su(int n1, int n2)
        {
            //DOSYAYI AÇAR VE RANDOM VERİYİ KAYDEDER
            XDocument xdosya = XDocument.Load("WaterDistribution.xml");
            XElement rootElement = xdosya.Root;
            XElement element = new XElement("Info");
            XElement SuSeviyesi = new XElement("SuSeviyesi", n1);
            XElement Debi = new XElement("Debi", n2);
            element.Add(SuSeviyesi,Debi);
           
            rootElement.Add(element);
            xdosya.Save(@"WaterDistribution.xml");


            //DOSYADAKİ BİLGİYİ ÇEKER VE LABEL'A YAZDIRIR
            foreach (XElement bilgi in rootElement.Elements())
            {
                if (n1.ToString() == bilgi.Element("SuSeviyesi").Value)
                {
                    string sayi1 = bilgi.Element("SuSeviyesi").Value;
                    label2.Text = "%" + sayi1;
                    progressBar1.Value = int.Parse(sayi1);
                }
               
                else
                {
                    label13.Text = n2.ToString() + "L/sn";
                }

            }
        }

       

        private void XML_Bulaniklik(int n)
        {
            //DOSYAYI AÇAR VE RANDOM VERİYİ KAYDEDER
            XDocument xdosya = XDocument.Load("WaterDistribution2.xml");
            XElement rootElement = xdosya.Root;
            XElement element = new XElement("Info");
            XElement BulaniklikSeviyesi = new XElement("BulaniklikSeviyesi", n);

            element.Add(BulaniklikSeviyesi);
            rootElement.Add(element);
            xdosya.Save(@"WaterDistribution2.xml");


            //DOSYADAKİ BİLGİYİ ÇEKER VE LABEL'A YAZDIRIR
            foreach (XElement bilgi in rootElement.Elements())
            {
                string sayi = bilgi.Element("BulaniklikSeviyesi").Value;

                label6.Text = "0." + sayi + " NTU";
                progressBar2.Value = int.Parse(sayi);
            }
        }

    }
}
