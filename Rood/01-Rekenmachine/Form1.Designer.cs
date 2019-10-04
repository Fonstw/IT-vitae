namespace ITV_Zelfleerhulpmiddel_1_Rekenmachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formulaInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formulaInput
            // 
            this.formulaInput.Location = new System.Drawing.Point(12, 145);
            this.formulaInput.Name = "formulaInput";
            this.formulaInput.Size = new System.Drawing.Size(378, 22);
            this.formulaInput.TabIndex = 1;
            this.formulaInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormulaInput_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(13, 13);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.Size = new System.Drawing.Size(377, 126);
            this.txbResults.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(315, 173);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.formulaInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox formulaInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Button btnCalculate;
    }
}

