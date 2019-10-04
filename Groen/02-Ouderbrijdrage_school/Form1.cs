using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Ouderbrijdrage_school
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            float price = 50;

            int childrenUnderTen = 0;
            if (txbOnderTien.Text != "")
            {
                if (int.TryParse(txbOnderTien.Text, out childrenUnderTen))
                    price += childrenUnderTen * 25;
                else
                {
                    lblAntwoord.Text = "Voer a.u.b. een rond getal in.";
                    return;
                }
            }

            int tenOrOlder = 0;
            if (txbTienOfOuder.Text != "")
            {
                if (int.TryParse(txbTienOfOuder.Text, out tenOrOlder))
                    price += tenOrOlder * 37;
                else
                {
                    lblAntwoord.Text = "Voer a.u.b. een rond getal in.";
                    return;
                }
            }

            if (ckbEenOuderGezin.Checked)
                price *= .75f;

            if (price > 150)
                price = 150;

            lblAntwoord.Text = "€ " + price.ToString("N2");
        }
    }
}
