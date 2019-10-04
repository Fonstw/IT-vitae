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

            price += Convert.ToSingle(numUnderTen.Value * 25);

            price += Convert.ToSingle(numTenOrOlder.Value * 37);

            if (ckbEenOuderGezin.Checked)
                price *= .75f;

            if (price > 150)
                price = 150;

            lblAntwoord.Text = "€ " + price.ToString("N2");
        }
    }
}
