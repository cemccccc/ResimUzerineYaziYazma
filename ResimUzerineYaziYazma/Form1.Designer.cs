namespace ResimUzerineYaziYazma
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
			this.BtnRenk = new System.Windows.Forms.Button();
			this.BtnResimSec = new System.Windows.Forms.Button();
			this.BtnYazdir = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtMetin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtBoyut = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnRenk
			// 
			this.BtnRenk.Location = new System.Drawing.Point(212, 114);
			this.BtnRenk.Name = "BtnRenk";
			this.BtnRenk.Size = new System.Drawing.Size(120, 54);
			this.BtnRenk.TabIndex = 5;
			this.BtnRenk.Text = "Renk Seç";
			this.BtnRenk.UseVisualStyleBackColor = true;
			this.BtnRenk.Click += new System.EventHandler(this.BtnRenk_Click);
			// 
			// BtnResimSec
			// 
			this.BtnResimSec.Location = new System.Drawing.Point(85, 114);
			this.BtnResimSec.Name = "BtnResimSec";
			this.BtnResimSec.Size = new System.Drawing.Size(120, 54);
			this.BtnResimSec.TabIndex = 1;
			this.BtnResimSec.Text = "Resim Seç";
			this.BtnResimSec.UseVisualStyleBackColor = true;
			this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
			// 
			// BtnYazdir
			// 
			this.BtnYazdir.Location = new System.Drawing.Point(212, 174);
			this.BtnYazdir.Name = "BtnYazdir";
			this.BtnYazdir.Size = new System.Drawing.Size(120, 54);
			this.BtnYazdir.TabIndex = 7;
			this.BtnYazdir.Text = "Yazdır";
			this.BtnYazdir.UseVisualStyleBackColor = true;
			this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(85, 174);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(120, 54);
			this.BtnKaydet.TabIndex = 6;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Metin:";
			// 
			// TxtMetin
			// 
			this.TxtMetin.Location = new System.Drawing.Point(85, 35);
			this.TxtMetin.Name = "TxtMetin";
			this.TxtMetin.Size = new System.Drawing.Size(247, 27);
			this.TxtMetin.TabIndex = 2;
			this.TxtMetin.Leave += new System.EventHandler(this.TxtMetin_Leave);
			this.TxtMetin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtMetin_MouseDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Boyut:";
			// 
			// TxtBoyut
			// 
			this.TxtBoyut.Location = new System.Drawing.Point(85, 68);
			this.TxtBoyut.Name = "TxtBoyut";
			this.TxtBoyut.Size = new System.Drawing.Size(247, 27);
			this.TxtBoyut.TabIndex = 3;
			this.TxtBoyut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoyut_KeyPress);
			this.TxtBoyut.Leave += new System.EventHandler(this.TxtBoyut_Leave);
			this.TxtBoyut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtBoyut_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(361, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(316, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AcceptButton = this.BtnKaydet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 254);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TxtBoyut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtMetin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.BtnYazdir);
			this.Controls.Add(this.BtnResimSec);
			this.Controls.Add(this.BtnRenk);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Resim Üzerine Yazı Yazdırma";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnRenk;
		private System.Windows.Forms.Button BtnResimSec;
		private System.Windows.Forms.Button BtnYazdir;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtMetin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtBoyut;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}

