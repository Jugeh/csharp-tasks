namespace Limppariautomaatti
{
    partial class automaatti
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
            this.pullonhinta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rahansyotto = new System.Windows.Forms.TextBox();
            this.siirtonappi = new System.Windows.Forms.Button();
            this.syotetut = new System.Windows.Forms.Label();
            this.rahaasyotetty = new System.Windows.Forms.TextBox();
            this.ostovaikka = new System.Windows.Forms.Label();
            this.ostapullo = new System.Windows.Forms.Button();
            this.palautetutrahat = new System.Windows.Forms.TextBox();
            this.massit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pullonhinta
            // 
            this.pullonhinta.AutoSize = true;
            this.pullonhinta.Location = new System.Drawing.Point(19, 32);
            this.pullonhinta.Name = "pullonhinta";
            this.pullonhinta.Size = new System.Drawing.Size(97, 15);
            this.pullonhinta.TabIndex = 0;
            this.pullonhinta.Text = "Pullon hinta = 2$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Syötä rahaa:";
            // 
            // rahansyotto
            // 
            this.rahansyotto.Location = new System.Drawing.Point(125, 64);
            this.rahansyotto.Name = "rahansyotto";
            this.rahansyotto.Size = new System.Drawing.Size(60, 23);
            this.rahansyotto.TabIndex = 2;
            this.rahansyotto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rahansyotto_KeyDown);
            // 
            // siirtonappi
            // 
            this.siirtonappi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.siirtonappi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siirtonappi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siirtonappi.Location = new System.Drawing.Point(209, 64);
            this.siirtonappi.Name = "siirtonappi";
            this.siirtonappi.Size = new System.Drawing.Size(60, 23);
            this.siirtonappi.TabIndex = 3;
            this.siirtonappi.Text = "Syötä rahat";
            this.siirtonappi.UseVisualStyleBackColor = false;
            this.siirtonappi.Click += new System.EventHandler(this.siirtonappi_Click);
            // 
            // syotetut
            // 
            this.syotetut.AutoSize = true;
            this.syotetut.Location = new System.Drawing.Point(19, 103);
            this.syotetut.Name = "syotetut";
            this.syotetut.Size = new System.Drawing.Size(87, 15);
            this.syotetut.TabIndex = 4;
            this.syotetut.Text = "Rahaa syötetty:";
            // 
            // rahaasyotetty
            // 
            this.rahaasyotetty.Location = new System.Drawing.Point(125, 103);
            this.rahaasyotetty.Name = "rahaasyotetty";
            this.rahaasyotetty.Size = new System.Drawing.Size(60, 23);
            this.rahaasyotetty.TabIndex = 5;
            // 
            // ostovaikka
            // 
            this.ostovaikka.AutoSize = true;
            this.ostovaikka.Location = new System.Drawing.Point(19, 141);
            this.ostovaikka.Name = "ostovaikka";
            this.ostovaikka.Size = new System.Drawing.Size(64, 15);
            this.ostovaikka.TabIndex = 6;
            this.ostovaikka.Text = "Osta pullo:";
            // 
            // ostapullo
            // 
            this.ostapullo.BackColor = System.Drawing.Color.RosyBrown;
            this.ostapullo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ostapullo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ostapullo.Location = new System.Drawing.Point(125, 141);
            this.ostapullo.Name = "ostapullo";
            this.ostapullo.Size = new System.Drawing.Size(60, 23);
            this.ostapullo.TabIndex = 7;
            this.ostapullo.Text = "Osta";
            this.ostapullo.UseVisualStyleBackColor = false;
            this.ostapullo.Click += new System.EventHandler(this.ostapullo_Click);
            // 
            // palautetutrahat
            // 
            this.palautetutrahat.Location = new System.Drawing.Point(125, 185);
            this.palautetutrahat.Name = "palautetutrahat";
            this.palautetutrahat.Size = new System.Drawing.Size(60, 23);
            this.palautetutrahat.TabIndex = 8;
            // 
            // massit
            // 
            this.massit.AutoSize = true;
            this.massit.Location = new System.Drawing.Point(20, 185);
            this.massit.Name = "massit";
            this.massit.Size = new System.Drawing.Size(99, 15);
            this.massit.TabIndex = 9;
            this.massit.Text = "Rahaa palautettu:";
            // 
            // automaatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.massit);
            this.Controls.Add(this.palautetutrahat);
            this.Controls.Add(this.ostapullo);
            this.Controls.Add(this.ostovaikka);
            this.Controls.Add(this.rahaasyotetty);
            this.Controls.Add(this.syotetut);
            this.Controls.Add(this.siirtonappi);
            this.Controls.Add(this.rahansyotto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pullonhinta);
            this.Name = "automaatti";
            this.Text = "Automaatti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pullonhinta;
        private Label label1;
        private TextBox rahansyotto;
        private Button siirtonappi;
        private Label syotetut;
        private TextBox rahaasyotetty;
        private Label ostovaikka;
        private Button ostapullo;
        private TextBox palautetutrahat;
        private Label massit;
    }
}