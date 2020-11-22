namespace WFAGunluk1_0
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
            this.lstYazilarim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtNotAlani = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lstArananlar = new System.Windows.Forms.ListBox();
            this.btnAramaİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstYazilarim
            // 
            this.lstYazilarim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstYazilarim.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstYazilarim.ForeColor = System.Drawing.SystemColors.Info;
            this.lstYazilarim.FormattingEnabled = true;
            this.lstYazilarim.ItemHeight = 20;
            this.lstYazilarim.Location = new System.Drawing.Point(20, 71);
            this.lstYazilarim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstYazilarim.Name = "lstYazilarim";
            this.lstYazilarim.Size = new System.Drawing.Size(274, 404);
            this.lstYazilarim.TabIndex = 0;
            this.lstYazilarim.SelectedIndexChanged += new System.EventHandler(this.lstYazilarim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazılarım";
            // 
            // rtxtNotAlani
            // 
            this.rtxtNotAlani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotAlani.BackColor = System.Drawing.SystemColors.Desktop;
            this.rtxtNotAlani.ForeColor = System.Drawing.SystemColors.Info;
            this.rtxtNotAlani.Location = new System.Drawing.Point(301, 103);
            this.rtxtNotAlani.Name = "rtxtNotAlani";
            this.rtxtNotAlani.Size = new System.Drawing.Size(433, 377);
            this.rtxtNotAlani.TabIndex = 3;
            this.rtxtNotAlani.Text = "";
            this.rtxtNotAlani.TextChanged += new System.EventHandler(this.rtxtNotAlani_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEkle.Location = new System.Drawing.Point(109, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(41, 31);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(20, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ara :";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAra.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtAra.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAra.Location = new System.Drawing.Point(73, 511);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(118, 26);
            this.txtAra.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAra.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAra.Location = new System.Drawing.Point(197, 488);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 72);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKaydet.Location = new System.Drawing.Point(307, 487);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(209, 72);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSil.Location = new System.Drawing.Point(523, 487);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(211, 72);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(579, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "GÜNLÜK 1.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBaslik
            // 
            this.txtBaslik.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaslik.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBaslik.Location = new System.Drawing.Point(301, 75);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(433, 22);
            this.txtBaslik.TabIndex = 9;
            this.txtBaslik.Text = " ←Tıklayarak  Bir Günlük Oluşturun Ya Da Bir Günlük Seçin";
            this.txtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBaslik.TextChanged += new System.EventHandler(this.txtBaslik_TextChanged);
            // 
            // lstArananlar
            // 
            this.lstArananlar.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstArananlar.ForeColor = System.Drawing.SystemColors.Info;
            this.lstArananlar.FormattingEnabled = true;
            this.lstArananlar.ItemHeight = 20;
            this.lstArananlar.Location = new System.Drawing.Point(20, 71);
            this.lstArananlar.Name = "lstArananlar";
            this.lstArananlar.Size = new System.Drawing.Size(274, 404);
            this.lstArananlar.TabIndex = 10;
            this.lstArananlar.Visible = false;
            this.lstArananlar.SelectedIndexChanged += new System.EventHandler(this.lstArananlar_SelectedIndexChanged);
            // 
            // btnAramaİptal
            // 
            this.btnAramaİptal.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAramaİptal.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAramaİptal.Location = new System.Drawing.Point(73, 543);
            this.btnAramaİptal.Name = "btnAramaİptal";
            this.btnAramaİptal.Size = new System.Drawing.Size(118, 33);
            this.btnAramaİptal.TabIndex = 11;
            this.btnAramaİptal.Text = "Aramaİptal";
            this.btnAramaİptal.UseVisualStyleBackColor = false;
            this.btnAramaİptal.Visible = false;
            this.btnAramaİptal.Click += new System.EventHandler(this.btnAramaİptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(778, 580);
            this.Controls.Add(this.btnAramaİptal);
            this.Controls.Add(this.lstArananlar);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rtxtNotAlani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYazilarim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gunluk 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstYazilarim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtNotAlani;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.ListBox lstArananlar;
        private System.Windows.Forms.Button btnAramaİptal;
    }
}

