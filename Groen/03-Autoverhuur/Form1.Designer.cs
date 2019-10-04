namespace _03_Autoverhuur
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
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblStartVerhuur = new System.Windows.Forms.Label();
            this.lblEindVerhuur = new System.Windows.Forms.Label();
            this.lblAutoBus = new System.Windows.Forms.Label();
            this.lblExtraBenzinePrijs = new System.Windows.Forms.Label();
            this.txbKilometer = new System.Windows.Forms.TextBox();
            this.dtpStartVerhuur = new System.Windows.Forms.DateTimePicker();
            this.dtpEindVerhuur = new System.Windows.Forms.DateTimePicker();
            this.txbExtraBenzinePrijs = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.rdbPersonenAuto = new System.Windows.Forms.RadioButton();
            this.rdbPersonenBus = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(12, 15);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(116, 17);
            this.lblKilometers.TabIndex = 0;
            this.lblKilometers.Text = "Aantal kilometers";
            // 
            // lblStartVerhuur
            // 
            this.lblStartVerhuur.AutoSize = true;
            this.lblStartVerhuur.Location = new System.Drawing.Point(12, 45);
            this.lblStartVerhuur.Name = "lblStartVerhuur";
            this.lblStartVerhuur.Size = new System.Drawing.Size(91, 17);
            this.lblStartVerhuur.TabIndex = 1;
            this.lblStartVerhuur.Text = "Start verhuur";
            // 
            // lblEindVerhuur
            // 
            this.lblEindVerhuur.AutoSize = true;
            this.lblEindVerhuur.Location = new System.Drawing.Point(12, 73);
            this.lblEindVerhuur.Name = "lblEindVerhuur";
            this.lblEindVerhuur.Size = new System.Drawing.Size(89, 17);
            this.lblEindVerhuur.TabIndex = 2;
            this.lblEindVerhuur.Text = "Eind verhuur";
            // 
            // lblAutoBus
            // 
            this.lblAutoBus.AutoSize = true;
            this.lblAutoBus.Location = new System.Drawing.Point(12, 98);
            this.lblAutoBus.Name = "lblAutoBus";
            this.lblAutoBus.Size = new System.Drawing.Size(208, 17);
            this.lblAutoBus.TabIndex = 3;
            this.lblAutoBus.Text = "Personenauto of personenbus?";
            // 
            // lblExtraBenzinePrijs
            // 
            this.lblExtraBenzinePrijs.AutoSize = true;
            this.lblExtraBenzinePrijs.Location = new System.Drawing.Point(12, 126);
            this.lblExtraBenzinePrijs.Name = "lblExtraBenzinePrijs";
            this.lblExtraBenzinePrijs.Size = new System.Drawing.Size(162, 17);
            this.lblExtraBenzinePrijs.TabIndex = 4;
            this.lblExtraBenzinePrijs.Text = "Prijs bijgetankte benzine";
            // 
            // txbKilometer
            // 
            this.txbKilometer.Location = new System.Drawing.Point(226, 12);
            this.txbKilometer.Name = "txbKilometer";
            this.txbKilometer.Size = new System.Drawing.Size(100, 22);
            this.txbKilometer.TabIndex = 5;
            // 
            // dtpStartVerhuur
            // 
            this.dtpStartVerhuur.Location = new System.Drawing.Point(226, 40);
            this.dtpStartVerhuur.Name = "dtpStartVerhuur";
            this.dtpStartVerhuur.Size = new System.Drawing.Size(200, 22);
            this.dtpStartVerhuur.TabIndex = 6;
            // 
            // dtpEindVerhuur
            // 
            this.dtpEindVerhuur.Location = new System.Drawing.Point(226, 68);
            this.dtpEindVerhuur.Name = "dtpEindVerhuur";
            this.dtpEindVerhuur.Size = new System.Drawing.Size(200, 22);
            this.dtpEindVerhuur.TabIndex = 7;
            // 
            // txbExtraBenzinePrijs
            // 
            this.txbExtraBenzinePrijs.Location = new System.Drawing.Point(226, 123);
            this.txbExtraBenzinePrijs.Name = "txbExtraBenzinePrijs";
            this.txbExtraBenzinePrijs.Size = new System.Drawing.Size(100, 22);
            this.txbExtraBenzinePrijs.TabIndex = 10;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(226, 151);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 11;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 182);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(48, 17);
            this.lblAntwoord.TabIndex = 12;
            this.lblAntwoord.Text = "€ 0,00";
            // 
            // rdbPersonenAuto
            // 
            this.rdbPersonenAuto.AutoSize = true;
            this.rdbPersonenAuto.Location = new System.Drawing.Point(226, 96);
            this.rdbPersonenAuto.Name = "rdbPersonenAuto";
            this.rdbPersonenAuto.Size = new System.Drawing.Size(118, 21);
            this.rdbPersonenAuto.TabIndex = 8;
            this.rdbPersonenAuto.TabStop = true;
            this.rdbPersonenAuto.Text = "Personenauto";
            this.rdbPersonenAuto.UseVisualStyleBackColor = true;
            // 
            // rdbPersonenBus
            // 
            this.rdbPersonenBus.AutoSize = true;
            this.rdbPersonenBus.Location = new System.Drawing.Point(350, 96);
            this.rdbPersonenBus.Name = "rdbPersonenBus";
            this.rdbPersonenBus.Size = new System.Drawing.Size(113, 21);
            this.rdbPersonenBus.TabIndex = 9;
            this.rdbPersonenBus.TabStop = true;
            this.rdbPersonenBus.Text = "Personenbus";
            this.rdbPersonenBus.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 208);
            this.Controls.Add(this.rdbPersonenBus);
            this.Controls.Add(this.rdbPersonenAuto);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txbExtraBenzinePrijs);
            this.Controls.Add(this.dtpEindVerhuur);
            this.Controls.Add(this.dtpStartVerhuur);
            this.Controls.Add(this.txbKilometer);
            this.Controls.Add(this.lblExtraBenzinePrijs);
            this.Controls.Add(this.lblAutoBus);
            this.Controls.Add(this.lblEindVerhuur);
            this.Controls.Add(this.lblStartVerhuur);
            this.Controls.Add(this.lblKilometers);
            this.Name = "frmMain";
            this.Text = "Autoverhuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblStartVerhuur;
        private System.Windows.Forms.Label lblEindVerhuur;
        private System.Windows.Forms.Label lblAutoBus;
        private System.Windows.Forms.Label lblExtraBenzinePrijs;
        private System.Windows.Forms.TextBox txbKilometer;
        private System.Windows.Forms.DateTimePicker dtpStartVerhuur;
        private System.Windows.Forms.DateTimePicker dtpEindVerhuur;
        private System.Windows.Forms.TextBox txbExtraBenzinePrijs;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.RadioButton rdbPersonenAuto;
        private System.Windows.Forms.RadioButton rdbPersonenBus;
    }
}

