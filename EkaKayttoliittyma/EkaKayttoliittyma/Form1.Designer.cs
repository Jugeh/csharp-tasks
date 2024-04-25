namespace EkaKayttoliittyma
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
            this.label1 = new System.Windows.Forms.Label();
            this.tekstirivi = new System.Windows.Forms.TextBox();
            this.tekstilaatikko = new System.Windows.Forms.TextBox();
            this.siirtonappula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekstihomma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tekstirivi
            // 
            this.tekstirivi.Location = new System.Drawing.Point(107, 20);
            this.tekstirivi.Name = "tekstirivi";
            this.tekstirivi.Size = new System.Drawing.Size(125, 22);
            this.tekstirivi.TabIndex = 1;
            this.tekstirivi.TextChanged += new System.EventHandler(this.tekstirivi_TextChanged);
            // 
            // tekstilaatikko
            // 
            this.tekstilaatikko.Location = new System.Drawing.Point(15, 60);
            this.tekstilaatikko.Multiline = true;
            this.tekstilaatikko.Name = "tekstilaatikko";
            this.tekstilaatikko.Size = new System.Drawing.Size(217, 71);
            this.tekstilaatikko.TabIndex = 2;
            // 
            // siirtonappula
            // 
            this.siirtonappula.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.siirtonappula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siirtonappula.Location = new System.Drawing.Point(256, 18);
            this.siirtonappula.Name = "siirtonappula";
            this.siirtonappula.Size = new System.Drawing.Size(81, 32);
            this.siirtonappula.TabIndex = 3;
            this.siirtonappula.Text = "Siirrä";
            this.siirtonappula.UseVisualStyleBackColor = false;
            this.siirtonappula.Click += new System.EventHandler(this.siirtonappula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.siirtonappula);
            this.Controls.Add(this.tekstilaatikko);
            this.Controls.Add(this.tekstirivi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OTSIKKO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tekstirivi;
        private System.Windows.Forms.TextBox tekstilaatikko;
        private System.Windows.Forms.Button siirtonappula;
    }
}

