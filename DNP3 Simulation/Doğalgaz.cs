using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DNP3_Simulation
{
    public partial class Doğalgaz : Form
    {
       public string dosya = "NaturalGas.xml";
        public Doğalgaz()
        {
            InitializeComponent();
        }

        private void Doğalgaz_Load(object sender, EventArgs e)
        {

            
            //Kullanıcı bilgilerininin belirtilen belgeden kkontrolünü sağlar.

            Yazdır();
            txt12.Text = DateTime.Now.ToString();
        }
        public void Yazdır()
        {
            
            XDocument xdosya = XDocument.Load(dosya);
            XElement rootElement = xdosya.Root;

            foreach (XElement istasyon in rootElement.Elements())
            {
                if (Form1.selected_button.Equals(istasyon.Element("Name").Value))
                {
                    txt1.Text = (istasyon.Element("Giriş_Basıncı").Value);
   
                    if (Convert.ToDouble(istasyon.Element("Giriş_Basıncı").Value) < 35.0 || Convert.ToDouble(istasyon.Element("Giriş_Basıncı").Value) > 70.0)
                    {
                    txt1.BackColor = Color.Red; 
                    }
                    else
                    {
                        txt1.BackColor = Color.White;
                    }


                    txt2.Text = istasyon.Element("Çıkış_Basıncı").Value;
                    if (Convert.ToDouble((istasyon.Element("Çıkış_Basıncı").Value)) < 12.0 || Convert.ToDouble(istasyon.Element("Çıkış_Basıncı").Value) > 20.0)
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else
                    {
                        txt2.BackColor = Color.White;
                    }


                    txt3.Text = istasyon.Element("Gaz_Sıcaklığı").Value;
                    if (int.Parse((istasyon.Element("Gaz_Sıcaklığı").Value)) < -20 || int.Parse(istasyon.Element("Gaz_Sıcaklığı").Value) > 40)
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else
                    {
                        txt3.BackColor = Color.White;
                    }


                    txt4.Text = istasyon.Element("Regülatör_Hız").Value;
                    if (double.Parse((istasyon.Element("Regülatör_Hız").Value)) > 20.0 )
                    {
                        txt4.BackColor = Color.Red;
                    }
                    else
                    {
                        txt4.BackColor = Color.White;
                    }


                    txt5.Text = istasyon.Element("Tahliye_Hız").Value;
                    if (double.Parse((istasyon.Element("Tahliye_Hız").Value)) > 30.0)
                    {
                        txt5.BackColor = Color.Red;
                    }
                    else
                    {
                        txt5.BackColor = Color.White;
                    }


                    txt6.Text = istasyon.Element("İstasyon_kapak_açık").Value;
                    if (bool.Parse((istasyon.Element("İstasyon_kapak_açık").Value).ToString())==false)
                    {
                        txt6.BackColor = Color.Red;
                    }
                    else
                    {
                        txt6.BackColor = Color.White;
                    }


                    txt7.Text = istasyon.Element("Pano_kapak_açık").Value;
                    if (bool.Parse((istasyon.Element("Pano_kapak_açık").Value).ToString()) == false)
                    {
                        txt7.BackColor = Color.Red;
                    }
                    else
                    {
                        txt7.BackColor = Color.White;
                    }


                    txt8.Text = istasyon.Element("Regülâtör_arızalı").Value;
                    if (bool.Parse((istasyon.Element("Regülâtör_arızalı").Value).ToString()) == true)
                    {
                        txt8.BackColor = Color.Red;
                    }
                    else
                    {
                        txt8.BackColor = Color.White;
                    }


                    txt9.Text = istasyon.Element("Hat1_filtre_kirli").Value;
                    if (bool.Parse((istasyon.Element("Hat1_filtre_kirli").Value).ToString()) == true)
                    {
                        txt9.BackColor = Color.Red;
                    }
                    else
                    {
                        txt9.BackColor = Color.White;
                    }


                    txt10.Text = istasyon.Element("Hat2_filtre_kirli").Value;
                    if (bool.Parse((istasyon.Element("Hat2_filtre_kirli").Value).ToString()) == true)
                    {
                        txt10.BackColor = Color.Red;
                    }
                    else
                    {
                        txt10.BackColor = Color.White;
                    }

                    txt11.Text = istasyon.Element("Slam_Shut_durum").Value;
                    if (bool.Parse((istasyon.Element("Slam_Shut_durum").Value).ToString()) == true)
                    {
                        txt11.BackColor = Color.Red;
                    }
                    else
                    {
                        txt11.BackColor = Color.White;
                    }


                    break;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bool Gb_damage = false;
            bool R_damage = false;
            XDocument xdosya = XDocument.Load(dosya);
            XElement rootElement = xdosya.Root;
            Random rastgele = new Random();
            
            foreach (XElement istasyon in rootElement.Elements())
            {
                if (Form1.selected_button.Equals(istasyon.Element("Name").Value))
                {
                    istasyon.Element("Giriş_Basıncı").Value= (rastgele.Next(34,72)+rastgele.NextDouble()).ToString();
                   istasyon.Element("Çıkış_Basıncı").Value = (rastgele.Next(12, 20) + rastgele.NextDouble()).ToString();
                   istasyon.Element("Gaz_Sıcaklığı").Value = rastgele.Next(-25, 42).ToString();
                   istasyon.Element("Regülatör_Hız").Value = (rastgele.Next(0, 25) + rastgele.NextDouble()).ToString();
                   istasyon.Element("Tahliye_Hız").Value = (rastgele.Next(0, 30) + rastgele.NextDouble()).ToString();
                    xdosya.Save(@"NaturalGas.xml");
                    if (double.Parse((istasyon.Element("Giriş_Basıncı").Value))<35.0 || double.Parse(istasyon.Element("Giriş_Basıncı").Value)>70.0)
                    {
                        istasyon.Element("İstasyon_kapak_açık").Value = "false";
                        Gb_damage = true;
              
                    }
                    else
                    {
                        istasyon.Element("İstasyon_kapak_açık").Value = "true";
                    }

                    if (Gb_damage == true || double.Parse(istasyon.Element("Çıkış_Basıncı").Value) < 12.0 || double.Parse(istasyon.Element("Çıkış_Basıncı").Value) > 20.0 ||
                      int.Parse(istasyon.Element("Gaz_Sıcaklığı").Value) > 40 || int.Parse(istasyon.Element("Gaz_Sıcaklığı").Value) < -20)
                    {
                      
                        istasyon.Element("Pano_kapak_açık").Value = (false).ToString();
                    }
                    else
                    {
                        istasyon.Element("Pano_kapak_açık").Value = (true).ToString();
                    }


                    if (double.Parse(istasyon.Element("Regülatör_Hız").Value) > 20)
                    {
                        istasyon.Element("Regülâtör_arızalı").Value = "true";
                        R_damage = true;
                    }
                    else
                    {
                        istasyon.Element("Regülâtör_arızalı").Value = "false";
                    }
                   
                
                    if (int.Parse(rastgele.Next(0, 1).ToString()) == 1)
                    {
                        istasyon.Element("Hat1_filtre_kirli").Value = (true).ToString();
                    }
                    else
                    {
                        istasyon.Element("Hat1_filtre_kirli").Value = (false).ToString();
                    }


                    if (int.Parse(rastgele.Next(0, 1).ToString()) == 1)
                    {
                        istasyon.Element("Hat2_filtre_kirli").Value = (true).ToString();
                    }
                    else
                    {
                        istasyon.Element("Hat2_filtre_kirli").Value=(false).ToString();
                    }

                    if (Gb_damage == true || double.Parse(istasyon.Element("Çıkış_Basıncı").Value) < 12.0 || double.Parse(istasyon.Element("Çıkış_Basıncı").Value) > 20.0 ||
                      int.Parse(istasyon.Element("Gaz_Sıcaklığı").Value )> 40 || int.Parse(istasyon.Element("Gaz_Sıcaklığı").Value) < -20 
                      || R_damage == true || bool.Parse(istasyon.Element("Pano_kapak_açık").Value) == false)
                    {
                        istasyon.Element("Slam_Shut_durum").Value = "true";
                    }
                    else
                    {
                        istasyon.Element("Slam_Shut_durum").Value = "false";
                    }
                    break;
                }
            }

            xdosya.Save(@"NaturalGas.xml");
            Yazdır();
            txt12.Text = DateTime.Now.ToString();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            btn_Refresh_Click( sender,  e);
        }
    }
}
