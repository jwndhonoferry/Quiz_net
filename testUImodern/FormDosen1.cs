using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizLogin;
using ExcelDataReader;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace testUImodern
{
	public partial class FormDosen1 : Form
	{
		int panelWidth;
		bool Hidden;
        int mousex = 0, mousey = 0;
        bool mouseDown;
		Dosen dosen;
		List<string> tmpKdSoal = new List<string>();
		DataTable Fakultas;

		public FormDosen1()
		{
			InitializeComponent();
			panelWidth = panelQuizDosen.Width;
			Hidden = false;
		}

		public FormDosen1(Dosen tmp) {
			InitializeComponent();
			panelWidth = panelQuizDosen.Width;
			Hidden = false;

			this.dosen = tmp;
			String nama = tmp.Nama.ToString();
			//MessageBox.Show(tmp.Nama);
			tbEditNama.Text = tmp.Nama;
			lblNamaProfile.Text = tmp.Nama;
			lblNidn.Text = tmp.Nidn;
			tbEditPassword.Text = dosen.Password;
			tbEditEmail.Text = dosen.Email;

			Fakultas = dosen.getFakultas();
			for (int i = 0; i < Fakultas.Rows.Count; i++)
			{
				cbEditProdiDosen.Items.Add(Fakultas.Rows[i][1]);
			}

			cbEditProdiDosen.SelectedItem = dosen.Fakultas;
			//tbEditEmail.Text = tmp.Email;
			//tbEditProdi.Text = tmp.Prodi;
			//lblNamaProfile.Text = tmp.Nama;
			//lblNIM.Text = tmp.Nim;
			//dgRaportNilai.DataSource = tmp.Riwayat();
		}

		private void btnQuestion_Click(object sender, EventArgs e)
		{
			//timer1.Start();
			panelQuizDosen.Visible = true;
			panelRaportDosen.Visible = false;
			panelControl.Visible = false;

			DGQuiz.DataSource = dosen.recentKuis();
			resizeDataGrid(DGQuiz);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Hidden)
			{
				panelQuizDosen.Width = panelQuizDosen.Width + 10;
				if (panelQuizDosen.Width >= panelWidth)
				{
					timer1.Stop();
					Hidden = false;
					this.Refresh();
				}
			}
			else
			{
				panelQuizDosen.Width = panelQuizDosen.Width - 10;
				if (panelQuizDosen.Width <= 0)
				{
					timer1.Stop();
					Hidden = true;					
					this.Refresh();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			timer2.Start();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (this.Opacity > 0.00)
			{
				this.Opacity -= 0.1;
			}
			else
			{
				timer2.Stop();
				Application.Exit();
			}
		}

		private void btnRaport_Click(object sender, EventArgs e)
		{
			//timer3.Start();
			cbKuis.Items.Clear();

			panelQuizDosen.Visible = true; 
			panelRaportDosen.Visible = true;
			panelControl.Visible = false;

			List<string>  tmp = dosen.riwayatKuis();

			foreach (var kuis in tmp) {
				cbKuis.Items.Add(kuis.Substring(11));
			}

			this.tmpKdSoal = tmp;
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (Hidden)
			{
				panelRaportDosen.Width = panelRaportDosen.Width + 10;
				if (panelRaportDosen.Width >= panelWidth)
				{
					timer3.Stop();
					Hidden = false;
					this.Refresh();
				}
			}
			else
			{
				panelRaportDosen.Width = panelRaportDosen.Width - 10;
				if (panelRaportDosen.Width <= 0)
				{
					timer3.Stop();
					Hidden = true;
					this.Refresh();
				}
			}
		}

		private void btnBack1_Click(object sender, EventArgs e)
		{
			panelQuizDosen.Visible = false;
		}

		private void btnBack2_Click(object sender, EventArgs e)
		{
			panelRaportDosen.Visible = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			panelControl.Visible = true;
			panelQuizDosen.Visible = true;
			panelRaportDosen.Visible = true;
			panelProfileDosen.Visible = false;
		}

		private void btnBack3_Click(object sender, EventArgs e)
		{
			panelControl.Visible = false;
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			panelProfileDosen.Visible = true;
			panelControl.Visible = true;
			panelQuizDosen.Visible = true;
			panelRaportDosen.Visible = true;
		}

		private void btnBack4_Click(object sender, EventArgs e)
		{
			panelProfileDosen.Visible = false;
		}

		private void btnMakeQuiz_Click(object sender, EventArgs e)
		{

		}

        private void panelUtama_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelUtama_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelUtama_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 200;
                mousey = MousePosition.Y - 40;
                this.SetDesktopLocation(mousex,mousey);
            }
        }

		private void btnLogoutDosen_Click(object sender, EventArgs e)
		{
			this.Close();
			//Application.Run(new FormLoginRegistrasi());
			FormLoginRegistrasi frmLg = new FormLoginRegistrasi();
			frmLg.Show();
		}

		private void btnCetakRaporDosen_Click(object sender, EventArgs e)
		{
			Export(dgRaport, "", "Hasil Kuis");
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			FormKuisBaru frmKB = new FormKuisBaru(dosen);
			frmKB.ShowDialog();
		}

		private void cbKuis_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgRaport.DataSource = dosen.lihatNilai(tmpKdSoal[cbKuis.SelectedIndex].Substring(0,8));
			resizeDataGrid(dgRaport);
		}

		private void DGQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = DGQuiz.CurrentCell.RowIndex;
			int coloumnindex = DGQuiz.CurrentCell.ColumnIndex;

			DGQuiz.Rows[rowindex].Cells[coloumnindex].Value.ToString();
		}

		private void btnHapusKuis_Click(object sender, EventArgs e)
		{
			if (DGQuiz.SelectedCells.Count > 0)
			{
				//int i = DGQuiz.SelectedCells[0].RowIndex;
				//MessageBox.Show(DGQuiz.SelectedRows[i].Cells[0].Value.ToString());
				//MessageBox.Show();
				dosen.hapusKuis(DGQuiz.Rows[DGQuiz.CurrentCell.RowIndex].Cells[0].Value.ToString());

				//databaseconn.open();
				//string q1 = "delete from soal where kd_soal=@kd");
				//mysqlcommand cmd = new mysqlcommand(q1, databaseconn);
				//cmd.paramaters.addwithvalue("@kd", ;
				//if (DGQuiz.Rows.Count > 1 && i != DGQuiz.Rows.Count - 1) {
				//	cmd.executenonquery();

				//}
				//databaseconn.close();

			}
			DGQuiz.DataSource = dosen.recentKuis();
			resizeDataGrid(DGQuiz);

		}

		private void FormDosen1_Activated(object sender, EventArgs e)
		{
			DGQuiz.DataSource = dosen.recentKuis();
			resizeDataGrid(DGQuiz);
		}

		private void Export(DataGridView dg, String Header, string filename)
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdftable = new PdfPTable(dg.Columns.Count);
			//MessageBox.Show(dg.Columns.Count.ToString());
			pdftable.DefaultCell.PaddingTop = 20;
			pdftable.DefaultCell.PaddingBottom = 20;
			pdftable.WidthPercentage = 100;
			pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdftable.DefaultCell.BorderWidth = 1;
			iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
			//Add Header
			foreach (DataGridViewColumn column in dg.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
				//cell.BackgroundColor = new iTextSharp.text.Color(240,240,240);
				pdftable.AddCell(cell);
			}
			//add data row

			foreach (DataGridViewRow row in dg.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					//here HERERERERERERER
					pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
				}
			}
			var savefiledialoge = new SaveFileDialog();
			savefiledialoge.FileName = filename;
			savefiledialoge.DefaultExt = ".pdf";
			string imageFilePath = @"C:\Users\User\Desktop\Materi Kuliah\Refer Matkul Sem 5\Pemrograman Platform Khusus\Logo.png";
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);
			jpg.ScaleToFit(80, 120);
			jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
			jpg.SetAbsolutePosition(250, 25);

			if (savefiledialoge.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
					PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);

					pdfdoc.Open();
					Paragraph prg = new Paragraph(" == Hasil Raport ==");
					Paragraph pr = new Paragraph(" ");
					BaseFont bfHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
					iTextSharp.text.Font fthead = new iTextSharp.text.Font(bfHead, 16, 1);
					prg.Alignment = Element.ALIGN_CENTER;
					prg.Add(new Chunk(Header.ToUpper()));
					pdfdoc.Add(prg);
					pdfdoc.Add(pr);
					pdfdoc.Add(pr);
					pdfdoc.Add(jpg);
					LineSeparator underline = new LineSeparator(5, 100, null, Element.ALIGN_CENTER, -2);
					pdfdoc.Add(underline);
					pdfdoc.Add(pdftable);
					pdfdoc.Close();
					stream.Close();
				}
			}
		}

		private void btnSaveChange_Click(object sender, EventArgs e)
		{
			tbEditNama.Enabled = false;
			tbEditPassword.Enabled = false;
			tbEditEmail.Enabled = false;
			cbEditProdiDosen.Enabled = false;
			btn_editAll.Visible = true;
			btn_editAll.Enabled = true;
			btnSaveChange.Visible = false;
			btnSaveChange.Enabled = false;

			MessageBox.Show(Fakultas.Rows[cbEditProdiDosen.SelectedIndex][0].ToString());
			dosen.updateInfo(tbEditNama.Text, Fakultas.Rows[cbEditProdiDosen.SelectedIndex][0].ToString(), tbEditEmail.Text, tbEditPassword.Text, dosen.Nidn);
		}

		private void btn_editAll_Click(object sender, EventArgs e)
		{
			tbEditNama.Enabled = true;
			tbEditPassword.Enabled = true;
			tbEditEmail.Enabled = true;
			cbEditProdiDosen.Enabled = true;
			btnSaveChange.Enabled = true;
			btnSaveChange.Visible = true;
			btn_editAll.Visible = false;
			btn_editAll.Enabled = false;
		}

		private void resizeDataGrid(DataGridView dg)
		{
			for (int i = 0; i < dg.ColumnCount; i++)
			{
				if (i == dg.ColumnCount - 1)
				{
					dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				else
				{
					dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				}
			}

			for (int i = 0; i < dg.ColumnCount; i++)
			{
				//store autosized widths
				int colw = dg.Columns[i].Width;
				//remove autosizing
				dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				//set width to calculated by autosize
				dg.Columns[i].Width = colw;
			}
		}
	}
}
