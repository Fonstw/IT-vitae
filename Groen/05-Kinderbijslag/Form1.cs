using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Kinderbijslag
{
    public partial class frmMain : Form
    {
        int numberOfKids = 0;
        float benefits = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnVoegToe_Click(object sender, EventArgs e)
        {
            numberOfKids++;

            int age = (dtpStartDatum.Value.Year - dtpGeboortedatum.Value.Year);

            // take away one year if not birthday yet
            if (dtpGeboortedatum.Value.DayOfYear > dtpStartDatum.Value.DayOfYear)
                age--;

            if (age < 12)
                benefits += 150;
            else if (age < 18)
                benefits += 235;
            else
            {
                lblAntwoord.Text = "Kloppen de datums wel?";
                return;
            }

            lblAntwoord.Text = "€ ";
            if (numberOfKids < 3)
                lblAntwoord.Text += benefits.ToString("N2");
            else if (numberOfKids == 3 || numberOfKids == 4)
                lblAntwoord.Text += (benefits * 1.02f).ToString("N2");
            else if (numberOfKids == 5)
                lblAntwoord.Text += (benefits * 1.03f).ToString("N2");
            else if (numberOfKids >= 6)
                lblAntwoord.Text += (benefits * 1.035f).ToString("N2");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            numberOfKids = 0;
            benefits = 0;
            lblAntwoord.Text = "€ 0,00";
        }
    }
}
