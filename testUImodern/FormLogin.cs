using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testUImodern;
using MySql.Data.MySqlClient;

namespace QuizLogin
{
    public partial class FormLoginRegistrasi : Form
    {
		//MySqlConnection conn;
		//String connString;
		DataTable prodi;

		public FormLoginRegistrasi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			DataTable tmp = new DataTable();
			cbProdiReg.Items.Clear();
			DropDownRole.selectedIndex = 1;
			MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=db_quiz;sslmode=none");
			
			//MySqlCommand cmd = new MySqlCommand(q, con);
			//tmp.Load(cmd.ExecuteReader());
			
			try
			{
				con.Open();
				string q = "CALL userGetProdi()";
				MySqlCommand cmd = new MySqlCommand(q, con);
				tmp.Load(cmd.ExecuteReader());
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally {
				con.Close();
			}
			for (int i = 0; i < tmp.Rows.Count; i++) {
				cbProdiReg.Items.Add(tmp.Rows[i][1]);
			}

			if (cbProdiReg.Items.Count > 0) {
				cbProdiReg.SelectedIndex = 0;
			}

			this.prodi = tmp;
		}

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
        }

        private void btnLoginR_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelRegistrasi.Left > 0)
            {
                panelLogin.Left -= 20;
                panelRegistrasi.Left -= 20;
                if (panelRegistrasi.Left == 0)
                {
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panelLogin.Left < 0)
            {
                panelRegistrasi.Left += 20;
                panelLogin.Left += 20;
                if (panelLogin.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }

		private void btnLogin_Click(object sender, EventArgs e)
		{

			bool login_status;

			switch (DropDownRole.selectedIndex){
				case 1:
					User userTmp = new User();
					login_status = userTmp.cekLogin(tbUsernameLogin.Text, tbPasswordLogin.Text);
					if (login_status == true)
					{
						FormMahasiswa frmMH = new FormMahasiswa(userTmp);
						//MessageBox.Show("Login berhasil");
						string nama = userTmp.Nama;
						frmMH.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Login gagal periksa kembali username dan password anda");
					}
					break;

				case 0:
					Dosen dosenTmp = new Dosen();
					login_status = dosenTmp.cekLogin(tbUsernameLogin.Text, tbPasswordLogin.Text);
					if (login_status == true)
					{
						FormDosen1 frmDosen = new FormDosen1(dosenTmp);
						this.Hide();
						frmDosen.Show();
					}
					else
					{
						MessageBox.Show("Login gagal periksa kembali username dan password anda");
					}
					break;

				default:
					break;
			}

		}

		private void tbPasswordLogin_OnValueChanged(object sender, EventArgs e)
		{
			tbPasswordLogin.isPassword = true;
		}

		private void cbSeePassword_CheckedChanged(object sender, EventArgs e)
		{
			tbPasswordLogin.isPassword = false;
		}

		private void panelRegistrasi_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnRegistrasiR_Click(object sender, EventArgs e)
		{
			User user = new User();
			bool status = user.Daftar(tbNamaReg.Text, tbNIMReg.Text, tbEmailReg.Text, tbPasswordReg.Text, prodi.Rows[cbProdiReg.SelectedIndex][0].ToString());
			if (status == true)
			{
				MessageBox.Show("Registrasi Berhasil, Login pada Form Login");
			}
			else
			{
				MessageBox.Show("Gagal");
			}
		}
	}
} 