namespace QuizLogin
{
    partial class FormLoginRegistrasi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginRegistrasi));
			this.panelLogin = new System.Windows.Forms.Panel();
			this.DropDownRole = new Bunifu.Framework.UI.BunifuDropdown();
			this.cbSeePassword = new System.Windows.Forms.CheckBox();
			this.tbUsernameLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.tbPasswordLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnRegistrasi = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panelRegistrasi = new System.Windows.Forms.Panel();
			this.cbProdiReg = new System.Windows.Forms.ComboBox();
			this.tbEmailReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.tbPasswordReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.tbNIMReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.tbNamaReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.btnLoginR = new System.Windows.Forms.Button();
			this.btnRegistrasiR = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.panelLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelRegistrasi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLogin
			// 
			this.panelLogin.Controls.Add(this.DropDownRole);
			this.panelLogin.Controls.Add(this.cbSeePassword);
			this.panelLogin.Controls.Add(this.tbUsernameLogin);
			this.panelLogin.Controls.Add(this.tbPasswordLogin);
			this.panelLogin.Controls.Add(this.pictureBox3);
			this.panelLogin.Controls.Add(this.pictureBox2);
			this.panelLogin.Controls.Add(this.btnRegistrasi);
			this.panelLogin.Controls.Add(this.btnLogin);
			this.panelLogin.Location = new System.Drawing.Point(1, 191);
			this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(427, 523);
			this.panelLogin.TabIndex = 0;
			// 
			// DropDownRole
			// 
			this.DropDownRole.BackColor = System.Drawing.Color.Transparent;
			this.DropDownRole.BorderRadius = 3;
			this.DropDownRole.DisabledColor = System.Drawing.Color.Gray;
			this.DropDownRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DropDownRole.ForeColor = System.Drawing.Color.Gainsboro;
			this.DropDownRole.Items = new string[] {
        "Dosen",
        "Mahasiswa"};
			this.DropDownRole.Location = new System.Drawing.Point(73, 250);
			this.DropDownRole.Margin = new System.Windows.Forms.Padding(4);
			this.DropDownRole.Name = "DropDownRole";
			this.DropDownRole.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.DropDownRole.onHoverColor = System.Drawing.SystemColors.MenuHighlight;
			this.DropDownRole.selectedIndex = -1;
			this.DropDownRole.Size = new System.Drawing.Size(267, 43);
			this.DropDownRole.TabIndex = 14;
			// 
			// cbSeePassword
			// 
			this.cbSeePassword.AutoSize = true;
			this.cbSeePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSeePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.cbSeePassword.Location = new System.Drawing.Point(134, 198);
			this.cbSeePassword.Name = "cbSeePassword";
			this.cbSeePassword.Size = new System.Drawing.Size(145, 24);
			this.cbSeePassword.TabIndex = 12;
			this.cbSeePassword.Text = "Show Password";
			this.cbSeePassword.UseVisualStyleBackColor = true;
			this.cbSeePassword.CheckedChanged += new System.EventHandler(this.cbSeePassword_CheckedChanged);
			// 
			// tbUsernameLogin
			// 
			this.tbUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsernameLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbUsernameLogin.HintForeColor = System.Drawing.Color.Silver;
			this.tbUsernameLogin.HintText = "Email";
			this.tbUsernameLogin.isPassword = false;
			this.tbUsernameLogin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbUsernameLogin.LineIdleColor = System.Drawing.Color.Gray;
			this.tbUsernameLogin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbUsernameLogin.LineThickness = 4;
			this.tbUsernameLogin.Location = new System.Drawing.Point(79, 47);
			this.tbUsernameLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbUsernameLogin.Name = "tbUsernameLogin";
			this.tbUsernameLogin.Size = new System.Drawing.Size(261, 59);
			this.tbUsernameLogin.TabIndex = 11;
			this.tbUsernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// tbPasswordLogin
			// 
			this.tbPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPasswordLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbPasswordLogin.HintForeColor = System.Drawing.Color.Silver;
			this.tbPasswordLogin.HintText = "Password";
			this.tbPasswordLogin.isPassword = true;
			this.tbPasswordLogin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbPasswordLogin.LineIdleColor = System.Drawing.Color.Gray;
			this.tbPasswordLogin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbPasswordLogin.LineThickness = 4;
			this.tbPasswordLogin.Location = new System.Drawing.Point(79, 131);
			this.tbPasswordLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbPasswordLogin.Name = "tbPasswordLogin";
			this.tbPasswordLogin.Size = new System.Drawing.Size(261, 59);
			this.tbPasswordLogin.TabIndex = 10;
			this.tbPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbPasswordLogin.OnValueChanged += new System.EventHandler(this.tbPasswordLogin_OnValueChanged);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(23, 131);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(46, 44);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(23, 53);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(46, 43);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// btnRegistrasi
			// 
			this.btnRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrasi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrasi.ForeColor = System.Drawing.Color.White;
			this.btnRegistrasi.Location = new System.Drawing.Point(73, 423);
			this.btnRegistrasi.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrasi.Name = "btnRegistrasi";
			this.btnRegistrasi.Size = new System.Drawing.Size(267, 48);
			this.btnRegistrasi.TabIndex = 5;
			this.btnRegistrasi.Text = "Registrasi";
			this.btnRegistrasi.UseVisualStyleBackColor = true;
			this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnLogin.Location = new System.Drawing.Point(73, 336);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(267, 48);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// panelRegistrasi
			// 
			this.panelRegistrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
			this.panelRegistrasi.Controls.Add(this.cbProdiReg);
			this.panelRegistrasi.Controls.Add(this.tbEmailReg);
			this.panelRegistrasi.Controls.Add(this.tbPasswordReg);
			this.panelRegistrasi.Controls.Add(this.tbNIMReg);
			this.panelRegistrasi.Controls.Add(this.tbNamaReg);
			this.panelRegistrasi.Controls.Add(this.btnLoginR);
			this.panelRegistrasi.Controls.Add(this.btnRegistrasiR);
			this.panelRegistrasi.Location = new System.Drawing.Point(436, 191);
			this.panelRegistrasi.Margin = new System.Windows.Forms.Padding(4);
			this.panelRegistrasi.Name = "panelRegistrasi";
			this.panelRegistrasi.Size = new System.Drawing.Size(427, 523);
			this.panelRegistrasi.TabIndex = 1;
			this.panelRegistrasi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegistrasi_Paint);
			// 
			// cbProdiReg
			// 
			this.cbProdiReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.cbProdiReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProdiReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbProdiReg.Font = new System.Drawing.Font("Decker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProdiReg.FormattingEnabled = true;
			this.cbProdiReg.Location = new System.Drawing.Point(76, 308);
			this.cbProdiReg.Name = "cbProdiReg";
			this.cbProdiReg.Size = new System.Drawing.Size(261, 35);
			this.cbProdiReg.TabIndex = 20;
			// 
			// tbEmailReg
			// 
			this.tbEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbEmailReg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEmailReg.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbEmailReg.HintForeColor = System.Drawing.Color.Silver;
			this.tbEmailReg.HintText = "Email";
			this.tbEmailReg.isPassword = false;
			this.tbEmailReg.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbEmailReg.LineIdleColor = System.Drawing.Color.Gray;
			this.tbEmailReg.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbEmailReg.LineThickness = 4;
			this.tbEmailReg.Location = new System.Drawing.Point(76, 221);
			this.tbEmailReg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbEmailReg.Name = "tbEmailReg";
			this.tbEmailReg.Size = new System.Drawing.Size(261, 49);
			this.tbEmailReg.TabIndex = 19;
			this.tbEmailReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// tbPasswordReg
			// 
			this.tbPasswordReg.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPasswordReg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPasswordReg.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbPasswordReg.HintForeColor = System.Drawing.Color.Silver;
			this.tbPasswordReg.HintText = "Password";
			this.tbPasswordReg.isPassword = false;
			this.tbPasswordReg.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbPasswordReg.LineIdleColor = System.Drawing.Color.Gray;
			this.tbPasswordReg.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbPasswordReg.LineThickness = 4;
			this.tbPasswordReg.Location = new System.Drawing.Point(76, 153);
			this.tbPasswordReg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbPasswordReg.Name = "tbPasswordReg";
			this.tbPasswordReg.Size = new System.Drawing.Size(261, 49);
			this.tbPasswordReg.TabIndex = 18;
			this.tbPasswordReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// tbNIMReg
			// 
			this.tbNIMReg.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNIMReg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNIMReg.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbNIMReg.HintForeColor = System.Drawing.Color.Silver;
			this.tbNIMReg.HintText = "NIM";
			this.tbNIMReg.isPassword = false;
			this.tbNIMReg.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbNIMReg.LineIdleColor = System.Drawing.Color.Gray;
			this.tbNIMReg.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbNIMReg.LineThickness = 4;
			this.tbNIMReg.Location = new System.Drawing.Point(76, 82);
			this.tbNIMReg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbNIMReg.Name = "tbNIMReg";
			this.tbNIMReg.Size = new System.Drawing.Size(261, 49);
			this.tbNIMReg.TabIndex = 16;
			this.tbNIMReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// tbNamaReg
			// 
			this.tbNamaReg.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNamaReg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNamaReg.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.tbNamaReg.HintForeColor = System.Drawing.Color.Silver;
			this.tbNamaReg.HintText = "Nama";
			this.tbNamaReg.isPassword = false;
			this.tbNamaReg.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbNamaReg.LineIdleColor = System.Drawing.Color.Gray;
			this.tbNamaReg.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tbNamaReg.LineThickness = 4;
			this.tbNamaReg.Location = new System.Drawing.Point(76, 23);
			this.tbNamaReg.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.tbNamaReg.Name = "tbNamaReg";
			this.tbNamaReg.Size = new System.Drawing.Size(261, 49);
			this.tbNamaReg.TabIndex = 15;
			this.tbNamaReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnLoginR
			// 
			this.btnLoginR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoginR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoginR.ForeColor = System.Drawing.Color.White;
			this.btnLoginR.Location = new System.Drawing.Point(76, 443);
			this.btnLoginR.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoginR.Name = "btnLoginR";
			this.btnLoginR.Size = new System.Drawing.Size(267, 48);
			this.btnLoginR.TabIndex = 12;
			this.btnLoginR.Text = "Login";
			this.btnLoginR.UseVisualStyleBackColor = true;
			this.btnLoginR.Click += new System.EventHandler(this.btnLoginR_Click);
			// 
			// btnRegistrasiR
			// 
			this.btnRegistrasiR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnRegistrasiR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrasiR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrasiR.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnRegistrasiR.Location = new System.Drawing.Point(76, 383);
			this.btnRegistrasiR.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrasiR.Name = "btnRegistrasiR";
			this.btnRegistrasiR.Size = new System.Drawing.Size(267, 48);
			this.btnRegistrasiR.TabIndex = 11;
			this.btnRegistrasiR.Text = "Registrasi";
			this.btnRegistrasiR.UseVisualStyleBackColor = false;
			this.btnRegistrasiR.Click += new System.EventHandler(this.btnRegistrasiR_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(411, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 10;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// FormLoginRegistrasi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(429, 718);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelLogin);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelRegistrasi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormLoginRegistrasi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "6";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelRegistrasi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelRegistrasi;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginR;
        private System.Windows.Forms.Button btnRegistrasiR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbPasswordLogin;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsernameLogin;
		private System.Windows.Forms.CheckBox cbSeePassword;
		private Bunifu.Framework.UI.BunifuDropdown DropDownRole;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmailReg;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbPasswordReg;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbNIMReg;
		private Bunifu.Framework.UI.BunifuMaterialTextbox tbNamaReg;
		private System.Windows.Forms.ComboBox cbProdiReg;
	}
}

