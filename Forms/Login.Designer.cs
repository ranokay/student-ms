namespace StudentMS.Forms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.LoginTabControl = new System.Windows.Forms.TabControl();
			this.SignInPage = new System.Windows.Forms.TabPage();
			this.ErrorMsgSignIn = new System.Windows.Forms.Label();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.PasswordIcon = new System.Windows.Forms.PictureBox();
			this.UserIcon = new System.Windows.Forms.PictureBox();
			this.SignInLabel = new System.Windows.Forms.Label();
			this.SignInPassword = new System.Windows.Forms.TextBox();
			this.SignInUsername = new System.Windows.Forms.TextBox();
			this.SignUpPage = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SignUpName = new System.Windows.Forms.TextBox();
			this.ConfirmPassIco = new System.Windows.Forms.PictureBox();
			this.SignUpConfirmPassword = new System.Windows.Forms.TextBox();
			this.ErrorMsgSignUp = new System.Windows.Forms.Label();
			this.SignUpBtn = new System.Windows.Forms.Button();
			this.PasswordIco = new System.Windows.Forms.PictureBox();
			this.UserIco = new System.Windows.Forms.PictureBox();
			this.SignUpLabel = new System.Windows.Forms.Label();
			this.SignUpPassword = new System.Windows.Forms.TextBox();
			this.SignUpUsername = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.LogoImage = new System.Windows.Forms.PictureBox();
			this.LoginTitle = new System.Windows.Forms.Label();
			this.SignInBtnRedir = new System.Windows.Forms.Button();
			this.SignUpBtnRedir = new System.Windows.Forms.Button();
			this.LoginTabControl.SuspendLayout();
			this.SignInPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
			this.SignUpPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ConfirmPassIco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserIco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginTabControl
			// 
			this.LoginTabControl.Controls.Add(this.SignInPage);
			this.LoginTabControl.Controls.Add(this.SignUpPage);
			this.LoginTabControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.LoginTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.LoginTabControl.ItemSize = new System.Drawing.Size(0, 1);
			this.LoginTabControl.Location = new System.Drawing.Point(968, 0);
			this.LoginTabControl.Name = "LoginTabControl";
			this.LoginTabControl.Padding = new System.Drawing.Point(0, 1);
			this.LoginTabControl.SelectedIndex = 0;
			this.LoginTabControl.Size = new System.Drawing.Size(1000, 1312);
			this.LoginTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.LoginTabControl.TabIndex = 0;
			// 
			// SignInPage
			// 
			this.SignInPage.BackColor = System.Drawing.Color.AliceBlue;
			this.SignInPage.Controls.Add(this.ErrorMsgSignIn);
			this.SignInPage.Controls.Add(this.LoginBtn);
			this.SignInPage.Controls.Add(this.PasswordIcon);
			this.SignInPage.Controls.Add(this.UserIcon);
			this.SignInPage.Controls.Add(this.SignInLabel);
			this.SignInPage.Controls.Add(this.SignInPassword);
			this.SignInPage.Controls.Add(this.SignInUsername);
			this.SignInPage.Location = new System.Drawing.Point(4, 5);
			this.SignInPage.Name = "SignInPage";
			this.SignInPage.Padding = new System.Windows.Forms.Padding(3);
			this.SignInPage.Size = new System.Drawing.Size(992, 1303);
			this.SignInPage.TabIndex = 1;
			// 
			// ErrorMsgSignIn
			// 
			this.ErrorMsgSignIn.AutoSize = true;
			this.ErrorMsgSignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ErrorMsgSignIn.ForeColor = System.Drawing.Color.Red;
			this.ErrorMsgSignIn.Location = new System.Drawing.Point(218, 598);
			this.ErrorMsgSignIn.Name = "ErrorMsgSignIn";
			this.ErrorMsgSignIn.Size = new System.Drawing.Size(0, 41);
			this.ErrorMsgSignIn.TabIndex = 2;
			// 
			// LoginBtn
			// 
			this.LoginBtn.BackColor = System.Drawing.Color.LightSkyBlue;
			this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LoginBtn.Location = new System.Drawing.Point(218, 677);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(330, 90);
			this.LoginBtn.TabIndex = 9;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// PasswordIcon
			// 
			this.PasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("PasswordIcon.Image")));
			this.PasswordIcon.Location = new System.Drawing.Point(172, 530);
			this.PasswordIcon.Name = "PasswordIcon";
			this.PasswordIcon.Size = new System.Drawing.Size(40, 40);
			this.PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PasswordIcon.TabIndex = 4;
			this.PasswordIcon.TabStop = false;
			// 
			// UserIcon
			// 
			this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
			this.UserIcon.Location = new System.Drawing.Point(172, 410);
			this.UserIcon.Name = "UserIcon";
			this.UserIcon.Size = new System.Drawing.Size(40, 40);
			this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.UserIcon.TabIndex = 5;
			this.UserIcon.TabStop = false;
			// 
			// SignInLabel
			// 
			this.SignInLabel.AutoSize = true;
			this.SignInLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SignInLabel.Location = new System.Drawing.Point(320, 200);
			this.SignInLabel.Name = "SignInLabel";
			this.SignInLabel.Size = new System.Drawing.Size(206, 72);
			this.SignInLabel.TabIndex = 6;
			this.SignInLabel.Text = "Sign In";
			// 
			// SignInPassword
			// 
			this.SignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignInPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignInPassword.Location = new System.Drawing.Point(218, 520);
			this.SignInPassword.Name = "SignInPassword";
			this.SignInPassword.PlaceholderText = "Enter password";
			this.SignInPassword.Size = new System.Drawing.Size(480, 61);
			this.SignInPassword.TabIndex = 8;
			this.SignInPassword.UseSystemPasswordChar = true;
			this.SignInPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// SignInUsername
			// 
			this.SignInUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignInUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignInUsername.Location = new System.Drawing.Point(218, 400);
			this.SignInUsername.Name = "SignInUsername";
			this.SignInUsername.PlaceholderText = "Enter username or email";
			this.SignInUsername.Size = new System.Drawing.Size(480, 61);
			this.SignInUsername.TabIndex = 7;
			this.SignInUsername.Tag = "";
			this.SignInUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// SignUpPage
			// 
			this.SignUpPage.BackColor = System.Drawing.Color.AliceBlue;
			this.SignUpPage.Controls.Add(this.pictureBox1);
			this.SignUpPage.Controls.Add(this.SignUpName);
			this.SignUpPage.Controls.Add(this.ConfirmPassIco);
			this.SignUpPage.Controls.Add(this.SignUpConfirmPassword);
			this.SignUpPage.Controls.Add(this.ErrorMsgSignUp);
			this.SignUpPage.Controls.Add(this.SignUpBtn);
			this.SignUpPage.Controls.Add(this.PasswordIco);
			this.SignUpPage.Controls.Add(this.UserIco);
			this.SignUpPage.Controls.Add(this.SignUpLabel);
			this.SignUpPage.Controls.Add(this.SignUpPassword);
			this.SignUpPage.Controls.Add(this.SignUpUsername);
			this.SignUpPage.Location = new System.Drawing.Point(4, 5);
			this.SignUpPage.Name = "SignUpPage";
			this.SignUpPage.Padding = new System.Windows.Forms.Padding(3);
			this.SignUpPage.Size = new System.Drawing.Size(992, 1303);
			this.SignUpPage.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(160, 400);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 61);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// SignUpName
			// 
			this.SignUpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignUpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpName.Location = new System.Drawing.Point(218, 400);
			this.SignUpName.Name = "SignUpName";
			this.SignUpName.PlaceholderText = "Enter name";
			this.SignUpName.Size = new System.Drawing.Size(480, 61);
			this.SignUpName.TabIndex = 13;
			this.SignUpName.Tag = "";
			this.SignUpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// ConfirmPassIco
			// 
			this.ConfirmPassIco.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmPassIco.Image")));
			this.ConfirmPassIco.Location = new System.Drawing.Point(160, 759);
			this.ConfirmPassIco.Name = "ConfirmPassIco";
			this.ConfirmPassIco.Size = new System.Drawing.Size(52, 61);
			this.ConfirmPassIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ConfirmPassIco.TabIndex = 10;
			this.ConfirmPassIco.TabStop = false;
			// 
			// SignUpConfirmPassword
			// 
			this.SignUpConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignUpConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpConfirmPassword.Location = new System.Drawing.Point(218, 759);
			this.SignUpConfirmPassword.Name = "SignUpConfirmPassword";
			this.SignUpConfirmPassword.PlaceholderText = "Confirm password";
			this.SignUpConfirmPassword.Size = new System.Drawing.Size(480, 61);
			this.SignUpConfirmPassword.TabIndex = 18;
			this.SignUpConfirmPassword.UseSystemPasswordChar = true;
			this.SignUpConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// ErrorMsgSignUp
			// 
			this.ErrorMsgSignUp.AutoSize = true;
			this.ErrorMsgSignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ErrorMsgSignUp.ForeColor = System.Drawing.Color.Red;
			this.ErrorMsgSignUp.Location = new System.Drawing.Point(218, 841);
			this.ErrorMsgSignUp.Name = "ErrorMsgSignUp";
			this.ErrorMsgSignUp.Size = new System.Drawing.Size(0, 41);
			this.ErrorMsgSignUp.TabIndex = 12;
			// 
			// SignUpBtn
			// 
			this.SignUpBtn.BackColor = System.Drawing.Color.LightSkyBlue;
			this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SignUpBtn.Location = new System.Drawing.Point(218, 911);
			this.SignUpBtn.Name = "SignUpBtn";
			this.SignUpBtn.Size = new System.Drawing.Size(330, 90);
			this.SignUpBtn.TabIndex = 11;
			this.SignUpBtn.Text = "Sign Up";
			this.SignUpBtn.UseVisualStyleBackColor = false;
			this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
			// 
			// PasswordIco
			// 
			this.PasswordIco.Image = ((System.Drawing.Image)(resources.GetObject("PasswordIco.Image")));
			this.PasswordIco.Location = new System.Drawing.Point(172, 647);
			this.PasswordIco.Name = "PasswordIco";
			this.PasswordIco.Size = new System.Drawing.Size(40, 40);
			this.PasswordIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PasswordIco.TabIndex = 14;
			this.PasswordIco.TabStop = false;
			// 
			// UserIco
			// 
			this.UserIco.Image = ((System.Drawing.Image)(resources.GetObject("UserIco.Image")));
			this.UserIco.Location = new System.Drawing.Point(172, 526);
			this.UserIco.Name = "UserIco";
			this.UserIco.Size = new System.Drawing.Size(40, 40);
			this.UserIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.UserIco.TabIndex = 15;
			this.UserIco.TabStop = false;
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.AutoSize = true;
			this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SignUpLabel.Location = new System.Drawing.Point(320, 200);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(228, 72);
			this.SignUpLabel.TabIndex = 24;
			this.SignUpLabel.Text = "Sign Up";
			// 
			// SignUpPassword
			// 
			this.SignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignUpPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpPassword.Location = new System.Drawing.Point(218, 636);
			this.SignUpPassword.Name = "SignUpPassword";
			this.SignUpPassword.PlaceholderText = "Enter password";
			this.SignUpPassword.Size = new System.Drawing.Size(480, 61);
			this.SignUpPassword.TabIndex = 17;
			this.SignUpPassword.UseSystemPasswordChar = true;
			this.SignUpPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// SignUpUsername
			// 
			this.SignUpUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SignUpUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpUsername.Location = new System.Drawing.Point(218, 516);
			this.SignUpUsername.Name = "SignUpUsername";
			this.SignUpUsername.PlaceholderText = "Enter username or email";
			this.SignUpUsername.Size = new System.Drawing.Size(480, 61);
			this.SignUpUsername.TabIndex = 16;
			this.SignUpUsername.Tag = "";
			this.SignUpUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// LogoImage
			// 
			this.LogoImage.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage.Image")));
			this.LogoImage.Location = new System.Drawing.Point(265, 89);
			this.LogoImage.Name = "LogoImage";
			this.LogoImage.Size = new System.Drawing.Size(370, 337);
			this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.LogoImage.TabIndex = 19;
			this.LogoImage.TabStop = false;
			// 
			// LoginTitle
			// 
			this.LoginTitle.AutoSize = true;
			this.LoginTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LoginTitle.Location = new System.Drawing.Point(184, 458);
			this.LoginTitle.Name = "LoginTitle";
			this.LoginTitle.Size = new System.Drawing.Size(563, 144);
			this.LoginTitle.TabIndex = 20;
			this.LoginTitle.Text = "Students \r\nManagement System";
			this.LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SignInBtnRedir
			// 
			this.SignInBtnRedir.BackColor = System.Drawing.Color.LightSkyBlue;
			this.SignInBtnRedir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignInBtnRedir.FlatAppearance.BorderSize = 0;
			this.SignInBtnRedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignInBtnRedir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SignInBtnRedir.Location = new System.Drawing.Point(298, 735);
			this.SignInBtnRedir.Name = "SignInBtnRedir";
			this.SignInBtnRedir.Size = new System.Drawing.Size(310, 90);
			this.SignInBtnRedir.TabIndex = 21;
			this.SignInBtnRedir.Text = "Login";
			this.SignInBtnRedir.UseVisualStyleBackColor = false;
			this.SignInBtnRedir.Click += new System.EventHandler(this.SignInBtnRedir_Click);
			// 
			// SignUpBtnRedir
			// 
			this.SignUpBtnRedir.BackColor = System.Drawing.Color.White;
			this.SignUpBtnRedir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignUpBtnRedir.FlatAppearance.BorderSize = 0;
			this.SignUpBtnRedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpBtnRedir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SignUpBtnRedir.Location = new System.Drawing.Point(298, 870);
			this.SignUpBtnRedir.Name = "SignUpBtnRedir";
			this.SignUpBtnRedir.Size = new System.Drawing.Size(310, 90);
			this.SignUpBtnRedir.TabIndex = 22;
			this.SignUpBtnRedir.Text = "Sign Up";
			this.SignUpBtnRedir.UseVisualStyleBackColor = false;
			this.SignUpBtnRedir.Click += new System.EventHandler(this.SignUpBtnRedir_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(1968, 1312);
			this.Controls.Add(this.SignUpBtnRedir);
			this.Controls.Add(this.SignInBtnRedir);
			this.Controls.Add(this.LoginTitle);
			this.Controls.Add(this.LogoImage);
			this.Controls.Add(this.LoginTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.LoginTabControl.ResumeLayout(false);
			this.SignInPage.ResumeLayout(false);
			this.SignInPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
			this.SignUpPage.ResumeLayout(false);
			this.SignUpPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ConfirmPassIco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordIco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserIco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TabControl LoginTabControl;
		private TabPage SignInPage;
		private TabPage SignUpPage;
		public TextBox SignInPassword;
		public TextBox SignInUsername;
		private Label SignInLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private PictureBox UserIcon;
		private PictureBox PasswordIcon;
		private PictureBox LogoImage;
		private Label LoginTitle;
		private Button SignInBtnRedir;
		private Button SignUpBtnRedir;
		private Button LoginBtn;
		private Button SignUpBtn;
		private PictureBox PasswordIco;
		private PictureBox UserIco;
		private Label SignUpLabel;
		private TextBox SignUpPassword;
		private TextBox SignUpUsername;
		public Label ErrorMsgSignIn;
		private Label ErrorMsgSignUp;
		private PictureBox ConfirmPassIco;
		private TextBox SignUpConfirmPassword;
		private PictureBox pictureBox1;
		private TextBox SignUpName;
	}
}