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
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.IO;
using ExcelDataReader;


namespace testUImodern
{ 
	public partial class FormMahasiswa : Form
	{
		private static MySqlConnection conn;
		User user;
		DataTable prodi;

		public static void konek()
		{
			string konek = "host=localhost;username=root;password=;database=db_quiz;sslmode=none";
			conn = new MySqlConnection(konek);
		}
		int panelWidth;
		bool Hidden;
		public FormMahasiswa()
		{
			InitializeComponent();
			panelWidth = panelQuiz.Width;
			Hidden = false;
		}

		public FormMahasiswa(string nama, string NIM)
		{

			InitializeComponent();
			panelWidth = panelQuiz.Width;
			//Hidden = false;
			lblNamaProfile.Text = nama;
			lblNIM.Text = NIM;
		}

		public FormMahasiswa(User tmp)
		{
			InitializeComponent();
			panelWidth = panelQuiz.Width;
			this.user = tmp;
			prodi = user.getProdi();
			String nama = tmp.Nama.ToString();
			//MessageBox.Show(tmp.Nama);
			tbEditNama.Text = tmp.Nama;
			lblNIM.Text = "a";
			tbEditEmail.Text = tmp.Email;
			//tbEditProdi.Text = tmp.Prodi;
			lblNamaProfile.Text = tmp.Nama;
			lblNIM.Text = tmp.Nim;
			tbEditPassword.Text = user.Password;

			cbEditProdi.Items.Clear();
			for (int i = 0; i < prodi.Rows.Count; i++) {
				cbEditProdi.Items.Add(prodi.Rows[i][1]);
			}
			cbEditProdi.SelectedItem = user.Prodi; 
		}

		int mouseX = 0, mouseY = 0;
		bool mouseDown;


		private void btnQuestion_Click(object sender, EventArgs e)
		{
			//timer1.Start();
			panelQuiz.Visible = true;
			panelRaport.Visible = false;
			panelControl.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Hidden)
			{
				panelQuiz.Width = panelQuiz.Width + 10;
				if (panelQuiz.Width >= panelWidth)
				{
					timer1.Stop();
					Hidden = false;
					this.Refresh();
				}
			}
			else
			{
				panelQuiz.Width = panelQuiz.Width - 10;
				if (panelQuiz.Width <= 0)
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
			panelQuiz.Visible = true; 
			panelRaport.Visible = true;
			panelControl.Visible = false;
			dgRaportNilai.DataSource = user.Riwayat();
			resizeDataGrid(dgRaportNilai);

		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (Hidden)
			{
				panelRaport.Width = panelRaport.Width + 10;
				if (panelRaport.Width >= panelWidth)
				{
					timer3.Stop();
					Hidden = false;
					this.Refresh();
				}
			}
			else
			{
				panelRaport.Width = panelRaport.Width - 10;
				if (panelRaport.Width <= 0)
				{
					timer3.Stop();
					Hidden = true;
					this.Refresh();
				}
			}
		}

		private void btnBack1_Click(object sender, EventArgs e)
		{
			panelQuiz.Visible = false;
		}

		private void btnBack2_Click(object sender, EventArgs e)
		{
			panelRaport.Visible = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//buttoncontrol
			panelControl.Visible = true;
			panelRaport.Visible = true;
			panelQuiz.Visible = true;
			panelProfile.Visible = false;
		}

		private void btnBack3_Click(object sender, EventArgs e)
		{
			panelControl.Visible = false;
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			panelProfile.Visible = true;
			panelControl.Visible = true;
			panelQuiz.Visible = true;
			panelRaport.Visible = true;
		}

		private void btnBack4_Click(object sender, EventArgs e)
		{
			panelProfile.Visible = false;
		}

		private void btnMakeQuiz_Click(object sender, EventArgs e)
		{
			string message = "Quiz cannot be cancel, do You want to do your quiz right now?";
			string caption = "Confirmation";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
			result = MessageBox.Show(message, caption, buttons);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				FormSoal frm = new FormSoal(this.user, user.ambilSoal(user.BrowseKdSoal));
				frm.ShowDialog();
			}
			panelCariKuis.Visible = false;
		}

