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

namespace KategorijeVozila
{
    public partial class Form1 : Form
    {


        class Vozilo
        {
           
            int brojKotaca, godProiz;
            string model, kategorija;

            public Vozilo(string model, int godProiz, int brojKotaca)
            {
                this.BrojKotaca = brojKotaca;
                this.GodProiz = godProiz;
                this.Model = model;

            }

            public Vozilo()
            {

            }

            public string Model { get => model; set => model = value; }
            public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
            public int GodProiz { get => godProiz; set => godProiz = value; }
            public string Kategorija { get => kategorija; set => kategorija = value; }
        }

        class Motocikl : Vozilo
        {

            public Motocikl(string model, int godProiz) 
            {
                this.Model = model;
                this.GodProiz = godProiz;
                this.BrojKotaca = 2;
                this.Kategorija = "Motocikl";
            }
        }

        class Automobil : Vozilo
        {
            public Automobil(string model, int godProiz)
            {
                this.Model = model;
                this.GodProiz = godProiz;
                this.BrojKotaca = 4;
                this.Kategorija = "Automobil";
            }
        }

        class Kamion : Vozilo
        {
            public Kamion(string model, int godProiz, int brojKot)
            {
                this.BrojKotaca = brojKot;
                this.Model = model;
                this.GodProiz = godProiz;
                this.Kategorija = "Kamion";
            }
        }




        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonObrada_Click(object sender, EventArgs e)
        {
            try
            {
                int brojKot = Convert.ToInt32(textBoxBrojKot.Text);
                if (brojKot == 2)
                {
                    Motocikl vozilo = new Motocikl(textBoxModel.Text, Convert.ToInt32(textBoxBrojKot.Text));
                    textBox4.Text = vozilo.Kategorija;
                    
                }
                else if (brojKot == 4)
                {
                    Automobil vozilo = new Automobil(textBoxModel.Text, Convert.ToInt32(textBoxBrojKot.Text));
                    textBox4.Text = vozilo.Kategorija;
                }
                else if (brojKot > 4 && brojKot % 2 == 0)
                {
                    Kamion vozilo = new Kamion(textBoxModel.Text, Convert.ToInt32(textBoxGod.Text), brojKot);
                    textBox4.Text = vozilo.Kategorija;
                }
                else
                {
                    textBox4.Text = "Pogrešan unos!";
                }
            }
            catch
            {
                textBox4.Text = "Pogrešan unos!";
            }
            
           
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            velikiBox.Text = "Broj kotaca\tGodina proizvodnje    \tModel         \tKategorija\n";
            velikiBox.AppendText("--------------------------------------------------------------------" +
                "--------------------------------------------------------------------");
            XmlDocument doc = new XmlDocument();
            doc.Load("vozila.xml");
            XmlNodeList elementi = doc.GetElementsByTagName("vozilo");
            for(int j = 0; j < elementi.Count; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    string atribut = elementi[j].Attributes[i].Value;
                    velikiBox.AppendText("\t"+atribut + "\t");
                }
                velikiBox.AppendText("\n");
            }
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("vozila.xml");
            XmlElement root = doc.DocumentElement;

            try
            {
                int brojKot = Convert.ToInt32(textBoxBrojKot.Text);
                if (brojKot == 2)
                {
                    Motocikl vozilo = new Motocikl(textBoxModel.Text, Convert.ToInt32(textBoxGod.Text));



                    XmlElement noviElem = doc.CreateElement("vozilo");
                    noviElem.SetAttribute("brojKotaca", brojKot.ToString());
                    noviElem.SetAttribute("godProiz", vozilo.GodProiz.ToString());
                    noviElem.SetAttribute("model", vozilo.Model);
                    noviElem.SetAttribute("kategorija", vozilo.Kategorija);
                    root.AppendChild(noviElem);
                    doc.Save("vozila.xml");

                }
                else if (brojKot == 4)
                {
                    Automobil vozilo = new Automobil(textBoxModel.Text, Convert.ToInt32(textBoxGod.Text));


                    XmlElement noviElem = doc.CreateElement("vozilo");
                    noviElem.SetAttribute("brojKotaca", brojKot.ToString());
                    noviElem.SetAttribute("godProiz", vozilo.GodProiz.ToString());
                    noviElem.SetAttribute("model", vozilo.Model);
                    noviElem.SetAttribute("kategorija", vozilo.Kategorija);
                    root.AppendChild(noviElem);
                    doc.Save("vozila.xml");

                }
                else if (brojKot > 4 && brojKot % 2 == 0)
                {
                    Kamion vozilo = new Kamion(textBoxModel.Text, Convert.ToInt32(textBoxGod.Text), brojKot);

                    XmlElement noviElem = doc.CreateElement("vozilo");
                    noviElem.SetAttribute("brojKotaca", brojKot.ToString());
                    noviElem.SetAttribute("godProiz", vozilo.GodProiz.ToString());
                    noviElem.SetAttribute("model", vozilo.Model);
                    noviElem.SetAttribute("kategorija", vozilo.Kategorija);
                    root.AppendChild(noviElem);
                    doc.Save("vozila.xml");
                }
                else
                {
                    textBox4.Text = "Pogrešan unos!";
                }
            }

            catch
            {
                textBox4.Text = "Pogrešan unos!";
            }
        }
    }
}
