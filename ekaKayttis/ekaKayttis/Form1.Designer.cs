namespace ekaKayttis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tekstirivi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monirivinen = new System.Windows.Forms.TextBox();
            this.siirtonappula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tekstirivi
            // 
            this.tekstirivi.Location = new System.Drawing.Point(104, 45);
            this.tekstirivi.Name = "tekstirivi";
            this.tekstirivi.Size = new System.Drawing.Size(100, 23);
            this.tekstirivi.TabIndex = 1;
            this.tekstirivi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tekstirivi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tekstijuttu";
            // 
            // monirivinen
            // 
            this.monirivinen.Location = new System.Drawing.Point(30, 88);
            this.monirivinen.Multiline = true;
            this.monirivinen.Name = "monirivinen";
            this.monirivinen.Size = new System.Drawing.Size(174, 88);
            this.monirivinen.TabIndex = 3;
            // 
            // siirtonappula
            // 
            this.siirtonappula.Location = new System.Drawing.Point(238, 45);
            this.siirtonappula.Name = "siirtonappula";
            this.siirtonappula.Size = new System.Drawing.Size(75, 23);
            this.siirtonappula.TabIndex = 4;
            this.siirtonappula.Text = "Siirrä";
            this.siirtonappula.UseVisualStyleBackColor = true;
            this.siirtonappula.Click += new System.EventHandler(this.siirtonappula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siirtonappula);
            this.Controls.Add(this.monirivinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekstirivi);
            this.Name = "Form1";
            this.Text = "OTSIKKO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tekstirivi;
        private Label label1;
        private TextBox monirivinen;
        private Button siirtonappula;
    }
}