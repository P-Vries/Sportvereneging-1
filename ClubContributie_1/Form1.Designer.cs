namespace ClubContributie_1
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
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.dtpInschrijdDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbSpelend = new System.Windows.Forms.CheckBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Location = new System.Drawing.Point(104, 26);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeboortedatum.TabIndex = 0;
            // 
            // dtpInschrijdDatum
            // 
            this.dtpInschrijdDatum.Location = new System.Drawing.Point(104, 52);
            this.dtpInschrijdDatum.Name = "dtpInschrijdDatum";
            this.dtpInschrijdDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpInschrijdDatum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geboorte datum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inschrijf datum: ";
            // 
            // chbSpelend
            // 
            this.chbSpelend.AutoSize = true;
            this.chbSpelend.Location = new System.Drawing.Point(12, 12);
            this.chbSpelend.Name = "chbSpelend";
            this.chbSpelend.Size = new System.Drawing.Size(78, 17);
            this.chbSpelend.TabIndex = 4;
            this.chbSpelend.Text = "Spelend lid";
            this.chbSpelend.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(12, 84);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(86, 23);
            this.btnBereken.TabIndex = 5;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(118, 89);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 13);
            this.lblOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 116);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.chbSpelend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInschrijdDatum);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.DateTimePicker dtpInschrijdDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbSpelend;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblOut;
    }
}

