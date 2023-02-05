namespace StudentMS.Forms
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ConfirmDeletionPanel = new System.Windows.Forms.Panel();
			this.CancelDeletionBtn = new System.Windows.Forms.Button();
			this.ConfirmDeletionErrorMsg = new System.Windows.Forms.Label();
			this.ConfirmDeletionPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ConfirmDeletionBtn = new System.Windows.Forms.Button();
			this.EditTeacherPanel = new System.Windows.Forms.Panel();
			this.DeleteProfileBtn = new System.Windows.Forms.Button();
			this.CancelUpdateBtn = new System.Windows.Forms.Button();
			this.ErrorMsgUpdateTeacher = new System.Windows.Forms.Label();
			this.SaveNewTeacherBtn = new System.Windows.Forms.Button();
			this.ConfirmNewTeacherPassword = new System.Windows.Forms.TextBox();
			this.ConfirmNewPasswordLabel = new System.Windows.Forms.Label();
			this.NewTeacherPassword = new System.Windows.Forms.TextBox();
			this.NewTeacherUsername = new System.Windows.Forms.TextBox();
			this.NewTeacherName = new System.Windows.Forms.TextBox();
			this.TeacherPasswordLabel = new System.Windows.Forms.Label();
			this.TeacherUsernameLabel = new System.Windows.Forms.Label();
			this.TeacherNameLabel = new System.Windows.Forms.Label();
			this.EditTeacherBtn = new System.Windows.Forms.Button();
			this.LogoutBtn = new System.Windows.Forms.Button();
			this.HomeUserLabel = new System.Windows.Forms.Label();
			this.HomeLabel = new System.Windows.Forms.Label();
			this.HomeTabControl = new System.Windows.Forms.TabControl();
			this.StudentsListPage = new System.Windows.Forms.TabPage();
			this.AddStudentBtn = new System.Windows.Forms.Button();
			this.StudentsGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddStudentPage = new System.Windows.Forms.TabPage();
			this.AddStudentClass = new System.Windows.Forms.TextBox();
			this.AddStudentGrade = new System.Windows.Forms.TextBox();
			this.ErrorMsgAddStudent = new System.Windows.Forms.Label();
			this.AddNewStudentBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.AddStudentCourse = new System.Windows.Forms.TextBox();
			this.AddStudentName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.ConfirmDeletionPanel.SuspendLayout();
			this.EditTeacherPanel.SuspendLayout();
			this.HomeTabControl.SuspendLayout();
			this.StudentsListPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			this.AddStudentPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.splitContainer1.Panel1.Controls.Add(this.ConfirmDeletionPanel);
			this.splitContainer1.Panel1.Controls.Add(this.EditTeacherPanel);
			this.splitContainer1.Panel1.Controls.Add(this.EditTeacherBtn);
			this.splitContainer1.Panel1.Controls.Add(this.LogoutBtn);
			this.splitContainer1.Panel1.Controls.Add(this.HomeUserLabel);
			this.splitContainer1.Panel1.Controls.Add(this.HomeLabel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.HomeTabControl);
			this.splitContainer1.Size = new System.Drawing.Size(1968, 1312);
			this.splitContainer1.SplitterDistance = 701;
			this.splitContainer1.TabIndex = 0;
			// 
			// ConfirmDeletionPanel
			// 
			this.ConfirmDeletionPanel.BackColor = System.Drawing.Color.CadetBlue;
			this.ConfirmDeletionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ConfirmDeletionPanel.Controls.Add(this.CancelDeletionBtn);
			this.ConfirmDeletionPanel.Controls.Add(this.ConfirmDeletionErrorMsg);
			this.ConfirmDeletionPanel.Controls.Add(this.ConfirmDeletionPassword);
			this.ConfirmDeletionPanel.Controls.Add(this.label2);
			this.ConfirmDeletionPanel.Controls.Add(this.ConfirmDeletionBtn);
			this.ConfirmDeletionPanel.Location = new System.Drawing.Point(20, 275);
			this.ConfirmDeletionPanel.Name = "ConfirmDeletionPanel";
			this.ConfirmDeletionPanel.Size = new System.Drawing.Size(652, 448);
			this.ConfirmDeletionPanel.TabIndex = 5;
			this.ConfirmDeletionPanel.Visible = false;
			// 
			// CancelDeletionBtn
			// 
			this.CancelDeletionBtn.BackColor = System.Drawing.Color.Azure;
			this.CancelDeletionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CancelDeletionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelDeletionBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CancelDeletionBtn.Location = new System.Drawing.Point(340, 331);
			this.CancelDeletionBtn.Name = "CancelDeletionBtn";
			this.CancelDeletionBtn.Size = new System.Drawing.Size(211, 65);
			this.CancelDeletionBtn.TabIndex = 17;
			this.CancelDeletionBtn.Text = "Cancel";
			this.CancelDeletionBtn.UseVisualStyleBackColor = false;
			this.CancelDeletionBtn.Click += new System.EventHandler(this.CancelDeletionBtn_Click);
			// 
			// ConfirmDeletionErrorMsg
			// 
			this.ConfirmDeletionErrorMsg.AutoSize = true;
			this.ConfirmDeletionErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConfirmDeletionErrorMsg.ForeColor = System.Drawing.Color.White;
			this.ConfirmDeletionErrorMsg.Location = new System.Drawing.Point(88, 265);
			this.ConfirmDeletionErrorMsg.Name = "ConfirmDeletionErrorMsg";
			this.ConfirmDeletionErrorMsg.Size = new System.Drawing.Size(0, 41);
			this.ConfirmDeletionErrorMsg.TabIndex = 16;
			// 
			// ConfirmDeletionPassword
			// 
			this.ConfirmDeletionPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ConfirmDeletionPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConfirmDeletionPassword.Location = new System.Drawing.Point(88, 181);
			this.ConfirmDeletionPassword.Name = "ConfirmDeletionPassword";
			this.ConfirmDeletionPassword.PlaceholderText = "Enter your password";
			this.ConfirmDeletionPassword.Size = new System.Drawing.Size(463, 54);
			this.ConfirmDeletionPassword.TabIndex = 15;
			this.ConfirmDeletionPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(88, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(479, 54);
			this.label2.TabIndex = 14;
			this.label2.Text = "Please confirm deletion!";
			// 
			// ConfirmDeletionBtn
			// 
			this.ConfirmDeletionBtn.BackColor = System.Drawing.Color.LightCoral;
			this.ConfirmDeletionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ConfirmDeletionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ConfirmDeletionBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ConfirmDeletionBtn.Location = new System.Drawing.Point(88, 331);
			this.ConfirmDeletionBtn.Name = "ConfirmDeletionBtn";
			this.ConfirmDeletionBtn.Size = new System.Drawing.Size(199, 65);
			this.ConfirmDeletionBtn.TabIndex = 13;
			this.ConfirmDeletionBtn.Text = "Confirm";
			this.ConfirmDeletionBtn.UseVisualStyleBackColor = false;
			this.ConfirmDeletionBtn.Click += new System.EventHandler(this.ConfirmDeletionBtn_Click);
			// 
			// EditTeacherPanel
			// 
			this.EditTeacherPanel.Controls.Add(this.DeleteProfileBtn);
			this.EditTeacherPanel.Controls.Add(this.CancelUpdateBtn);
			this.EditTeacherPanel.Controls.Add(this.ErrorMsgUpdateTeacher);
			this.EditTeacherPanel.Controls.Add(this.SaveNewTeacherBtn);
			this.EditTeacherPanel.Controls.Add(this.ConfirmNewTeacherPassword);
			this.EditTeacherPanel.Controls.Add(this.ConfirmNewPasswordLabel);
			this.EditTeacherPanel.Controls.Add(this.NewTeacherPassword);
			this.EditTeacherPanel.Controls.Add(this.NewTeacherUsername);
			this.EditTeacherPanel.Controls.Add(this.NewTeacherName);
			this.EditTeacherPanel.Controls.Add(this.TeacherPasswordLabel);
			this.EditTeacherPanel.Controls.Add(this.TeacherUsernameLabel);
			this.EditTeacherPanel.Controls.Add(this.TeacherNameLabel);
			this.EditTeacherPanel.Location = new System.Drawing.Point(20, 275);
			this.EditTeacherPanel.Name = "EditTeacherPanel";
			this.EditTeacherPanel.Size = new System.Drawing.Size(652, 997);
			this.EditTeacherPanel.TabIndex = 4;
			this.EditTeacherPanel.Visible = false;
			// 
			// DeleteProfileBtn
			// 
			this.DeleteProfileBtn.BackColor = System.Drawing.Color.LightCoral;
			this.DeleteProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeleteProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteProfileBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteProfileBtn.Location = new System.Drawing.Point(166, 896);
			this.DeleteProfileBtn.Name = "DeleteProfileBtn";
			this.DeleteProfileBtn.Size = new System.Drawing.Size(296, 65);
			this.DeleteProfileBtn.TabIndex = 12;
			this.DeleteProfileBtn.Text = "Delete profile";
			this.DeleteProfileBtn.UseVisualStyleBackColor = false;
			this.DeleteProfileBtn.Click += new System.EventHandler(this.DeleteProfileBtn_Click);
			// 
			// CancelUpdateBtn
			// 
			this.CancelUpdateBtn.BackColor = System.Drawing.Color.Azure;
			this.CancelUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CancelUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CancelUpdateBtn.Location = new System.Drawing.Point(354, 775);
			this.CancelUpdateBtn.Name = "CancelUpdateBtn";
			this.CancelUpdateBtn.Size = new System.Drawing.Size(197, 80);
			this.CancelUpdateBtn.TabIndex = 11;
			this.CancelUpdateBtn.Text = "Cancel";
			this.CancelUpdateBtn.UseVisualStyleBackColor = false;
			this.CancelUpdateBtn.Click += new System.EventHandler(this.CancelUpdateBtn_Click);
			// 
			// ErrorMsgUpdateTeacher
			// 
			this.ErrorMsgUpdateTeacher.AutoSize = true;
			this.ErrorMsgUpdateTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ErrorMsgUpdateTeacher.ForeColor = System.Drawing.Color.White;
			this.ErrorMsgUpdateTeacher.Location = new System.Drawing.Point(88, 714);
			this.ErrorMsgUpdateTeacher.Name = "ErrorMsgUpdateTeacher";
			this.ErrorMsgUpdateTeacher.Size = new System.Drawing.Size(0, 41);
			this.ErrorMsgUpdateTeacher.TabIndex = 9;
			// 
			// SaveNewTeacherBtn
			// 
			this.SaveNewTeacherBtn.BackColor = System.Drawing.Color.LightSkyBlue;
			this.SaveNewTeacherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveNewTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveNewTeacherBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SaveNewTeacherBtn.Location = new System.Drawing.Point(88, 775);
			this.SaveNewTeacherBtn.Name = "SaveNewTeacherBtn";
			this.SaveNewTeacherBtn.Size = new System.Drawing.Size(197, 80);
			this.SaveNewTeacherBtn.TabIndex = 10;
			this.SaveNewTeacherBtn.Text = "Save";
			this.SaveNewTeacherBtn.UseVisualStyleBackColor = false;
			this.SaveNewTeacherBtn.Click += new System.EventHandler(this.SaveNewTeacherBtn_Click);
			// 
			// ConfirmNewTeacherPassword
			// 
			this.ConfirmNewTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ConfirmNewTeacherPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConfirmNewTeacherPassword.Location = new System.Drawing.Point(88, 630);
			this.ConfirmNewTeacherPassword.Name = "ConfirmNewTeacherPassword";
			this.ConfirmNewTeacherPassword.PlaceholderText = "Confirm password";
			this.ConfirmNewTeacherPassword.Size = new System.Drawing.Size(463, 54);
			this.ConfirmNewTeacherPassword.TabIndex = 8;
			this.ConfirmNewTeacherPassword.UseSystemPasswordChar = true;
			// 
			// ConfirmNewPasswordLabel
			// 
			this.ConfirmNewPasswordLabel.AutoSize = true;
			this.ConfirmNewPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConfirmNewPasswordLabel.Location = new System.Drawing.Point(88, 564);
			this.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel";
			this.ConfirmNewPasswordLabel.Size = new System.Drawing.Size(362, 46);
			this.ConfirmNewPasswordLabel.TabIndex = 7;
			this.ConfirmNewPasswordLabel.Text = "Confirm new password";
			// 
			// NewTeacherPassword
			// 
			this.NewTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NewTeacherPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewTeacherPassword.Location = new System.Drawing.Point(88, 454);
			this.NewTeacherPassword.Name = "NewTeacherPassword";
			this.NewTeacherPassword.PlaceholderText = "Enter new password";
			this.NewTeacherPassword.Size = new System.Drawing.Size(463, 54);
			this.NewTeacherPassword.TabIndex = 6;
			this.NewTeacherPassword.UseSystemPasswordChar = true;
			// 
			// NewTeacherUsername
			// 
			this.NewTeacherUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NewTeacherUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewTeacherUsername.Location = new System.Drawing.Point(88, 284);
			this.NewTeacherUsername.Name = "NewTeacherUsername";
			this.NewTeacherUsername.PlaceholderText = "Enter new username";
			this.NewTeacherUsername.Size = new System.Drawing.Size(463, 54);
			this.NewTeacherUsername.TabIndex = 5;
			// 
			// NewTeacherName
			// 
			this.NewTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NewTeacherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewTeacherName.Location = new System.Drawing.Point(88, 120);
			this.NewTeacherName.Name = "NewTeacherName";
			this.NewTeacherName.PlaceholderText = "Enter new name";
			this.NewTeacherName.Size = new System.Drawing.Size(463, 54);
			this.NewTeacherName.TabIndex = 4;
			// 
			// TeacherPasswordLabel
			// 
			this.TeacherPasswordLabel.AutoSize = true;
			this.TeacherPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TeacherPasswordLabel.Location = new System.Drawing.Point(88, 388);
			this.TeacherPasswordLabel.Name = "TeacherPasswordLabel";
			this.TeacherPasswordLabel.Size = new System.Drawing.Size(285, 46);
			this.TeacherPasswordLabel.TabIndex = 2;
			this.TeacherPasswordLabel.Text = "Change password";
			// 
			// TeacherUsernameLabel
			// 
			this.TeacherUsernameLabel.AutoSize = true;
			this.TeacherUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TeacherUsernameLabel.Location = new System.Drawing.Point(88, 217);
			this.TeacherUsernameLabel.Name = "TeacherUsernameLabel";
			this.TeacherUsernameLabel.Size = new System.Drawing.Size(289, 46);
			this.TeacherUsernameLabel.TabIndex = 1;
			this.TeacherUsernameLabel.Text = "Change username";
			// 
			// TeacherNameLabel
			// 
			this.TeacherNameLabel.AutoSize = true;
			this.TeacherNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TeacherNameLabel.Location = new System.Drawing.Point(88, 55);
			this.TeacherNameLabel.Name = "TeacherNameLabel";
			this.TeacherNameLabel.Size = new System.Drawing.Size(226, 46);
			this.TeacherNameLabel.TabIndex = 0;
			this.TeacherNameLabel.Text = "Change name";
			// 
			// EditTeacherBtn
			// 
			this.EditTeacherBtn.AccessibleName = "Logout";
			this.EditTeacherBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.EditTeacherBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditTeacherBtn.BackgroundImage")));
			this.EditTeacherBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditTeacherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EditTeacherBtn.FlatAppearance.BorderSize = 0;
			this.EditTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditTeacherBtn.Location = new System.Drawing.Point(632, 95);
			this.EditTeacherBtn.Name = "EditTeacherBtn";
			this.EditTeacherBtn.Size = new System.Drawing.Size(47, 58);
			this.EditTeacherBtn.TabIndex = 3;
			this.EditTeacherBtn.Tag = "Edit";
			this.EditTeacherBtn.UseVisualStyleBackColor = false;
			this.EditTeacherBtn.Click += new System.EventHandler(this.EditTeacherBtn_Click);
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.AccessibleName = "Logout";
			this.LogoutBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.LogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.BackgroundImage")));
			this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LogoutBtn.FlatAppearance.BorderSize = 0;
			this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogoutBtn.Location = new System.Drawing.Point(25, 22);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(47, 58);
			this.LogoutBtn.TabIndex = 2;
			this.LogoutBtn.Tag = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = false;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// HomeUserLabel
			// 
			this.HomeUserLabel.AutoSize = true;
			this.HomeUserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.HomeUserLabel.Location = new System.Drawing.Point(198, 95);
			this.HomeUserLabel.MaximumSize = new System.Drawing.Size(350, 0);
			this.HomeUserLabel.Name = "HomeUserLabel";
			this.HomeUserLabel.Size = new System.Drawing.Size(34, 54);
			this.HomeUserLabel.TabIndex = 1;
			this.HomeUserLabel.Text = " ";
			this.HomeUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HomeLabel
			// 
			this.HomeLabel.AutoSize = true;
			this.HomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.HomeLabel.ForeColor = System.Drawing.Color.Black;
			this.HomeLabel.Location = new System.Drawing.Point(12, 95);
			this.HomeLabel.Name = "HomeLabel";
			this.HomeLabel.Size = new System.Drawing.Size(180, 54);
			this.HomeLabel.TabIndex = 0;
			this.HomeLabel.Text = "Teacher:";
			this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HomeTabControl
			// 
			this.HomeTabControl.Controls.Add(this.StudentsListPage);
			this.HomeTabControl.Controls.Add(this.AddStudentPage);
			this.HomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HomeTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.HomeTabControl.ItemSize = new System.Drawing.Size(173, 40);
			this.HomeTabControl.Location = new System.Drawing.Point(0, 0);
			this.HomeTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.HomeTabControl.Name = "HomeTabControl";
			this.HomeTabControl.SelectedIndex = 0;
			this.HomeTabControl.Size = new System.Drawing.Size(1263, 1312);
			this.HomeTabControl.TabIndex = 0;
			// 
			// StudentsListPage
			// 
			this.StudentsListPage.Controls.Add(this.AddStudentBtn);
			this.StudentsListPage.Controls.Add(this.StudentsGridView);
			this.StudentsListPage.Location = new System.Drawing.Point(10, 50);
			this.StudentsListPage.Margin = new System.Windows.Forms.Padding(0);
			this.StudentsListPage.Name = "StudentsListPage";
			this.StudentsListPage.Size = new System.Drawing.Size(1243, 1252);
			this.StudentsListPage.TabIndex = 0;
			this.StudentsListPage.Text = "Students list";
			this.StudentsListPage.UseVisualStyleBackColor = true;
			// 
			// AddStudentBtn
			// 
			this.AddStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddStudentBtn.Location = new System.Drawing.Point(0, 0);
			this.AddStudentBtn.Name = "AddStudentBtn";
			this.AddStudentBtn.Size = new System.Drawing.Size(101, 49);
			this.AddStudentBtn.TabIndex = 3;
			this.AddStudentBtn.Text = "Add";
			this.AddStudentBtn.UseVisualStyleBackColor = true;
			this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
			// 
			// StudentsGridView
			// 
			this.StudentsGridView.AutoGenerateColumns = false;
			this.StudentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StudentsGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.StudentsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.StudentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
			this.StudentsGridView.DataSource = this.studentBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.NullValue = "🗑";
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.StudentsGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.StudentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentsGridView.GridColor = System.Drawing.Color.AliceBlue;
			this.StudentsGridView.Location = new System.Drawing.Point(0, 0);
			this.StudentsGridView.Margin = new System.Windows.Forms.Padding(0);
			this.StudentsGridView.Name = "StudentsGridView";
			this.StudentsGridView.RowHeadersWidth = 102;
			this.StudentsGridView.RowTemplate.Height = 49;
			this.StudentsGridView.Size = new System.Drawing.Size(1243, 1252);
			this.StudentsGridView.TabIndex = 2;
			this.StudentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGridView_CellContentClick);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 12;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.MinimumWidth = 12;
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			this.classDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// courseDataGridViewTextBoxColumn
			// 
			this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
			this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
			this.courseDataGridViewTextBoxColumn.MinimumWidth = 12;
			this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
			this.courseDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// gradeDataGridViewTextBoxColumn
			// 
			this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
			this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
			this.gradeDataGridViewTextBoxColumn.MinimumWidth = 12;
			this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
			this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Edit
			// 
			this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.NullValue = "✏️";
			this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
			this.Edit.HeaderText = "Edit";
			this.Edit.MinimumWidth = 12;
			this.Edit.Name = "Edit";
			this.Edit.ReadOnly = true;
			this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Edit.Width = 74;
			// 
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Delete.HeaderText = "Delete";
			this.Delete.MinimumWidth = 12;
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Delete.Width = 110;
			// 
			// studentBindingSource
			// 
			this.studentBindingSource.DataSource = typeof(StudentMS.Models.Student);
			// 
			// AddStudentPage
			// 
			this.AddStudentPage.BackColor = System.Drawing.Color.AliceBlue;
			this.AddStudentPage.Controls.Add(this.AddStudentClass);
			this.AddStudentPage.Controls.Add(this.AddStudentGrade);
			this.AddStudentPage.Controls.Add(this.ErrorMsgAddStudent);
			this.AddStudentPage.Controls.Add(this.AddNewStudentBtn);
			this.AddStudentPage.Controls.Add(this.label1);
			this.AddStudentPage.Controls.Add(this.AddStudentCourse);
			this.AddStudentPage.Controls.Add(this.AddStudentName);
			this.AddStudentPage.Location = new System.Drawing.Point(10, 50);
			this.AddStudentPage.Margin = new System.Windows.Forms.Padding(0);
			this.AddStudentPage.Name = "AddStudentPage";
			this.AddStudentPage.Size = new System.Drawing.Size(1243, 1252);
			this.AddStudentPage.TabIndex = 1;
			this.AddStudentPage.Text = "Add Student";
			// 
			// AddStudentClass
			// 
			this.AddStudentClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AddStudentClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddStudentClass.Location = new System.Drawing.Point(385, 401);
			this.AddStudentClass.Name = "AddStudentClass";
			this.AddStudentClass.PlaceholderText = "Enter student\'s class";
			this.AddStudentClass.Size = new System.Drawing.Size(463, 54);
			this.AddStudentClass.TabIndex = 2;
			// 
			// AddStudentGrade
			// 
			this.AddStudentGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AddStudentGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddStudentGrade.Location = new System.Drawing.Point(385, 611);
			this.AddStudentGrade.Name = "AddStudentGrade";
			this.AddStudentGrade.PlaceholderText = "Enter grade";
			this.AddStudentGrade.Size = new System.Drawing.Size(463, 54);
			this.AddStudentGrade.TabIndex = 5;
			this.AddStudentGrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// ErrorMsgAddStudent
			// 
			this.ErrorMsgAddStudent.AutoSize = true;
			this.ErrorMsgAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ErrorMsgAddStudent.ForeColor = System.Drawing.Color.Red;
			this.ErrorMsgAddStudent.Location = new System.Drawing.Point(385, 690);
			this.ErrorMsgAddStudent.Name = "ErrorMsgAddStudent";
			this.ErrorMsgAddStudent.Size = new System.Drawing.Size(0, 41);
			this.ErrorMsgAddStudent.TabIndex = 4;
			// 
			// AddNewStudentBtn
			// 
			this.AddNewStudentBtn.BackColor = System.Drawing.Color.LightSkyBlue;
			this.AddNewStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddNewStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNewStudentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddNewStudentBtn.Location = new System.Drawing.Point(385, 751);
			this.AddNewStudentBtn.Name = "AddNewStudentBtn";
			this.AddNewStudentBtn.Size = new System.Drawing.Size(240, 80);
			this.AddNewStudentBtn.TabIndex = 6;
			this.AddNewStudentBtn.Text = "Add";
			this.AddNewStudentBtn.UseVisualStyleBackColor = false;
			this.AddNewStudentBtn.Click += new System.EventHandler(this.AddNewStudentBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(385, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 72);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add new student";
			// 
			// AddStudentCourse
			// 
			this.AddStudentCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AddStudentCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddStudentCourse.Location = new System.Drawing.Point(385, 507);
			this.AddStudentCourse.Name = "AddStudentCourse";
			this.AddStudentCourse.PlaceholderText = "Enter course";
			this.AddStudentCourse.Size = new System.Drawing.Size(463, 54);
			this.AddStudentCourse.TabIndex = 3;
			this.AddStudentCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// AddStudentName
			// 
			this.AddStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AddStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddStudentName.Location = new System.Drawing.Point(385, 295);
			this.AddStudentName.Name = "AddStudentName";
			this.AddStudentName.PlaceholderText = "Enter student\'s full name";
			this.AddStudentName.Size = new System.Drawing.Size(463, 54);
			this.AddStudentName.TabIndex = 1;
			this.AddStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1968, 1312);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ConfirmDeletionPanel.ResumeLayout(false);
			this.ConfirmDeletionPanel.PerformLayout();
			this.EditTeacherPanel.ResumeLayout(false);
			this.EditTeacherPanel.PerformLayout();
			this.HomeTabControl.ResumeLayout(false);
			this.StudentsListPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			this.AddStudentPage.ResumeLayout(false);
			this.AddStudentPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SplitContainer splitContainer1;
		public Label HomeLabel;
		public Label HomeUserLabel;
		private Button LogoutBtn;
		private BindingSource studentBindingSource;
		private TabControl HomeTabControl;
		private TabPage StudentsListPage;
		private Button AddStudentBtn;
		private DataGridView StudentsGridView;
		private TabPage AddStudentPage;
		private Label label1;
		private TextBox AddStudentCourse;
		private TextBox AddStudentName;
		private Button AddNewStudentBtn;
		public Label ErrorMsgAddStudent;
		private TextBox AddStudentGrade;
		private TextBox AddStudentClass;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
		private DataGridViewButtonColumn Edit;
		private DataGridViewButtonColumn Delete;
		private Button EditTeacherBtn;
		private Panel EditTeacherPanel;
		private Label TeacherUsernameLabel;
		private Label TeacherNameLabel;
		private TextBox ConfirmNewTeacherPassword;
		private Label ConfirmNewPasswordLabel;
		private TextBox NewTeacherPassword;
		private TextBox NewTeacherUsername;
		private TextBox NewTeacherName;
		private Label TeacherPasswordLabel;
		public Label ErrorMsgUpdateTeacher;
		private Button SaveNewTeacherBtn;
		private Button CancelUpdateBtn;
		private Panel ConfirmDeletionPanel;
		private Label label2;
		private Button ConfirmDeletionBtn;
		private Button DeleteProfileBtn;
		private TextBox ConfirmDeletionPassword;
		public Label ConfirmDeletionErrorMsg;
		private Button CancelDeletionBtn;
	}
}