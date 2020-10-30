namespace araba
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMarka = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblRenk = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.listboxArabalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblMarka
            // 
            this.LblMarka.AutoSize = true;
            this.LblMarka.Location = new System.Drawing.Point(50, 37);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(47, 17);
            this.LblMarka.TabIndex = 0;
            this.LblMarka.Text = "marka";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Location = new System.Drawing.Point(51, 82);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(46, 17);
            this.LblModel.TabIndex = 1;
            this.LblModel.Text = "model";
            // 
            // LblRenk
            // 
            this.LblRenk.AutoSize = true;
            this.LblRenk.Location = new System.Drawing.Point(61, 137);
            this.LblRenk.Name = "LblRenk";
            this.LblRenk.Size = new System.Drawing.Size(36, 17);
            this.LblRenk.TabIndex = 2;
            this.LblRenk.Text = "renk";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Araba a",
            "Araba b",
            "Araba c"});
            this.cmbMarka.Location = new System.Drawing.Point(149, 37);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 3;
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "kırmızı",
            "mavi",
            "sarı"});
            this.cmbRenk.Location = new System.Drawing.Point(149, 130);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(121, 24);
            this.cmbRenk.TabIndex = 4;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013"});
            this.cmbModel.Location = new System.Drawing.Point(149, 82);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 5;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(149, 193);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(106, 233);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(233, 23);
            this.BtnListele.TabIndex = 7;
            this.BtnListele.Text = "listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // listboxArabalar
            // 
            this.listboxArabalar.FormattingEnabled = true;
            this.listboxArabalar.ItemHeight = 16;
            this.listboxArabalar.Location = new System.Drawing.Point(130, 273);
            this.listboxArabalar.Name = "listboxArabalar";
            this.listboxArabalar.Size = new System.Drawing.Size(188, 116);
            this.listboxArabalar.TabIndex = 8;
            this.listboxArabalar.SelectedIndexChanged += new System.EventHandler(this.listboxArabalar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.listboxArabalar);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.LblRenk);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.LblMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMarka;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblRenk;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.ListBox listboxArabalar;
    }
}

