using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Taxikosten
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            float price = 0;

            float kms;
            if (txbKilometer.Text == "")
                kms = 0;
            else if (float.TryParse(txbKilometer.Text, out kms))
            {
                price += kms;
            }
            else
            {
                lblAntwoord.Text = "Voer a.u.b. een rond getal aan kilometers in.";
                return;
            }

            float lowPrice;
            if (txbMinutenLaag.Text == "")
                lowPrice = 0;
            else if (float.TryParse(txbMinutenLaag.Text, out lowPrice))
            {
                price += lowPrice * .25f;
            }
            else
            {
                lblAntwoord.Text = "Voer a.u.b. een rond getal aan minuten tussen 8:00 en 18:00 in.";
                return;
            }

            float highPrice;
            if (txbMinutenHoog.Text == "")
                highPrice = 0;
            else if (float.TryParse(txbMinutenHoog.Text, out highPrice))
            {
                price += highPrice * .45f;
            }
            else
            {
                lblAntwoord.Text = "Voer a.u.b. een rond getal aan minuten daarbuiten in.";
                return;
            }

            if (ckbWeekendPrijs.Checked)
                price *= 1.15f;

            lblAntwoord.Text = "€ " + price.ToString("N2");
        }
    }
}
