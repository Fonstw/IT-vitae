namespace _02_Ouderbrijdrage_school
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
            this.lblOnderTien = new System.Windows.Forms.Label();
            this.lblTienOfOuder = new System.Windows.Forms.Label();
            this.lblEenOuderGezin = new System.Windows.Forms.Label();
            this.ckbEenOuderGezin = new System.Windows.Forms.CheckBox();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.numUnderTen = new System.Windows.Forms.NumericUpDown();
            this.numTenOrOlder = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUnderTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTenOrOlder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnderTien
            // 
            this.lblOnderTien.AutoSize = true;
            this.lblOnderTien.Location = new System.Drawing.Point(12, 14);
            this.lblOnderTien.Name = "lblOnderTien";
            this.lblOnderTien.Size = new System.Drawing.Size(168, 17);
            this.lblOnderTien.TabIndex = 0;
            this.lblOnderTien.Text = "Aantal kinderen onder 10";
            // 
            // lblTienOfOuder
            // 
            this.lblTienOfOuder.AutoSize = true;
            this.lblTienOfOuder.Location = new System.Drawing.Point(12, 43);
            this.lblTienOfOuder.Name = "lblTienOfOuder";
            this.lblTienOfOuder.Size = new System.Drawing.Size(184, 17);
            this.lblTienOfOuder.TabIndex = 1;
            this.lblTienOfOuder.Text = "Aantal kinderen 10 of ouder";
            // 
            // lblEenOuderGezin
            // 
            this.lblEenOuderGezin.AutoSize = true;
            this.lblEenOuderGezin.Location = new System.Drawing.Point(12, 69);
            this.lblEenOuderGezin.Name = "lblEenOuderGezin";
            this.lblEenOuderGezin.Size = new System.Drawing.Size(112, 17);
            this.lblEenOuderGezin.TabIndex = 2;
            this.lblEenOuderGezin.Text = "Eénoudergezin?";
            // 
            // ckbEenOuderGezin
            // 
            this.ckbEenOuderGezin.AutoSize = true;
            this.ckbEenOuderGezin.Location = new System.Drawing.Point(202, 68);
            this.ckbEenOuderGezin.Name = "ckbEenOuderGezin";
            this.ckbEenOuderGezin.Size = new System.Drawing.Size(45, 21);
            this.ckbEenOuderGezin.TabIndex = 5;
            this.ckbEenOuderGezin.Text = "Ja";
            this.ckbEenOuderGezin.UseVisualStyleBackColor = true;
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 129);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(48, 17);
            this.lblAntwoord.TabIndex = 7;
            this.lblAntwoord.Text = "€ 0,00";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(202, 95);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // numUnderTen
            // 
            this.numUnderTen.Location = new System.Drawing.Point(202, 12);
            this.numUnderTen.Name = "numUnderTen";
            this.numUnderTen.Size = new System.Drawing.Size(75, 22);
            this.numUnderTen.TabIndex = 3;
            // 
            // numTenOrOlder
            // 
            this.numTenOrOlder.Location = new System.Drawing.Point(202, 40);
            this.numTenOrOlder.Name = "numTenOrOlder";
            this.numTenOrOlder.Size = new System.Drawing.Size(75, 22);
            this.numTenOrOlder.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 155);
            this.Controls.Add(this.numTenOrOlder);
            this.Controls.Add(this.numUnderTen);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.ckbEenOuderGezin);
            this.Controls.Add(this.lblEenOuderGezin);
            this.Controls.Add(this.lblTienOfOuder);
            this.Controls.Add(this.lblOnderTien);
            this.Name = "frmMain";
            this.Text = "Ouderbijdrage school";
            ((System.ComponentModel.ISupportInitialize)(this.numUnderTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTenOrOlder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOnderTien;
        private System.Windows.Forms.Label lblTienOfOuder;
        private System.Windows.Forms.Label lblEenOuderGezin;
        private System.Windows.Forms.CheckBox ckbEenOuderGezin;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.NumericUpDown numUnderTen;
        private System.Windows.Forms.NumericUpDown numTenOrOlder;
    }
}

