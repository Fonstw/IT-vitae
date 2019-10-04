using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Autoverhuur
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
            int days = (dtpEindVerhuur.Value - dtpStartVerhuur.Value).Days;

            float kms = 0;
            if (txbKilometer.Text != "")
            {
                if (!float.TryParse(txbKilometer.Text, out kms))
                {
                    lblAntwoord.Text = "Voer a.u.b. een geldig getal aan kilometers in.";
                    return;
                }
            }

            float tankPrice = 0;
            if (txbExtraBenzinePrijs.Text != "")
            {
                if (!float.TryParse(txbExtraBenzinePrijs.Text, out tankPrice))
                {
                    lblAntwoord.Text = "Voer a.u.b. een geldig getal voor de bijgetankte prijs in.";
                    return;
                }
            }

            if (rdbPersonenAuto.Checked)
            {
                price += days * 50;

                kms -= 100;
                if (kms > 0)
                    price += kms * .2f;
            }
            else if (rdbPersonenBus.Checked)
            {
                price += days * 95;

                price += kms * .3f;
            }
            else
            {
                lblAntwoord.Text = "Kies a.u.b. of het een personenauto of -bus betreft.";
                return;
            }

            price += tankPrice;

            lblAntwoord.Text = "€ " + price.ToString("N2");
        }
    }
}
