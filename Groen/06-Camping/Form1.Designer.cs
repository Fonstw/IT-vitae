namespace _06_Camping
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
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.lblHonden = new System.Windows.Forms.Label();
            this.lblAutos = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEind = new System.Windows.Forms.Label();
            this.txbMeters = new System.Windows.Forms.TextBox();
            this.numPersonen = new System.Windows.Forms.NumericUpDown();
            this.numHonden = new System.Windows.Forms.NumericUpDown();
            this.numAutos = new System.Windows.Forms.NumericUpDown();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHonden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(12, 15);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(122, 17);
            this.lblMeters.TabIndex = 0;
            this.lblMeters.Text = "Meters plaatshuur";
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Location = new System.Drawing.Point(12, 42);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(112, 17);
            this.lblPersonen.TabIndex = 1;
            this.lblPersonen.Text = "Aantal personen";
            // 
            // lblHonden
            // 
            this.lblHonden.AutoSize = true;
            this.lblHonden.Location = new System.Drawing.Point(12, 70);
            this.lblHonden.Name = "lblHonden";
            this.lblHonden.Size = new System.Drawing.Size(100, 17);
            this.lblHonden.TabIndex = 2;
            this.lblHonden.Text = "Aantal honden";
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.Location = new System.Drawing.Point(12, 98);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(90, 17);
            this.lblAutos.TabIndex = 3;
            this.lblAutos.Text = "Aantal auto\'s";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(12, 129);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(83, 17);
            this.lblBegin.TabIndex = 4;
            this.lblBegin.Text = "Begindatum";
            // 
            // lblEind
            // 
            this.lblEind.AutoSize = true;
            this.lblEind.Location = new System.Drawing.Point(12, 157);
            this.lblEind.Name = "lblEind";
            this.lblEind.Size = new System.Drawing.Size(75, 17);
            this.lblEind.TabIndex = 5;
            this.lblEind.Text = "Einddatum";
            // 
            // txbMeters
            // 
            this.txbMeters.Location = new System.Drawing.Point(140, 12);
            this.txbMeters.Name = "txbMeters";
            this.txbMeters.Size = new System.Drawing.Size(100, 22);
            this.txbMeters.TabIndex = 6;
            // 
            // numPersonen
            // 
            this.numPersonen.Location = new System.Drawing.Point(140, 40);
            this.numPersonen.Name = "numPersonen";
            this.numPersonen.Size = new System.Drawing.Size(120, 22);
            this.numPersonen.TabIndex = 7;
            // 
            // numHonden
            // 
            this.numHonden.Location = new System.Drawing.Point(140, 68);
            this.numHonden.Name = "numHonden";
            this.numHonden.Size = new System.Drawing.Size(120, 22);
            this.numHonden.TabIndex = 8;
            // 
            // numAutos
            // 
            this.numAutos.Location = new System.Drawing.Point(140, 96);
            this.numAutos.Name = "numAutos";
            this.numAutos.Size = new System.Drawing.Size(120, 22);
            this.numAutos.TabIndex = 9;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(140, 124);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 22);
            this.dtpBegin.TabIndex = 10;
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(140, 152);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(200, 22);
            this.dtpEind.TabIndex = 11;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(140, 180);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 12;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 212);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(48, 17);
            this.lblAntwoord.TabIndex = 13;
            this.lblAntwoord.Text = "€ 0,00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 238);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.dtpEind);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.numAutos);
            this.Controls.Add(this.numHonden);
            this.Controls.Add(this.numPersonen);
            this.Controls.Add(this.txbMeters);
            this.Controls.Add(this.lblEind);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblAutos);
            this.Controls.Add(this.lblHonden);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.lblMeters);
            this.Name = "frmMain";
            this.Text = "Camping";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHonden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeters;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.Label lblHonden;
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEind;
        private System.Windows.Forms.TextBox txbMeters;
        private System.Windows.Forms.NumericUpDown numPersonen;
        private System.Windows.Forms.NumericUpDown numHonden;
        private System.Windows.Forms.NumericUpDown numAutos;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