		private void btnBrowseQuiz_Click(object sender, EventArgs e)
		{
			panelCariKuis.Visible = false;
			DataTable tmp = user.cariKuis(tbCariKuis.Text);
			if (tmp.Rows.Count > 0)
			{
				lblNamaDosen.Text = tmp.Rows[0][3].ToString();
				lblNamaKuis.Text = tmp.Rows[0][1].ToString();
				lblJmlSoal.Text = user.hitungSoal(tmp.Rows[0][0].ToString());
				user.BrowseKdSoal = tmp.Rows[0][0].ToString();
				if (!lblJmlSoal.Text.Equals("-1")) {
					panelCariKuis.Visible = true;
				}
			} else {
				MessageBox.Show("Kode kuis tidak ada");
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panelUtama_Paint(object sender, PaintEventArgs e)
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

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
			//Application.Run(new FormLoginRegistrasi());
			FormLoginRegistrasi frmLg = new FormLoginRegistrasi();
			frmLg.Show();
		}

		private void btnEditProdi_Click(object sender, EventArgs e)
		{
			cbEditProdi.Visible = true;
		}

		private void btnEditEmail_Click(object sender, EventArgs e)
		{
			tbEditEmail.Visible = true;
		}

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
			//isi query update
			/*string query = "UPDATE mahasiswa, user SET mahasiswa.nama = @mahasiswa.nama, user.email = @user.email WHERE mahasiswa.nim = @mahasiswa.nim AND user.user_id=@user.user_id";
			try
			{
				// Open the database
				konek();
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.CommandTimeout = 60;
				cmd.Parameters.AddWithValue("@mahasiswa.nama", tbEditNama.Text);
				//cmd.Parameters.AddWithValue("@prodi.nama", tbEditProdi.Text);
				cmd.Parameters.AddWithValue("@user.email", tbEditEmail.Text);
				//cmd.Parameters.AddWithValue("@user.password", tbEditPassword.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Data berhasil diupdate");
			}
			catch (Exception ex)
			{
				// Show any error message.
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}*/

			tbEditNama.Enabled = false;
            tbEditPassword.Enabled = false;
            tbEditEmail.Enabled = false;
            cbEditProdi.Enabled = false;
            btn_editAll.Visible = true;
            btn_editAll.Enabled = true;
            btnSaveChange.Visible = false;
            btnSaveChange.Enabled = false;

			user.updateInfo(tbEditNama.Text, prodi.Rows[cbEditProdi.SelectedIndex][0].ToString(), tbEditEmail.Text, tbEditPassword.Text, user.Nim);
        }

        private void btn_editAll_Click(object sender, EventArgs e)
        {
            tbEditNama.Enabled = true;
            tbEditPassword.Enabled = true;
            tbEditEmail.Enabled = true;
            cbEditProdi.Enabled = true;
            btnSaveChange.Enabled = true;
            btnSaveChange.Visible = true;
            btn_editAll.Visible = false;
            btn_editAll.Enabled = false;
        }

        private void lblNIM_Click(object sender, EventArgs e)
        {
            btnAccount_Click(sender, e);
        }

        private void lblNamaProfile_Click(object sender, EventArgs e)
        {
            btnAccount_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

		private void btnTampilRiwayat_Click(object sender, EventArgs e)
		{
			
		}

		private void dgRaportNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		/*private void btnEditUname_Click(object sender, EventArgs e)
		{
			tbEditUsername.Visible = true;
		}*/

		private void panelUtama_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				mouseX = MousePosition.X - 200;
				mouseY = MousePosition.Y - 40;

				this.SetDesktopLocation(mouseX, mouseY);
			}
		}

		private void btnCetakRaport_Click(object sender, EventArgs e)
		{
			Export(dgRaportNilai, "", "rapor");
		}

		private void btnFindQuiz_Click(object sender, EventArgs e)
		{
			panelQuiz.Visible = true;
		}

		private void lblNamaProfile_BackColorChanged(object sender, EventArgs e)
		{

		}

		private void btnAccount_BackColorChanged(object sender, EventArgs e)
		{
			lblNamaProfile.BackColor = btnAccount.BackColor;
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

		private void resizeDataGrid(DataGridView dg) {
			for (int i = 0; i < dg.ColumnCount; i++){
				if (i == dg.ColumnCount - 1){
					dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}else{
					dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				}
			}
			
			for (int i = 0; i < dg.ColumnCount; i++){
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
