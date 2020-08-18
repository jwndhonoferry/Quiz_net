using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUImodern
{
	public partial class HomeForm : Form
	{
		int panelWidth;
		bool Hidden;
		public HomeForm()
		{
			InitializeComponent();
			panelWidth = panelSlide.Width;
			Hidden = false;
		}

		private void btnQuestion_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Hidden)
			{
				panelSlide.Width = panelSlide.Width + 10;
				if (panelSlide.Width >= panelWidth)
				{
					timer1.Stop();
					Hidden = false;
					this.Refresh();
				}
			}
			else
			{
				panelSlide.Width = panelSlide.Width - 10;
				if (panelSlide.Width <= 0)
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

		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{

		}
	}
}
