using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DNP3_Simulation
{
    public partial class Elektrik : Form
    {
        public Elektrik()
        {
            InitializeComponent();

        }

        public string btn;


        public string Btn
        {
            get { return btn; }
            set { btn = value; }
        }

        private void Elektrik_Load(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();

            xmldoc.Load(@"../../Electricity.xml");

            if (btn == "1")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer1");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }


            if (btn == "2")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer2");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }


            if (btn == "3")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer3");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }

            if (btn == "4")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer4");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }

            if (btn == "5")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer5");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }

            if (btn == "6")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer6");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }

            if (btn == "7")
            {



                XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("/Electricity/Transformer7");

                foreach (XmlNode node in nodelist)
                {
                    VRPA.Text = node.SelectSingleNode("VRPA").InnerText;
                    VRPB.Text = node.SelectSingleNode("VRPB").InnerText;
                    VRPC.Text = node.SelectSingleNode("VRPC").InnerText;

                    Thd1.Text = node.SelectSingleNode("THDA").InnerText;
                    Thd2.Text = node.SelectSingleNode("THDB").InnerText;
                    Thd3.Text = node.SelectSingleNode("THDC").InnerText;

                    CRPA.Text = node.SelectSingleNode("CRPA").InnerText;
                    CRPB.Text = node.SelectSingleNode("CRPB").InnerText;
                    CRPC.Text = node.SelectSingleNode("CRPC").InnerText;

                    Frequency.Text = node.SelectSingleNode("FREQ").InnerText;

                    WA1.Text = node.SelectSingleNode("WA1").InnerText;
                    VA1.Text = node.SelectSingleNode("VA1").InnerText;
                    VAR1.Text = node.SelectSingleNode("VAR1").InnerText;
                    PF1.Text = node.SelectSingleNode("PF1").InnerText;

                    WA2.Text = node.SelectSingleNode("WA2").InnerText;
                    VA2.Text = node.SelectSingleNode("VA2").InnerText;
                    VAR2.Text = node.SelectSingleNode("VAR2").InnerText;
                    PF2.Text = node.SelectSingleNode("PF2").InnerText;

                    WA3.Text = node.SelectSingleNode("WA3").InnerText;
                    VA3.Text = node.SelectSingleNode("VA3").InnerText;
                    VAR3.Text = node.SelectSingleNode("VAR3").InnerText;
                    PF3.Text = node.SelectSingleNode("PF3").InnerText;

                    WA4.Text = node.SelectSingleNode("WA4").InnerText;
                    VA4.Text = node.SelectSingleNode("VA4").InnerText;
                    VAR4.Text = node.SelectSingleNode("VAR4").InnerText;
                    PF4.Text = node.SelectSingleNode("PF4").InnerText;

                    Wh1.Text = node.SelectSingleNode("WH1").InnerText;
                    VAh1.Text = node.SelectSingleNode("VAH1").InnerText;
                    VARh1.Text = node.SelectSingleNode("VARH1").InnerText;

                    Wh2.Text = node.SelectSingleNode("WH2").InnerText;
                    VAh2.Text = node.SelectSingleNode("VAH2").InnerText;
                    VARh2.Text = node.SelectSingleNode("VARH2").InnerText;

                    Wh3.Text = node.SelectSingleNode("WH3").InnerText;
                    VAh3.Text = node.SelectSingleNode("VAH3").InnerText;
                    VARh3.Text = node.SelectSingleNode("VARH3").InnerText;

                    Wh4.Text = node.SelectSingleNode("WH4").InnerText;
                    VAh4.Text = node.SelectSingleNode("VAH4").InnerText;
                    VARh4.Text = node.SelectSingleNode("VARH4").InnerText;


                }



            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

            if (btn == "1")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);








                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);





                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));






                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));


                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));





                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));





                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer1");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");
                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;



            }

            if (btn == "2")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);







                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);





                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));






                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));






                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer2");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");
                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;



            }

            if (btn == "3")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);








                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);





                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));





                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));





                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer3");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");
                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;



            }

            if (btn == "4")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);






                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);







                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);




                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));






                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));





                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer4");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");



                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;







            }

            if (btn == "5")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);







                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);




                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));





                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));






                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer5");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");
                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;



            }

            if (btn == "6")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);








                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);




                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));






                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));






                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer6");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");
                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;



            }

            if (btn == "7")
            {

                Random r = new Random();

                double v1 = r.NextDouble() * (350 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum; max 340 min -340
                double v2 = r.NextDouble() * (350 - (-370)) + (-370);
                double v3 = r.NextDouble() * (350 - (-370)) + (-370);





                double thda = r.NextDouble() * (202 - (-1)) + (-1);
                double thdb = r.NextDouble() * (202 - (-1)) + (-1);
                double thdc = r.NextDouble() * (202 - (-1)) + (-1);








                double c1 = r.NextDouble() * (340 - (-370)) + (-370); //NextDouble() * (maximum - minimum) + minimum;
                double c2 = r.NextDouble() * (340 - (-370)) + (-370);
                double c3 = r.NextDouble() * (340 - (-370)) + (-370);





                double fr = r.NextDouble() * (450 - (-1)) + (-1); //MAX 440



                double wa1 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa2 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa3 = r.NextDouble() * (6800 - (-1) + (-1));
                double wa4 = r.NextDouble() * (6800 - (-1) + (-1)); //max 6600




                double va1 = r.NextDouble() * (6800 - (-1) + (-1));
                double va2 = r.NextDouble() * (6800 - (-1) + (-1)); // max 6600
                double va3 = r.NextDouble() * (6800 - (-1) + (-1));
                double va4 = r.NextDouble() * (6800 - (-1) + (-1));






                double var1 = r.NextDouble() * (17000 - (-1) + (-1)); //max 16000
                double var2 = r.NextDouble() * (17000 - (-1) + (-1));
                double var3 = r.NextDouble() * (17000 - (-1) + (-1));
                double var4 = r.NextDouble() * (17000 - (-1) + (-1));






                double pf1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double pf2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double pf4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));



                double wh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double wh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double wh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));




                double vah1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double vah2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double vah4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));






                double varh1 = r.NextDouble() * (1.2 - (-1.2) + (-1.2)); // 1 and - 1
                double varh2 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh3 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));
                double varh4 = r.NextDouble() * (1.2 - (-1.2) + (-1.2));







                XmlDocument Doc = new XmlDocument();
                Doc.Load(@"../../Electricity.xml");

                XmlNodeList nodelist = Doc.DocumentElement.SelectNodes("/Electricity/Transformer7");

                foreach (XmlNode node in nodelist)
                {



                    node.SelectSingleNode("VRPA").InnerText = v1.ToString();

                    VRPA.Text = v1.ToString();
                    node.SelectSingleNode("VRPB").InnerText = v2.ToString();
                    VRPB.Text = v2.ToString();
                    node.SelectSingleNode("VRPC").InnerText = v3.ToString();
                    VRPC.Text = v3.ToString();

                    node.SelectSingleNode("THDA").InnerText = thda.ToString();
                    Thd1.Text = thda.ToString();
                    node.SelectSingleNode("THDB").InnerText = thdb.ToString();
                    Thd2.Text = thdb.ToString();
                    node.SelectSingleNode("THDC").InnerText = thdc.ToString();
                    Thd3.Text = thdc.ToString();

                    node.SelectSingleNode("CRPA").InnerText = c1.ToString();
                    CRPA.Text = c1.ToString();
                    node.SelectSingleNode("CRPB").InnerText = c2.ToString();
                    CRPB.Text = c2.ToString();
                    node.SelectSingleNode("CRPC").InnerText = c3.ToString();
                    CRPC.Text = c3.ToString();

                    node.SelectSingleNode("FREQ").InnerText = fr.ToString();
                    Frequency.Text = fr.ToString();

                    node.SelectSingleNode("WA1").InnerText = wa1.ToString();
                    WA1.Text = wa1.ToString();
                    node.SelectSingleNode("WA2").InnerText = wa2.ToString();
                    WA2.Text = wa2.ToString();
                    node.SelectSingleNode("WA3").InnerText = wa3.ToString();
                    WA3.Text = wa3.ToString();
                    node.SelectSingleNode("WA4").InnerText = wa4.ToString();
                    WA4.Text = wa4.ToString();

                    node.SelectSingleNode("VA1").InnerText = va1.ToString();
                    VA1.Text = va1.ToString();
                    node.SelectSingleNode("VA2").InnerText = va2.ToString();
                    VA2.Text = va2.ToString();
                    node.SelectSingleNode("VA3").InnerText = va3.ToString();
                    VA3.Text = va3.ToString();
                    node.SelectSingleNode("VA4").InnerText = va4.ToString();
                    VA4.Text = va4.ToString();

                    node.SelectSingleNode("VAR1").InnerText = var1.ToString();
                    VAR1.Text = var1.ToString();
                    node.SelectSingleNode("VAR2").InnerText = var2.ToString();
                    VAR2.Text = var2.ToString();
                    node.SelectSingleNode("VAR3").InnerText = var3.ToString();
                    VAR3.Text = var3.ToString();
                    node.SelectSingleNode("VAR4").InnerText = var4.ToString();
                    VAR4.Text = var4.ToString();

                    node.SelectSingleNode("PF1").InnerText = pf1.ToString();
                    PF1.Text = pf1.ToString();
                    node.SelectSingleNode("PF2").InnerText = pf2.ToString();
                    PF2.Text = pf2.ToString();
                    node.SelectSingleNode("PF3").InnerText = pf3.ToString();
                    PF3.Text = pf3.ToString();
                    node.SelectSingleNode("PF4").InnerText = pf4.ToString();
                    PF4.Text = pf4.ToString();

                    node.SelectSingleNode("WH1").InnerText = wh1.ToString();
                    Wh1.Text = pf1.ToString();
                    node.SelectSingleNode("WH2").InnerText = wh2.ToString();
                    Wh2.Text = pf2.ToString();
                    node.SelectSingleNode("WH3").InnerText = wh3.ToString();
                    Wh3.Text = pf3.ToString();
                    node.SelectSingleNode("WH4").InnerText = wh4.ToString();
                    Wh4.Text = pf4.ToString();

                    node.SelectSingleNode("VAH1").InnerText = vah1.ToString();
                    VAh1.Text = vah1.ToString();
                    node.SelectSingleNode("VAH2").InnerText = vah2.ToString();
                    VAh2.Text = vah2.ToString();
                    node.SelectSingleNode("VAH3").InnerText = vah3.ToString();
                    VAh3.Text = vah3.ToString();
                    node.SelectSingleNode("VAH4").InnerText = vah4.ToString();
                    VAh4.Text = vah4.ToString();

                    node.SelectSingleNode("VARH1").InnerText = varh1.ToString();
                    VARh1.Text = varh1.ToString();
                    node.SelectSingleNode("VARH2").InnerText = varh2.ToString();
                    VARh2.Text = varh2.ToString();
                    node.SelectSingleNode("VARH3").InnerText = varh3.ToString();
                    VARh3.Text = varh3.ToString();
                    node.SelectSingleNode("VARH4").InnerText = varh4.ToString();
                    VARh4.Text = varh4.ToString();





                }
                Doc.Save(@"../../Electricity.xml");

                if (v1 > 340 || v1 < -360)
                {
                    VRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPA!");
                }
                else
                    VRPA.BackColor = Color.White;

                if (v2 > 340 || v2 < -360)
                {

                    VRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPB!");
                }
                else
                    VRPB.BackColor = Color.White;

                if (v3 > 340 || v3 < -360)
                {
                    VRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: VRPC!");
                }
                else
                    VRPC.BackColor = Color.White;


                if (thda > 200 || thda < -0.5)
                {
                    Thd1.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDA!");
                }
                else
                    Thd1.BackColor = Color.White;

                if (thdb > 200 || thdb < -0.8)
                {

                    Thd2.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDB!");
                }
                else
                    Thd2.BackColor = Color.White;

                if (thdc > 200 || thdc < 0)
                {
                    Thd3.BackColor = Color.Red;
                    MessageBox.Show("Warning: THDC!");
                }
                else
                    Thd3.BackColor = Color.White;
                if (c1 > 340 || c1 < -360)
                {
                    CRPA.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPA!");
                }
                else
                    CRPA.BackColor = Color.White;

                if (c2 > 340 || c2 < -360)
                {

                    CRPB.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPB!");
                }
                else
                    CRPB.BackColor = Color.White;

                if (c3 > 340 || c3 < -360)
                {
                    CRPC.BackColor = Color.Red;
                    MessageBox.Show("Warning: CRPC!");
                }
                else
                    CRPC.BackColor = Color.White;


                if (fr > 448 || fr < 0)
                {
                    Frequency.BackColor = Color.Red;
                    MessageBox.Show("Warning: FREQ!");
                }
                else
                    Frequency.BackColor = Color.White;

                if (wa1 > 6790 || wa1 < -0.8)
                {
                    WA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER A!");
                }
                else
                    WA1.BackColor = Color.White;

                if (wa2 > 6790 || wa2 < -0.8)
                {

                    WA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER B!");
                }
                else
                    WA2.BackColor = Color.White;

                if (wa3 > 6790 || wa3 < -0.8)
                {
                    WA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE POWER C!");
                }
                else
                    WA3.BackColor = Color.White;
                if (wa4 > 6790 || wa4 < -0.8)
                {
                    WA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE POWER!");
                }
                else
                    WA4.BackColor = Color.White;

                if (va1 > 6790 || va1 < -0.8)
                {
                    VA1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER A!");
                }
                else
                    VA1.BackColor = Color.White;

                if (va2 > 6790 || va2 < -0.89)
                {

                    VA2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER B!");
                }
                else
                    VA2.BackColor = Color.White;

                if (va3 > 6777 || va3 < -0.89)
                {
                    VA3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT POWER C!");
                }
                else
                    VA3.BackColor = Color.White;
                if (va4 > 6777 || va4 < 0)
                {
                    VA4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT POWER!");
                }
                else
                    VA4.BackColor = Color.White;

                if (var1 > 16900 || var1 < -0.89)
                {
                    VAR1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER A!");
                }
                else
                    VAR1.BackColor = Color.White;

                if (var2 > 16900 || var2 < -0.89)
                {

                    VAR2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER B!");
                }
                else
                    VAR2.BackColor = Color.White;

                if (var3 > 16900 || var3 < -0.89)
                {
                    VAR3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE POWER C!");
                }
                else
                    VAR3.BackColor = Color.White;
                if (var4 > 16900 || var4 < -0.89)
                {
                    VAR4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE POWER!");
                }
                else
                    VAR4.BackColor = Color.White;

                if (pf1 > 1.19 || pf1 < -1.19)
                {
                    PF1.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR A!");
                }
                else
                    PF1.BackColor = Color.White;

                if (pf2 > 1.19 || pf2 < -1.19)
                {

                    PF2.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR B!");
                }
                else
                    PF2.BackColor = Color.White;

                if (pf3 > 1.19 || pf3 < -1.19)
                {
                    PF3.BackColor = Color.Red;
                    MessageBox.Show("Warning: POWER FACTOR C!");
                }
                else
                    PF3.BackColor = Color.White;
                if (pf4 > 1.19 || pf4 < -1.19)
                {
                    PF4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET POWER FACTOR!");
                }
                else
                    PF4.BackColor = Color.White;

                if (wh1 > 1.19 || wh1 < -1.19)
                {
                    Wh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY A!");
                }
                else
                    Wh1.BackColor = Color.White;

                if (wh2 > 1.19 || wh2 < -1.19)
                {

                    Wh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY B!");
                }
                else
                    Wh2.BackColor = Color.White;

                if (wh3 > 1.19 || wh3 < -19)
                {
                    Wh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: ACTIVE ENERGY C!");
                }
                else
                    Wh3.BackColor = Color.White;
                if (wh4 > 1.19 || wh4 < -1.19)
                {
                    Wh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET ACTIVE ENERGY!");
                }
                else
                    Wh4.BackColor = Color.White;

                if (vah1 > 1.19 || vah1 < -1.19)
                {
                    VAh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY A!");
                }
                else
                    VAh1.BackColor = Color.White;

                if (vah2 > 1.19 || vah2 < -1.19)
                {

                    VAh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY B!");
                }
                else
                    VAh2.BackColor = Color.White;

                if (vah3 > 1.19 || vah3 < -19)
                {
                    VAh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: APPARENT ENERGY C!");
                }
                else
                    VAh3.BackColor = Color.White;
                if (vah4 > 1.19 || vah4 < -1.19)
                {
                    VAh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET APPARENT ENERGY!");
                }
                else
                    VAh4.BackColor = Color.White;

                if (varh1 > 1.19 || varh1 < -1.19)
                {
                    VARh1.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY A!");
                }
                else
                    VARh1.BackColor = Color.White;

                if (varh2 > 1.19 || varh2 < -1.19)
                {

                    VARh2.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY B!");
                }
                else
                    VARh2.BackColor = Color.White;

                if (varh3 > 1.19 || varh3 < -19)
                {
                    VARh3.BackColor = Color.Red;
                    MessageBox.Show("Warning: REACTIVE ENERGY C!");
                }
                else
                    VARh3.BackColor = Color.White;
                if (varh4 > 1.19 || varh4 < -1.19)
                {
                    VARh4.BackColor = Color.Red;
                    MessageBox.Show("Warning: NET REACTIVE ENERGY!");
                }
                else
                    VARh4.BackColor = Color.White;


            }
        }
    }
}

