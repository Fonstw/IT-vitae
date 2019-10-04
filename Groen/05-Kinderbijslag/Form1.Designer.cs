namespace _05_Kinderbijslag
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
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.lblStartDatum = new System.Windows.Forms.Label();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDatum = new System.Windows.Forms.DateTimePicker();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(12, 17);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(107, 17);
            this.lblGeboortedatum.TabIndex = 0;
            this.lblGeboortedatum.Text = "Geboortedatum";
            // 
            // lblStartDatum
            // 
            this.lblStartDatum.AutoSize = true;
            this.lblStartDatum.Location = new System.Drawing.Point(12, 45);
            this.lblStartDatum.Name = "lblStartDatum";
            this.lblStartDatum.Size = new System.Drawing.Size(77, 17);
            this.lblStartDatum.TabIndex = 1;
            this.lblStartDatum.Text = "Startdatum";
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Location = new System.Drawing.Point(125, 12);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(200, 22);
            this.dtpGeboortedatum.TabIndex = 2;
            // 
            // dtpStartDatum
            // 
            this.dtpStartDatum.Location = new System.Drawing.Point(125, 40);
            this.dtpStartDatum.Name = "dtpStartDatum";
            this.dtpStartDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDatum.TabIndex = 3;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(125, 68);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(98, 28);
            this.btnVoegToe.TabIndex = 4;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.BtnVoegToe_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 98);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(48, 17);
            this.lblAntwoord.TabIndex = 5;
            this.lblAntwoord.Text = "€ 0,00";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(230, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 124);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.dtpStartDatum);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Controls.Add(this.lblStartDatum);
            this.Controls.Add(this.lblGeboortedatum);
            this.Name = "frmMain";
            this.Text = "Kinderbijslag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeboortedatum;
        private System.Windows.Forms.Label lblStartDatum;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.DateTimePicker dtpStartDatum;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Button btnReset;
    }
}

