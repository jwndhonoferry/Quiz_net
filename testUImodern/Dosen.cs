using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace testUImodern
{
	public class Dosen
	{
		// deklarasi global var koneksi
		private MySqlConnection con;

		// data filed user (Mahasiswa)
		//string userId, nama, nim, email, password, kdProdi, prodi, kdFakultas;
		public string Nidn { set; get; }
		public string Nama { set; get; }
		public string Email { set; get; }
		public string Password { set; get; }
		public string Fakultas { set; get; }
		public string KdFakultas { set; get; }

		//private string nama;
		//public string nama{set; get;}

		// constructor
		public Dosen()
		{
			setupConection();
		} 

		public void setupConection()
		{
			string credential = "host=localhost;username=root;password=;database=db_quiz;sslmode=none;";
			con = new MySqlConnection(credential);
		}

		public bool cekLogin(string username, string passwd)
		{
			bool status = false;
			MySqlDataReader tmp_data;

			string q = "CALL dosenLogin(@user, @pass)";

			con.Open();
			try
			{
				MySqlCommand cmd = new MySqlCommand(q, con);
				cmd.Parameters.AddWithValue("@user", username);
				cmd.Parameters.AddWithValue("@pass", passwd);
				tmp_data = cmd.ExecuteReader();
				if (tmp_data.Read())
				{
					Nidn = tmp_data[0].ToString();
					Nama = tmp_data[1].ToString();
					Password = passwd;
					KdFakultas = tmp_data[2].ToString();
					Email = tmp_data[3].ToString();
					Fakultas = tmp_data[6].ToString();
					status = true;
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally {
				con.Close();
			}

			return status;
		}

		public void tambahKuis(string NamaKuis, DataTable tmp)
		{
			string q1 = "CALL dosenTambahKuis(@nama, @kdDosen)";
			string q2 = "CALL dosenTambahSoal(@kdInduk, @soal, @jawaban, @opsi1, @opsi2, @opsi3, @skor)";
			string kdSoalInduk = "";

			con.Open();
			try
			{
				//MessageBox.Show("here");
				MySqlCommand cmd = new MySqlCommand(q1, con);
				cmd.Parameters.AddWithValue("@nama", NamaKuis);
				cmd.Parameters.AddWithValue("@kdDosen", this.Nidn);
				MySqlDataReader s = cmd.ExecuteReader();
				while (s.Read())
				{
					kdSoalInduk = s[0].ToString();
				}
				//MessageBox.Show(kdSoalInduk);
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}

			try
			{

				for (int i = 0; i < tmp.Rows.Count; i++)
				{
					con.Open();
					using (MySqlCommand cmd = new MySqlCommand(q2, con))
					{
						cmd.Parameters.AddWithValue("@kdInduk", kdSoalInduk);
						cmd.Parameters.AddWithValue("@soal", tmp.Rows[i][1].ToString());
						cmd.Parameters.AddWithValue("@jawaban", tmp.Rows[i][2].ToString());
						cmd.Parameters.AddWithValue("@skor", tmp.Rows[i][3].ToString());
						cmd.Parameters.AddWithValue("@opsi1", tmp.Rows[i][4].ToString());
						cmd.Parameters.AddWithValue("@opsi2", tmp.Rows[i][5].ToString());
						cmd.Parameters.AddWithValue("@opsi3", tmp.Rows[i][6].ToString());
						cmd.ExecuteNonQuery();
					}
					con.Close();
				}

			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public List<string> riwayatKuis() {
			List<string> tmp_list = new List<string>();
			string q1 = "CALL dosenRecentKuis(@kdDosen)";
			con.Open();

			try {
				MySqlCommand cmd = new MySqlCommand(q1, con);
				cmd.Parameters.AddWithValue("@kdDosen", this.Nidn);
				MySqlDataReader tmp = cmd.ExecuteReader();
				while (tmp.Read()) {
					tmp_list.Add(tmp.GetString(0) + " / " + tmp.GetString(1));
				}
			} catch (MySqlException ex) {
				MessageBox.Show(ex.Message);
			} finally {
				con.Close();
			}

			return tmp_list;
		}

		public DataTable recentKuis()
		{
			DataTable tmp = new DataTable();
			//List<string> tmp_list = new List<string>();
			string q1 = "CALL dosenRecentKuis(@kdDosen)";
			con.Open();

			try
			{
				MySqlCommand cmd = new MySqlCommand(q1, con);
				cmd.Parameters.AddWithValue("@kdDosen", this.Nidn);
				tmp.Load(cmd.ExecuteReader());
				
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}

			return tmp;
		}

		public DataTable lihatNilai(string KdKuis){
			DataTable tmp = new DataTable();
			string q1 = "CALL dosenLihatNilai(@kdKuis)";
			con.Open();

			try {
				MySqlCommand cmd = new MySqlCommand(q1, con);
				cmd.Parameters.AddWithValue("kdKuis", KdKuis);
				tmp.Load(cmd.ExecuteReader());
				tmp.Columns["nim"].ColumnName = "Nim";
				tmp.Columns["nama"].ColumnName = "Nama";
				tmp.Columns["nilai"].ColumnName = "Nilai";
				tmp.Columns["tgl_tes"].ColumnName = "Tanggal Tes";
			} catch (MySqlException ex) {
				MessageBox.Show(ex.Message);
			} finally {
				con.Close();
			}

			return tmp;
		}

		public void hapusKuis(string kd_soal) {
			string q1 = "CALL dosenHapusKuis(@KdSoal)";

			con.Open();
			try
			{
				MySqlCommand cmd = new MySqlCommand(q1, con);
				cmd.Parameters.AddWithValue("@KdSoal", kd_soal);
				cmd.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally {
				con.Close();
			}
		}




		public DataTable getFakultas(){
			DataTable tmp = new DataTable();
			con.Open();
			string q = "CALL dosenGetFakultas()";
			MySqlCommand cmd = new MySqlCommand(q, con);
			tmp.Load(cmd.ExecuteReader());
			con.Close();
			return tmp;
		}

		public void updateInfo(string nama, string kd_fak, string email, string pass, string nidn)
		{
			con.Open();

			string q = "CALL dosenUpdate(@nama, @email, @pass, @fak, @nidn)";
			try
			{
				MySqlCommand cmd = new MySqlCommand(q, con);
				cmd.Parameters.AddWithValue("@nidn", nidn);
				cmd.Parameters.AddWithValue("@nama", nama);
				cmd.Parameters.AddWithValue("@fak", kd_fak);
				cmd.Parameters.AddWithValue("@email", email);
				cmd.Parameters.AddWithValue("@pass", pass);
				cmd.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
	}
}
