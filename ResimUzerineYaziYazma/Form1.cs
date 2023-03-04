using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimUzerineYaziYazma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffa585");
			BtnKaydet.BackColor = Color.GreenYellow;
			TxtMetin.Text = "Yazdırılacak Metni Giriniz";
			TxtBoyut.Text = "Metin Boyutunu Giriniz";
			TxtBoyut.ForeColor= Color.Gray;
			TxtMetin.ForeColor=Color.Gray;
		}

		string resim;
		Color renk;
		Bitmap bmp;

		private void BtnResimSec_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			resim = openFileDialog1.FileName;
			if (resim != "openFileDialog1")
			{
				MessageBox.Show("Resim Seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Lütfen resim seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnRenk_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			renk = colorDialog1.Color;
			MessageBox.Show("Renk Seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			BtnRenk.BackColor = renk;
		}

		private void BtnYazdir_Click(object sender, EventArgs e)
		{
			try
			{
				bmp = new Bitmap(resim);
				Graphics gr = Graphics.FromImage(bmp);
				gr.DrawString(TxtMetin.Text, new Font("Calibri", Convert.ToInt16(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
				pictureBox1.Image = bmp;
			}
			catch (Exception)
			{
				MessageBox.Show("Tüm Bilgiler Girilmelidir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtBoyut.Text.Length > 0 && TxtMetin.Text.Length > 0)
				{
					saveFileDialog1.Filter = "Resim|.jpg";
					saveFileDialog1.ShowDialog();
					bmp.Save(saveFileDialog1.FileName);
				}
				else
				{
					MessageBox.Show("Görsel yazdırılmadan kaydetme işlemi gerçekleşemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Görsel yazdırılmadan kaydetme işlemi gerçekleşemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void TxtBoyut_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void TxtMetin_MouseDown(object sender, MouseEventArgs e)
		{
			TxtMetin.Clear();
			TxtMetin.ForeColor = Color.Black;
		}

		private void TxtMetin_Leave(object sender, EventArgs e)
		{
			if (TxtMetin.Text.Length==0)
			{
				TxtMetin.Text = "Yazdırılacak Metni Giriniz";
				TxtMetin.ForeColor = Color.Gray;
			}
		}

		private void TxtBoyut_MouseDown(object sender, MouseEventArgs e)
		{
			TxtBoyut.Clear();
			TxtBoyut.ForeColor = Color.Black;
		}

		private void TxtBoyut_Leave(object sender, EventArgs e)
		{
			if (TxtBoyut.Text.Length==0)
			{
				TxtBoyut.Text = "Metin Boyutunu Giriniz";
				TxtBoyut.ForeColor = Color.Gray;
			}
		}

	}
}
