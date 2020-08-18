namespace testUImodern
{
	partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.panelUtama = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnMakeQuiz = new System.Windows.Forms.Button();
            this.btnBrowseQuiz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelUtama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnMarks);
            this.panel1.Controls.Add(this.btnQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 488);
            this.panel1.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(10, 10);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(129, 32);
            this.bunifuTextbox1.TabIndex = 5;
            this.bunifuTextbox1.text = "Search";
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.Location = new System.Drawing.Point(2, 259);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(108, 104);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnMarks
            // 
            this.btnMarks.FlatAppearance.BorderSize = 0;
            this.btnMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarks.Image = ((System.Drawing.Image)(resources.GetObject("btnMarks.Image")));
            this.btnMarks.Location = new System.Drawing.Point(2, 151);
            this.btnMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(108, 100);
            this.btnMarks.TabIndex = 1;
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnQuestion
            // 
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestion.Image")));
            this.btnQuestion.Location = new System.Drawing.Point(2, 51);
            this.btnQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(108, 98);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // panelUtama
            // 
            this.panelUtama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelUtama.Controls.Add(this.btnMinimize);
            this.panelUtama.Controls.Add(this.btnExit);
            this.panelUtama.Controls.Add(this.pictureBox1);
            this.panelUtama.Controls.Add(this.label1);
            this.panelUtama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUtama.Location = new System.Drawing.Point(111, 0);
            this.panelUtama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(727, 50);
            this.panelUtama.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(620, 24);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 21);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(645, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(66, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "KuisKita";
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panelSlide.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelSlide.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelSlide.Controls.Add(this.bunifuDatepicker1);
            this.panelSlide.Controls.Add(this.btnMakeQuiz);
            this.panelSlide.Controls.Add(this.btnBrowseQuiz);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(111, 50);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(340, 438);
            this.panelSlide.TabIndex = 2;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.HintText = "Timer";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(20, 143);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(296, 41);
            this.bunifuMaterialTextbox2.TabIndex = 9;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintText = "Jenis Quiz";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(20, 85);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(296, 44);
            this.bunifuMaterialTextbox1.TabIndex = 8;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(20, 212);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(296, 36);
            this.bunifuDatepicker1.TabIndex = 7;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 9, 22, 9, 29, 26, 328);
            // 
            // btnMakeQuiz
            // 
            this.btnMakeQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMakeQuiz.FlatAppearance.BorderSize = 0;
            this.btnMakeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeQuiz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeQuiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeQuiz.Location = new System.Drawing.Point(20, 366);
            this.btnMakeQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeQuiz.Name = "btnMakeQuiz";
            this.btnMakeQuiz.Size = new System.Drawing.Size(296, 34);
            this.btnMakeQuiz.TabIndex = 4;
            this.btnMakeQuiz.Text = "Make Quiz";
            this.btnMakeQuiz.UseVisualStyleBackColor = false;
            // 
            // btnBrowseQuiz
            // 
            this.btnBrowseQuiz.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBrowseQuiz.FlatAppearance.BorderSize = 0;
            this.btnBrowseQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseQuiz.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseQuiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowseQuiz.Location = new System.Drawing.Point(20, 294);
            this.btnBrowseQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseQuiz.Name = "btnBrowseQuiz";
            this.btnBrowseQuiz.Size = new System.Drawing.Size(122, 34);
            this.btnBrowseQuiz.TabIndex = 3;
            this.btnBrowseQuiz.Text = "Browse Quiz";
            this.btnBrowseQuiz.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelUtama;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 104);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panelUtama.ResumeLayout(false);
            this.panelUtama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAccount;
		private System.Windows.Forms.Button btnMarks;
		private System.Windows.Forms.Button btnQuestion;
		private System.Windows.Forms.Panel panelUtama;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelSlide;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMakeQuiz;
		private System.Windows.Forms.Button btnBrowseQuiz;
		private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
		private System.Windows.Forms.Button btnMinimize;
		private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
		private System.Windows.Forms.Timer timer2;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
		private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button1;
    }
}

