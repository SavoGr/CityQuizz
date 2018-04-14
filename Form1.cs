using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CityQuizz
{
    public partial class Form1 : Form
    {
        Grad[] lGradDrzava;
        int brojPitanja;
        Grad tacanOdgovor;
        
        public Form1()
        {
            InitializeComponent();
            UcitajJson json = new UcitajJson();
            lGradDrzava = json.ucitajGradoveiDrzave().ToArray();
            brojPitanja = lGradDrzava.Length;
            postaviPitanje();

        }


        private void postaviPitanje()
        {
            Random ran = new Random();
            System.Diagnostics.Debug.WriteLine("KAPACITET : " + brojPitanja);
            tacanOdgovor = lGradDrzava[ran.Next(brojPitanja-1)];
            String StacanOdgovor = tacanOdgovor.country;
            String SnetacanOdgovor1 = lGradDrzava[ran.Next(brojPitanja - 1)].country;
            String SnetacanOdgovor2 = lGradDrzava[ran.Next(brojPitanja - 1)].country;
            String SnetacanOdgovor3 = lGradDrzava[ran.Next(brojPitanja - 1)].country;

            String[] pitanja = { StacanOdgovor, SnetacanOdgovor1, SnetacanOdgovor2, SnetacanOdgovor3 };
            for(int i = 0; i < pitanja.Length; i++)
            //
            {
                Random r = new Random();
                int staraPozicija = i;
                int novaPozicija = r.Next(4);
                String stariOdgovor = pitanja[staraPozicija];
                String noviOdgovor = pitanja[novaPozicija];
                pitanja[staraPozicija] = noviOdgovor;
                pitanja[novaPozicija] = stariOdgovor;
            }
            //dodatno mesa sada unos u dugmad...
            if (ran.Next(2) == 1)
            {
                btnOdgovor1.Text = pitanja[0];
                btnOdgovor2.Text = pitanja[1];
                btnOdgovor3.Text = pitanja[2];
                btnOdgovor4.Text = pitanja[3];
            }
            else
            {
                btnOdgovor2.Text = pitanja[1];
                btnOdgovor4.Text = pitanja[3];
                btnOdgovor3.Text = pitanja[2];
                btnOdgovor1.Text = pitanja[0];

            }
            lGrad.Text = tacanOdgovor.city;






        }


        private void izaberiOdgovor(object sender, EventArgs e)
        {
            String izabraniOdgovor = (sender as Button).Text;
            if (izabraniOdgovor == tacanOdgovor.country)
            {
                //(sender as Button).BackColor = Color.Green;
                //LabelTest.ForeColor = System.Drawing.Color.Blue;
                lTacnoNetacno.ForeColor = System.Drawing.Color.Green;
                lTacnoNetacno.Visible = true;
                lTacnoNetacno.Text = "TACAN ODGOVOR!";
                
                postaviPitanje();
               //(sender as Button).BackColor = default(Color);

            }
            else
            {
                //(sender as Button).BackColor = Color.Red;
                lTacnoNetacno.ForeColor = System.Drawing.Color.Red;
                lTacnoNetacno.Visible = true;
                lTacnoNetacno.Text = "NETACAN ODGOVOR!";
               
                postaviPitanje();
                //(sender as Button).BackColor = default(Color);

            }
            
        }
    }
}
