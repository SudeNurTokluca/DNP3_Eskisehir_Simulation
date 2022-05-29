using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net.Mail;

namespace DNP3_Simulation
{
    public partial class WasteWater : Form
    {
        public WasteWater()
        {
            InitializeComponent();
        }

        double num;

        private void WasteWater_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("MMM dd yyyy,hh:mm:ss");

            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Wastewater.xml");

            string value = Form1.instance.value;
            string place = "//" + value.ToString();

            foreach (XmlNode node in doc.SelectNodes(place))
            {
                temperature.Text = node.SelectSingleNode("Temperature").InnerText;
                tds.Text = node.SelectSingleNode("TDS").InnerText;
                conductivity.Text = node.SelectSingleNode("Conductivity").InnerText;
                colour.Text = node.SelectSingleNode("Colour").InnerText;
                tss.Text = node.SelectSingleNode("TSS").InnerText;
                turbidity.Text = node.SelectSingleNode("Turbidity").InnerText;
                dissolvedoxygen.Text = node.SelectSingleNode("DO").InnerText;
                pH.Text = node.SelectSingleNode("pH").InnerText;
                bod.Text = node.SelectSingleNode("BOD").InnerText;
                cod.Text = node.SelectSingleNode("COD").InnerText;
                nh3.Text = node.SelectSingleNode("NH3").InnerText;
                sulphate.Text = node.SelectSingleNode("Sulphate").InnerText;
            }

            timer1.Start();
        }


        public bool Alarm()
        {
            if (28.3 > Convert.ToDouble(temperature.Text) || Convert.ToDouble(temperature.Text) > 48.2) { temperature.BackColor = Color.Red; return true; }
            if (839.8 > Convert.ToDouble(tds.Text) || Convert.ToDouble(tds.Text) > 862.2) { tds.BackColor = Color.Red; return true; }
            if (842.8 > Convert.ToDouble(conductivity.Text) || Convert.ToDouble(conductivity.Text) > 1750.1) { conductivity.BackColor = Color.Red; return true; }
            if (77.8 > Convert.ToDouble(colour.Text) || Convert.ToDouble(colour.Text) > 100) { colour.BackColor = Color.Red; return true; }
            if (87.7 > Convert.ToDouble(tss.Text) || Convert.ToDouble(tss.Text) > 176.7) { tss.BackColor = Color.Red; return true; }
            if (46.8 > Convert.ToDouble(turbidity.Text) || Convert.ToDouble(turbidity.Text) > 94.8) { turbidity.BackColor = Color.Red; return true; }
            if (3.6 > Convert.ToDouble(dissolvedoxygen.Text) || Convert.ToDouble(dissolvedoxygen.Text) > 5.7) { dissolvedoxygen.BackColor = Color.Red; return true; }
            if (8.5 > Convert.ToDouble(pH.Text) || Convert.ToDouble(pH.Text) > 11.3) { pH.BackColor = Color.Red; return true; }
            if (49.8 > Convert.ToDouble(bod.Text) || Convert.ToDouble(bod.Text) > 1116.8) { bod.BackColor = Color.Red; return true; }
            if (592.2 > Convert.ToDouble(cod.Text) || Convert.ToDouble(cod.Text) > 3114.2) { cod.BackColor = Color.Red; return true; }
            if (2.1 > Convert.ToDouble(nh3.Text) || Convert.ToDouble(nh3.Text) > 11.5) { nh3.BackColor = Color.Red; return true; }
            if (60.6 > Convert.ToDouble(sulphate.Text) || Convert.ToDouble(sulphate.Text) > 177.7) { sulphate.BackColor = Color.Red; return true; }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("MMM dd yyyy,hh:mm:ss");

            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Wastewater.xml");

            Random r = new Random();

            string value = Form1.instance.value;
            string place = "//" + value.ToString();

            num = r.NextDouble() * (48.2 - 28.3) + 28.3;
            temperature.Text = num.ToString();
            num = r.NextDouble() * (862.2 - 839.8) + 839.8;
            tds.Text = num.ToString();
            num = r.NextDouble() * (1750.1 - 842.9) + 842.9;
            conductivity.Text = num.ToString();
            num = r.NextDouble() * (100 - 77.8) + 77.8;
            colour.Text = num.ToString();
            num = r.NextDouble() * (176.7 - 87.8) + 87.8;
            tss.Text = num.ToString();
            num = r.NextDouble() * (94.8 - 46.8) + 46.8;
            turbidity.Text = num.ToString();
            num = r.NextDouble() * (5.7 - 3.6) + 3.6;
            dissolvedoxygen.Text = num.ToString();
            num = r.NextDouble() * (11.3 - 8.5) + 8.5;
            pH.Text = num.ToString();
            num = r.NextDouble() * (1116.8 - 49.8) + 49.8;
            bod.Text = num.ToString();
            num = r.NextDouble() * (3114.2 - 592.2) + 592.2;
            cod.Text = num.ToString();
            num = r.NextDouble() * (11.5 - 2.1) + 2.1;
            nh3.Text = num.ToString();
            num = r.NextDouble() * (177.7 - 60.6) + 60.6;
            sulphate.Text = num.ToString();


            foreach (XmlNode node in doc.SelectNodes(place))
            {
                node.SelectSingleNode("Temperature").InnerText = temperature.Text;
                node.SelectSingleNode("TDS").InnerText = tds.Text;
                node.SelectSingleNode("Conductivity").InnerText = conductivity.Text;
                node.SelectSingleNode("Colour").InnerText = colour.Text;
                node.SelectSingleNode("TSS").InnerText = tss.Text;
                node.SelectSingleNode("Turbidity").InnerText = turbidity.Text;
                node.SelectSingleNode("DO").InnerText = dissolvedoxygen.Text;
                node.SelectSingleNode("pH").InnerText = pH.Text;
                node.SelectSingleNode("BOD").InnerText = bod.Text;
                node.SelectSingleNode("COD").InnerText = cod.Text;
                node.SelectSingleNode("NH3").InnerText = nh3.Text;
                node.SelectSingleNode("Sulphate").InnerText = sulphate.Text;
            }

            doc.Save(@"../../Wastewater.xml");

            if (Alarm())
            {
                timer1.Stop();
                Thread.Sleep(400);
                SendMail();
            }
        }

        private void WasteWater_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }


        public void SendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("sudecakmak46@gmail.com");
            mail.To.Add("sudecakmak46@gmail.com");
            mail.Subject = "WasteWater System Notification";
            mail.Body = "Wastewater system is critic condition please see details in attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@".. / .. /Wastewater.xml");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sudecakmak46@gmail.com", "Password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}

