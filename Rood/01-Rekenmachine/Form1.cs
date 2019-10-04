using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITV_Zelfleerhulpmiddel_1_Rekenmachine
{
    public partial class Form1 : Form
    {
        List<string> memory = new List<string>();
        int memorySize = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormulaInput_KeyDown(object sender, KeyEventArgs e)
        {
            // if inputbox took 'enter'
            if (e.KeyCode == Keys.Enter)
                // calculate
                Calculate();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // 
            Calculate();
        }

        private void Calculate()
        {
            AddToMemory(formulaInput.Text);

            string[] numberInput = formulaInput.Text.Split('+', '-', '*', '/');
            float[] realNumbers = new float[numberInput.Length];

            for (int n = 0; n < realNumbers.Length; n++)
            {
                float.TryParse(numberInput[n], out realNumbers[n]);
                Debug.WriteLine(realNumbers[n]);
            }
        }

        private void AddToMemory(string toAdd)
        {
            memory.Add(toAdd);
            if (memory.Count > memorySize)
                memory.RemoveAt(0);

            txbResults.Text = "";
            foreach (string entry in memory)
                txbResults.Text += entry + Environment.NewLine;
        }
    }
}
