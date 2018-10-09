using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubContributie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //
        private void Bereken()
        {
            double uit = 0;
            int leeftijd = DateTime.Now.Year - dtpGeboortedatum.Value.Year;
            int idmaatschap = DateTime.Now.Year - dtpInschrijdDatum.Value.Year;
            //leeftijd
            if (leeftijd >= 18) uit += 75;
            else uit += 40;
            //lidmaatshap
            if(idmaatschap >= 4)
            {
                if (idmaatschap >= 7) uit = (uit / 100) * 98.00;
                else uit = (uit / 100) * 96.50;
            }
            //Spelend of niet?
            if (chbSpelend.Checked) uit += 45;
            lblOut.Text = "Betaal €" + uit;

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            Bereken();
        }
    }
}
