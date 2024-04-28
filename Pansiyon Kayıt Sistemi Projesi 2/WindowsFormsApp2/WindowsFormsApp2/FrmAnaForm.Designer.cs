namespace WindowsFormsApp2
{
    partial class FrmAnaForm
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
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Turquoise;
            this.BtnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(75, 181);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(156, 83);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Yönetici Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.BackColor = System.Drawing.Color.Turquoise;
            this.BtnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriEkle.Location = new System.Drawing.Point(323, 181);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(156, 83);
            this.BtnMusteriEkle.TabIndex = 1;
            this.BtnMusteriEkle.Text = "Yeni Müşteri";
            this.BtnMusteriEkle.UseVisualStyleBackColor = false;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.BackColor = System.Drawing.Color.Turquoise;
            this.BtnOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdalar.Location = new System.Drawing.Point(575, 181);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(156, 83);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = false;
            this.BtnOdalar.Click += new System.EventHandler(this.BtnOdalar_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Controls.Add(this.BtnAdminGiris);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnOdalar;
    }
}