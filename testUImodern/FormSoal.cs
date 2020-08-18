using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace testUImodern
{
	public partial class FormSoal : Form
	{
		DataTable soal;
		User user;
		string[,] opsi;
		Color bg, noSoal;
		int[] jawaban_user;
		int no_soal;
		List<Button> buttonSoal = new List<Button>();

		public FormSoal()
		{
			InitializeComponent();
		}
		public FormSoal(User user, DataTable tmp) {
			InitializeComponent();

			Random rnd = new Random();
			this.user = user;
			this.soal = tmp;
			this.opsi = new string[soal.Rows.Count, 4];
			jawaban_user = new int[soal.Rows.Count];

			//MessageBox.Show("soal = " + soal.Rows.Count.ToString());
			//MessageBox.Show("tmp = " + tmp.Rows.Count.ToString());
			//MessageBox.Show("opsi = " + opsi.GetLength(0).ToString());
			//MessageBox.Show("jawaban user = " + jawaban_user.Length.ToString());
			for (int i = 0; i < soal.Rows.Count; i++)
			{
				isiOpsi(i, rnd.Next(0, 4));

				Button btn = new Button();
				btn.Name = "button" + i.ToString();
				btn.Text = (1 + i).ToString();
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderSize = 0;
				btn.ForeColor = Color.White;
				btn.Width = 52;
				btn.Height = 37;
				btn.Click += new EventHandler(noSoal_Click);
				buttonSoal.Add(btn);
				PanelNumber.Controls.Add(btn);
				noSoal = btn.BackColor;
			}
		}

		int mouseX = 0, mouseY = 0;
		bool mouseDown;

		private void isiOpsi(int row, int index) {
			this.opsi[row, index] = soal.Rows[row][3].ToString();

			int indexOpsi = 4;
			for (int i = 0; i < 4; i++) {
				//MessageBox.Show(opsi.GetLength(0).ToString());
				if (opsi[row, i] is null) {
					opsi[row, i] = soal.Rows[row][indexOpsi].ToString();
					indexOpsi += 1;
				}
			}
		}

		private void addButton() {
			for (int i = 0; i < buttonSoal.Count; i++) {
				PanelNumber.Controls.Add((Button)buttonSoal[i]);
			}
		}

		private void noSoal_Click(object sender, EventArgs e) {
			Clear();

			Button btn = (Button)sender;
			this.no_soal = Convert.ToInt32(btn.Text.ToString()) - 1;
			lblSoal.Text = soal.Rows[no_soal][2].ToString();

			ClearNoSoal(no_soal);
			addButton();

			btnOpsiA.Text = "A. " + opsi[no_soal, 0].ToString();
			btnOpsiB.Text = "B. " + opsi[no_soal, 1].ToString();
			btnOpsiC.Text = "C. " + opsi[no_soal, 2].ToString();
			btnOpsiD.Text = "D. " + opsi[no_soal, 3].ToString();
			//MessageBox.Show(jawaban_user[no_soal].ToString());
			switch (jawaban_user[no_soal]) {
				case 0:
					Clear();
					break;
				case 1:
					//MessageBox.Show("masuk sini");
					//btnOpsiA.IdleFillColor = Color.DarkGreen;
					btnOpsiA.BackColor = Color.DarkGreen;
					break;
				case 2:
					btnOpsiB.BackColor = Color.DarkGreen;
					break;
				case 3:
					btnOpsiC.BackColor = Color.DarkGreen;
					break;
				case 4:
					btnOpsiD.BackColor = Color.DarkGreen;
					break;
			}
		}

		private void Opsi_Click(object sender, EventArgs e) {
			Button btn = (Button)sender;
			Clear();
			btn.BackColor = Color.DarkGreen;
			switch (btn.Name.Substring(btn.Name.Length - 1)) {
				case "A":
					this.jawaban_user[no_soal] = 1;
					break;
				case "B":
					this.jawaban_user[no_soal] = 2;
					break;
				case "C":
					this.jawaban_user[no_soal] = 3;
					break;
				case "D":
					this.jawaban_user[no_soal] = 4;
					break;
			}
		}

		private void Clear() {
			btnOpsiA.BackColor = bg;
			btnOpsiB.BackColor = bg;
			btnOpsiC.BackColor = bg;
			btnOpsiD.BackColor = bg;
		}

		private void ClearNoSoal(int index) {
			PanelNumber.Controls.Clear();
			for (int i = 0; i < buttonSoal.Count; i++) {
				if (i == index)
				{
					buttonSoal[i].BackColor = Color.FromArgb(0, 122, 204);
				}
				else {
					buttonSoal[i].BackColor = noSoal;
				}
			}
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

		private void btnSelesai_Click(object sender, EventArgs e)
		{
			int nilai = 0;
			string message = "Are you sure to submit your answer?";
			string caption = "Confirmation";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
			result = MessageBox.Show(message, caption, buttons);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				//MessageBox.Show(soal.Rows.Count.ToString());
				//MessageBox.Show(jawaban_user.Length.ToString());
				//MessageBox.Show(opsi.GetLength(0).ToString());
				for (int i = 0; i < jawaban_user.Length; i++) {
					if (jawaban_user[i] - 1 == -1) {
						nilai += 0;
					} else if(soal.Rows[i][3].ToString().Equals(opsi[i, jawaban_user[i]-1])) {
						nilai += Convert.ToInt32(soal.Rows[i][7]);
					}
				}

				user.tambahRiwayat(nilai);
				MessageBox.Show("Quiz has been finished :)))");
				this.Close();
				//MessageBox.Show(nilai.ToString());
			}
		}

		private void FormSoal_Load(object sender, EventArgs e)
		{
			HookStart();
			bg = btnOpsiA.BackColor;
			lblSoal.Text = soal.Rows[0][2].ToString();
			btnOpsiA.Text = opsi[0,0];
			btnOpsiB.Text = opsi[0, 1];
			btnOpsiC.Text = opsi[0, 2];
			btnOpsiD.Text = opsi[0, 3];
			buttonSoal[0].BackColor = Color.FromArgb(0, 122, 204);
			//KeyboardHook(this, e);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

        // Keyboard Non Activate, user cant escape the quiz
        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int WM_SYSKEYDOWN = 0x0104;
        public const int WM_SYSKEYUP = 0x0105;
        public const int VK_TAB = 0x9;
        public const int VK_MENU = 0x12; /* Alt key */
        public const int VK_ESCAPE = 0x1B;
        public const int VK_F4 = 0x73;
        public const int VK_LWIN = 0x5B;
        public const int VK_RWIN = 0x5C;
        public const int VK_CONTROL = 0x11;
        public const int VK_LCONTROL = 0xA2;
        public const int VK_RCONTROL = 0xA3;
        [StructLayout(LayoutKind.Sequential)]
        public class KeyBoardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        static int hKeyboardHook = 0;
        HookProc KeyboardHookProcedure;

        public void HookStart()
        {
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    IntPtr hModule = GetModuleHandle(curModule.ModuleName);
                    hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, hModule, 0);
                }
                if (hKeyboardHook == 0)
                {
                    int error = Marshal.GetLastWin32Error();
                    HookStop();
                    throw new Exception("SetWindowsHookEx() function failed. " + "Error code: " + error.ToString());
                }
            }
        }

		private void FormSoal_FormClosing(object sender, FormClosingEventArgs e)
		{
			HookStop();
		}

		public void HookStop()
        {
            bool retKeyboard = true;
            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }
            if (!(retKeyboard))
            {
                throw new Exception("UnhookWindowsHookEx failed.");
            }
        }

        private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
            bool bMaskKeysFlag = false;
            switch (wParam)
            {
                case WM_KEYDOWN:
                case WM_KEYUP:
                case WM_SYSKEYDOWN:
                case WM_SYSKEYUP:
                    bMaskKeysFlag = ((kbh.vkCode == VK_TAB) && (kbh.flags == 32))      /* Tab + Alt */
                                    | ((kbh.vkCode == VK_ESCAPE) && (kbh.flags == 32))   /* Esc + Alt */
                                    | ((kbh.vkCode == VK_F4) && (kbh.flags == 32))       /* F4 + Alt */
                                    | ((kbh.vkCode == VK_LWIN) && (kbh.flags == 1))    /* Left Win */
                                    | ((kbh.vkCode == VK_RWIN) && (kbh.flags == 1))    /* Right Win */
                                    | ((kbh.vkCode == VK_ESCAPE) && (kbh.flags == 0)); /* Ctrl + Esc */
                    break;
                default:
                    break;
            }

            if (bMaskKeysFlag == true)
            {
                return 1;
            }
            else
            {
                return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
            }
        }
	}
}
