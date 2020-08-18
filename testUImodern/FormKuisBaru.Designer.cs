namespace testUImodern
{
	partial class FormKuisBaru
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKuisBaru));
			this.panelUtamaFrmSoal = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panelAnswer = new System.Windows.Forms.Panel();
			this.btnBuatKuis = new System.Windows.Forms.Button();
			this.lblNamaFile = new System.Windows.Forms.Label();
			this.lblFile = new System.Windows.Forms.Label();
			this.lblJudul = new System.Windows.Forms.Label();
			this.BMtbJudulQuiz = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnBrowseFile = new System.Windows.Forms.Button();
			this.panelUtamaFrmSoal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelAnswer.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelUtamaFrmSoal
			// 
			this.panelUtamaFrmSoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panelUtamaFrmSoal.Controls.Add(this.btnExit);
			this.panelUtamaFrmSoal.Controls.Add(this.pictureBox1);
			this.panelUtamaFrmSoal.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUtamaFrmSoal.Location = new System.Drawing.Point(0, 0);
			this.panelUtamaFrmSoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelUtamaFrmSoal.Name = "panelUtamaFrmSoal";
			this.panelUtamaFrmSoal.Size = new System.Drawing.Size(720, 74);
			this.panelUtamaFrmSoal.TabIndex = 0;
			this.panelUtamaFrmSoal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUtamaFrmSoal_MouseDown);
			this.panelUtamaFrmSoal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUtamaFrmSoal_MouseMove);
			this.panelUtamaFrmSoal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUtamaFrmSoal_MouseUp);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.Location = new System.Drawing.Point(664, 12);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(44, 44);
			this.btnExit.TabIndex = 4;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(272, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(189, 62);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuDragControl2
			// 
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.panelUtamaFrmSoal;
			this.bunifuDragControl2.Vertical = true;
			// 
			// panelAnswer
			// 
			this.panelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panelAnswer.Controls.Add(this.btnBuatKuis);
			this.panelAnswer.Controls.Add(this.lblNamaFile);
			this.panelAnswer.Controls.Add(this.lblFile);
			this.panelAnswer.Controls.Add(this.lblJudul);
			this.panelAnswer.Controls.Add(this.BMtbJudulQuiz);
			this.panelAnswer.Controls.Add(this.btnBrowseFile);
			this.panelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAnswer.Location = new System.Drawing.Point(0, 74);
			this.panelAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelAnswer.Name = "panelAnswer";
			this.panelAnswer.Size = new System.Drawing.Size(720, 356);
			this.panelAnswer.TabIndex = 3;
			// 
			// btnBuatKuis
			// 
			this.btnBuatKuis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnBuatKuis.FlatAppearance.BorderSize = 0;
			this.btnBuatKuis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuatKuis.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuatKuis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuatKuis.Location = new System.Drawing.Point(278, 239);
			this.btnBuatKuis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuatKuis.Name = "btnBuatKuis";
			this.btnBuatKuis.Size = new System.Drawing.Size(163, 42);
			this.btnBuatKuis.TabIndex = 24;
			this.btnBuatKuis.Text = "Buat Kuis";
			this.btnBuatKuis.UseVisualStyleBackColor = false;
			this.btnBuatKuis.Click += new System.EventHandler(this.btnBuatKuis_Click);
			// 
			// lblNamaFile
			// 
			this.lblNamaFile.AutoSize = true;
			this.lblNamaFile.Font = new System.Drawing.Font("Decker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNamaFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblNamaFile.Location = new System.Drawing.Point(203, 160);
			this.lblNamaFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNamaFile.Name = "lblNamaFile";
			this.lblNamaFile.Size = new System.Drawing.Size(76, 18);
			this.lblNamaFile.TabIndex = 23;
			this.lblNamaFile.Text = "Nama File";
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblFile.Location = new System.Drawing.Point(79, 144);
			this.lblFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(78, 37);
			this.lblFile.TabIndex = 22;
			this.lblFile.Text = "Soal";
			// 
			// lblJudul
			// 
			this.lblJudul.AutoSize = true;
			this.lblJudul.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJudul.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblJudul.Location = new System.Drawing.Point(79, 70);
			this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblJudul.Name = "lblJudul";
			this.lblJudul.Size = new System.Drawing.Size(94, 37);
			this.lblJudul.TabIndex = 21;
			this.lblJudul.Text = "Judul";
			// 
			// BMtbJudulQuiz
			// 
			this.BMtbJudulQuiz.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.BMtbJudulQuiz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BMtbJudulQuiz.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.BMtbJudulQuiz.HintForeColor = System.Drawing.Color.Silver;
			this.BMtbJudulQuiz.HintText = "Judul Kuis";
			this.BMtbJudulQuiz.isPassword = false;
			this.BMtbJudulQuiz.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.BMtbJudulQuiz.LineIdleColor = System.Drawing.Color.Gray;
			this.BMtbJudulQuiz.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.BMtbJudulQuiz.LineThickness = 4;
			this.BMtbJudulQuiz.Location = new System.Drawing.Point(233, 60);
			this.BMtbJudulQuiz.Margin = new System.Windows.Forms.Padding(5);
			this.BMtbJudulQuiz.Name = "BMtbJudulQuiz";
			this.BMtbJudulQuiz.Size = new System.Drawing.Size(395, 50);
			this.BMtbJudulQuiz.TabIndex = 20;
			this.BMtbJudulQuiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnBrowseFile
			// 
			this.btnBrowseFile.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnBrowseFile.FlatAppearance.BorderSize = 0;
			this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseFile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowseFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBrowseFile.Location = new System.Drawing.Point(465, 143);
			this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBrowseFile.Name = "btnBrowseFile";
			this.btnBrowseFile.Size = new System.Drawing.Size(163, 42);
			this.btnBrowseFile.TabIndex = 19;
			this.btnBrowseFile.Text = "Browse File";
			this.btnBrowseFile.UseVisualStyleBackColor = false;
			this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
			// 
			// FormKuisBaru
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(720, 430);
			this.Controls.Add(this.panelAnswer);
			this.Controls.Add(this.panelUtamaFrmSoal);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormKuisBaru";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.panelUtamaFrmSoal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelAnswer.ResumeLayout(false);
			this.panelAnswer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelUtamaFrmSoal;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnExit;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
		private System.Windows.Forms.Panel panelAnswer;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.Label lblJudul;
		private Bunifu.Framework.UI.BunifuMaterialTextbox BMtbJudulQuiz;
		private System.Windows.Forms.Button btnBrowseFile;
		private System.Windows.Forms.Label lblNamaFile;
		private System.Windows.Forms.Button btnBuatKuis;
	}
}