using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Camping
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

            float meters = 0;
            if (txbMeters.Text != "")
            {
                if (!float.TryParse(txbMeters.Text, out meters))
                {
                    lblAntwoord.Text = "Voer a.u.b. geldige getallen in.";
                    return;
                }
            }

            int people = Convert.ToInt32(numPersonen.Value);
            int dogs = Convert.ToInt32(numHonden.Value);
            int cars = Convert.ToInt32(numAutos.Value);

            int daysOutOfSeason = 0, daysInSeason = 0;
            DateTime beginDate = dtpBegin.Value;
            DateTime endDate = dtpEind.Value;
            DateTime seasonBegin = new DateTime(DateTime.Now.Year, 7, 11);
            DateTime seasonEnd = new DateTime(DateTime.Now.Year, 8, 15);

            if (beginDate < seasonBegin && endDate < seasonBegin)
                daysOutOfSeason = (endDate - beginDate).Days;
            else if (beginDate > seasonEnd && endDate > seasonEnd)
                // this is the same, they are separated for readability
                daysOutOfSeason = (endDate - beginDate).Days;
            else if (beginDate >= seasonBegin && endDate <= seasonEnd)
                daysInSeason = (endDate - beginDate).Days;
            else if (beginDate < seasonBegin && endDate > seasonEnd)
            {
                daysInSeason = (seasonEnd - seasonBegin).Days;
                daysOutOfSeason = (endDate - beginDate).Days;
                daysOutOfSeason -= daysInSeason;
            }
            else if (beginDate < seasonBegin && endDate <= seasonEnd)
            {
                daysInSeason = (endDate - seasonBegin).Days;
                daysOutOfSeason = (seasonBegin - beginDate).Days;
            }
            else if (beginDate >= seasonBegin && endDate > seasonEnd)
            {
                daysInSeason = (seasonEnd - beginDate).Days;
                daysOutOfSeason = (endDate - seasonEnd).Days;
            }

            int totalDays = (endDate - beginDate).Days;

            // these are all pays per day regardless
            price += people * 5;
            price += dogs * 4;
            price += cars * 6;
            // so there you go!
            price *= totalDays;

            // the amount of meters under 10 are €2 discount per meter regardless
            if (meters < 10)
                price -= totalDays * (10 - meters) * 2;
            // the amount of meters above 10 cost €3 extra regardless
            else if (meters > 10)
                price += totalDays * (meters - 10) * 3;

            // baseprice for the meters will be €25/€30 depending on the day
            price += daysOutOfSeason * 25;
            price += daysInSeason * 30;

            lblAntwoord.Text = "€ " + price.ToString("N2");
        }
    }
}
