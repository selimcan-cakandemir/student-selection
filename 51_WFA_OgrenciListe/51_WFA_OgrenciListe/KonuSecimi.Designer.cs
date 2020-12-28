
namespace _51_WFA_OgrenciListe
{
    partial class KonuSecimi
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
            this.lbOgrenciListesi = new System.Windows.Forms.ListBox();
            this.lbKonuListesi = new System.Windows.Forms.ListBox();
            this.lblOgrenciIsmi = new System.Windows.Forms.Label();
            this.lblKonuIsmi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.mcTarih = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOgrenciListesi
            // 
            this.lbOgrenciListesi.BackColor = System.Drawing.Color.MistyRose;
            this.lbOgrenciListesi.FormattingEnabled = true;
            this.lbOgrenciListesi.Location = new System.Drawing.Point(12, 12);
            this.lbOgrenciListesi.Name = "lbOgrenciListesi";
            this.lbOgrenciListesi.Size = new System.Drawing.Size(229, 381);
            this.lbOgrenciListesi.TabIndex = 0;
            // 
            // lbKonuListesi
            // 
            this.lbKonuListesi.BackColor = System.Drawing.Color.MistyRose;
            this.lbKonuListesi.FormattingEnabled = true;
            this.lbKonuListesi.Location = new System.Drawing.Point(247, 12);
            this.lbKonuListesi.Name = "lbKonuListesi";
            this.lbKonuListesi.Size = new System.Drawing.Size(229, 381);
            this.lbKonuListesi.TabIndex = 0;
            // 
            // lblOgrenciIsmi
            // 
            this.lblOgrenciIsmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOgrenciIsmi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOgrenciIsmi.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenciIsmi.Location = new System.Drawing.Point(483, 12);
            this.lblOgrenciIsmi.Name = "lblOgrenciIsmi";
            this.lblOgrenciIsmi.Size = new System.Drawing.Size(226, 27);
            this.lblOgrenciIsmi.TabIndex = 2;
            this.lblOgrenciIsmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKonuIsmi
            // 
            this.lblKonuIsmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKonuIsmi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblKonuIsmi.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonuIsmi.Location = new System.Drawing.Point(483, 48);
            this.lblKonuIsmi.Name = "lblKonuIsmi";
            this.lblKonuIsmi.Size = new System.Drawing.Size(226, 27);
            this.lblKonuIsmi.TabIndex = 2;
            this.lblKonuIsmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(481, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih seçiniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(481, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "SEÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarih.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTarih.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(482, 85);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(227, 27);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "-";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcTarih
            // 
            this.mcTarih.BackColor = System.Drawing.Color.SeaShell;
            this.mcTarih.Location = new System.Drawing.Point(482, 138);
            this.mcTarih.Name = "mcTarih";
            this.mcTarih.TabIndex = 5;
            this.mcTarih.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcTarih_DateSelected);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(481, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KonuSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mcTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblKonuIsmi);
            this.Controls.Add(this.lblOgrenciIsmi);
            this.Controls.Add(this.lbKonuListesi);
            this.Controls.Add(this.lbOgrenciListesi);
            this.Name = "KonuSecimi";
            this.Text = "KonuSecimi";
            this.Load += new System.EventHandler(this.KonuSecimi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOgrenciListesi;
        private System.Windows.Forms.ListBox lbKonuListesi;
        private System.Windows.Forms.Label lblOgrenciIsmi;
        private System.Windows.Forms.Label lblKonuIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MonthCalendar mcTarih;
        private System.Windows.Forms.Button button2;
    }
}