namespace _01_Taxikosten
{
    partial class frmMain
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
            this.lblKilometer = new System.Windows.Forms.Label();
            this.lblMinutenLaag = new System.Windows.Forms.Label();
            this.lblMinutenHoog = new System.Windows.Forms.Label();
            this.lblWeekendPrijs = new System.Windows.Forms.Label();
            this.txbKilometer = new System.Windows.Forms.TextBox();
            this.txbMinutenLaag = new System.Windows.Forms.TextBox();
            this.txbMinutenHoog = new System.Windows.Forms.TextBox();
            this.ckbWeekendPrijs = new System.Windows.Forms.CheckBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKilometer
            // 
            this.lblKilometer.AutoSize = true;
            this.lblKilometer.Location = new System.Drawing.Point(12, 15);
            this.lblKilometer.Name = "lblKilometer";
            this.lblKilometer.Size = new System.Drawing.Size(70, 17);
            this.lblKilometer.TabIndex = 0;
            this.lblKilometer.Text = "Aantal km";
            // 
            // lblMinutenLaag
            // 
            this.lblMinutenLaag.AutoSize = true;
            this.lblMinutenLaag.Location = new System.Drawing.Point(12, 43);
            this.lblMinutenLaag.Name = "lblMinutenLaag";
            this.lblMinutenLaag.Size = new System.Drawing.Size(240, 17);
            this.lblMinutenLaag.TabIndex = 1;
            this.lblMinutenLaag.Text = "Aantal minuten tussen 8:00 en 18:00";
            // 
            // lblMinutenHoog
            // 
            this.lblMinutenHoog.AutoSize = true;
            this.lblMinutenHoog.Location = new System.Drawing.Point(12, 71);
            this.lblMinutenHoog.Name = "lblMinutenHoog";
            this.lblMinutenHoog.Size = new System.Drawing.Size(174, 17);
            this.lblMinutenHoog.TabIndex = 2;
            this.lblMinutenHoog.Text = "Aantal minuten daarbuiten";
            // 
            // lblWeekendPrijs
            // 
            this.lblWeekendPrijs.AutoSize = true;
            this.lblWeekendPrijs.Location = new System.Drawing.Point(12, 97);
            this.lblWeekendPrijs.Name = "lblWeekendPrijs";
            this.lblWeekendPrijs.Size = new System.Drawing.Size(317, 17);
            this.lblWeekendPrijs.TabIndex = 3;
            this.lblWeekendPrijs.Text = "Begintijd tussen vrijdag 22:00 en maandag 7:00?";
            // 
            // txbKilometer
            // 
            this.txbKilometer.Location = new System.Drawing.Point(335, 12);
            this.txbKilometer.Name = "txbKilometer";
            this.txbKilometer.Size = new System.Drawing.Size(100, 22);
            this.txbKilometer.TabIndex = 4;
            // 
            // txbMinutenLaag
            // 
            this.txbMinutenLaag.Location = new System.Drawing.Point(335, 40);
            this.txbMinutenLaag.Name = "txbMinutenLaag";
            this.txbMinutenLaag.Size = new System.Drawing.Size(100, 22);
            this.txbMinutenLaag.TabIndex = 5;
            // 
            // txbMinutenHoog
            // 
            this.txbMinutenHoog.Location = new System.Drawing.Point(335, 68);
            this.txbMinutenHoog.Name = "txbMinutenHoog";
            this.txbMinutenHoog.Size = new System.Drawing.Size(100, 22);
            this.txbMinutenHoog.TabIndex = 6;
            // 
            // ckbWeekendPrijs
            // 
            this.ckbWeekendPrijs.AutoSize = true;
            this.ckbWeekendPrijs.Location = new System.Drawing.Point(335, 96);
            this.ckbWeekendPrijs.Name = "ckbWeekendPrijs";
            this.ckbWeekendPrijs.Size = new System.Drawing.Size(45, 21);
            this.ckbWeekendPrijs.TabIndex = 7;
            this.ckbWeekendPrijs.Text = "Ja";
            this.ckbWeekendPrijs.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(335, 124);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 8;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 159);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(48, 17);
            this.lblAntwoord.TabIndex = 9;
            this.lblAntwoord.Text = "€ 0,00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 185);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.ckbWeekendPrijs);
            this.Controls.Add(this.txbMinutenHoog);
            this.Controls.Add(this.txbMinutenLaag);
            this.Controls.Add(this.txbKilometer);
            this.Controls.Add(this.lblWeekendPrijs);
            this.Controls.Add(this.lblMinutenHoog);
            this.Controls.Add(this.lblMinutenLaag);
            this.Controls.Add(this.lblKilometer);
            this.Name = "frmMain";
            this.Text = "Taxikosten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometer;
        private System.Windows.Forms.Label lblMinutenLaag;
        private System.Windows.Forms.Label lblMinutenHoog;
        private System.Windows.Forms.Label lblWeekendPrijs;
        private System.Windows.Forms.TextBox txbKilometer;
        private System.Windows.Forms.TextBox txbMinutenLaag;
        private System.Windows.Forms.TextBox txbMinutenHoog;
        private System.Windows.Forms.CheckBox ckbWeekendPrijs;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

