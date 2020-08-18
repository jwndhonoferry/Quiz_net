using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace testUImodern
{
	public partial class FormKuisBaru : Form
	{
		int mouseX = 0, mouseY = 0;
		bool mouseDown;
		Dosen dosen;
		DataTable tmp;

		public FormKuisBaru()
		{
			InitializeComponent();
		}

		public FormKuisBaru(Dosen tmp)
		{
			InitializeComponent();
			this.dosen = tmp;
		}


		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panelUtamaFrmSoal_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
		}

		private void panelUtamaFrmSoal_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				mouseX = MousePosition.X - 200;
				mouseY = MousePosition.Y - 40;

				this.SetDesktopLocation(mouseX, mouseY);
			}
		}

		private void panelUtamaFrmSoal_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void btnBrowseFile_Click(object sender, EventArgs e)
		{
			DataSet result;
			using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx;", ValidateNames = true })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					lblNamaFile.Text = ofd.FileName;

					//Read excel file
					FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
					IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

					result = reader.AsDataSet(new ExcelDataSetConfiguration
					{
						ConfigureDataTable = _ => new ExcelDataTableConfiguration
						{
							UseHeaderRow = true
						}
					});
					if (result.Tables.Count > 0)
					{
						//var dtData = result.Tables[0];
						this.tmp = result.Tables[0];
						//MessageBox.Show(dtData.Rows[0][0].ToString());
						//    -------------- dataGridView1.DataSource = dtData;
						// comboBox1.Items.Clear();
						//Add sheet to combobox
						// foreach (DataTable dt in result.Tables)
						//comboBox1.Items.Add(dt.TableName);
						//reader.Close();
						//dataGridView1.DataSource = result.Tables[0];
					}
				}
			}
		}

		private void btnBuatKuis_Click(object sender, EventArgs e)
		{
			if (tmp != null)
			{
				dosen.tambahKuis(BMtbJudulQuiz.Text, this.tmp);
				this.tmp = null;
				MessageBox.Show("Quiz has been added");
				this.Close();
			}
			else {
				MessageBox.Show("Choose your question file");
			}
			
		}
	}
}
