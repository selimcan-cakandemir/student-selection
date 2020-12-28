
namespace _51_WFA_OgrenciListe
{
    partial class Select
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
            this.btnOgrenciSecimi = new System.Windows.Forms.Button();
            this.btnKonuSecimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application seçiniz:";
            // 
            // btnOgrenciSecimi
            // 
            this.btnOgrenciSecimi.AutoSize = true;
            this.btnOgrenciSecimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenciSecimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenciSecimi.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciSecimi.Location = new System.Drawing.Point(12, 58);
            this.btnOgrenciSecimi.Name = "btnOgrenciSecimi";
            this.btnOgrenciSecimi.Size = new System.Drawing.Size(244, 221);
            this.btnOgrenciSecimi.TabIndex = 1;
            this.btnOgrenciSecimi.Text = "Öğrenci Seçimi";
            this.btnOgrenciSecimi.UseVisualStyleBackColor = false;
            this.btnOgrenciSecimi.Click += new System.EventHandler(this.btnOgrenciSecimi_Click);
            // 
            // btnKonuSecimi
            // 
            this.btnKonuSecimi.AutoSize = true;
            this.btnKonuSecimi.BackColor = System.Drawing.Color.LightCoral;
            this.btnKonuSecimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKonuSecimi.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonuSecimi.Location = new System.Drawing.Point(262, 58);
            this.btnKonuSecimi.Name = "btnKonuSecimi";
            this.btnKonuSecimi.Size = new System.Drawing.Size(241, 221);
            this.btnKonuSecimi.TabIndex = 1;
            this.btnKonuSecimi.Text = "Konu Seçimi";
            this.btnKonuSecimi.UseVisualStyleBackColor = false;
            this.btnKonuSecimi.Click += new System.EventHandler(this.btnKonuSecimi_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.btnKonuSecimi);
            this.Controls.Add(this.btnOgrenciSecimi);
            this.Controls.Add(this.label1);
            this.Name = "Select";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciSecimi;
        private System.Windows.Forms.Button btnKonuSecimi;
    }
}