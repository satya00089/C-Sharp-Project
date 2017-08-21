namespace BIRTHDAYWISHER_APP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtDOB = new MetroFramework.Controls.MetroTextBox();
            this.txtMobileno = new MetroFramework.Controls.MetroTextBox();
            this.txtRedgno = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtreciever = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbody = new MetroFramework.Controls.MetroTextBox();
            this.txtsubject = new MetroFramework.Controls.MetroTextBox();
            this.txtattachment = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtsender = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBox1.DisplayMember = "satya";
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroComboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Computer Science Engineering",
            "Civil Engineering",
            "Electronics Communication Engineering",
            "Electrical Engineering",
            "Electrical Electronics Engineering",
            "Mechanical Engineering"});
            this.metroComboBox1.Location = new System.Drawing.Point(12, 67);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(258, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBox1.TabIndex = 19;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(284, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(390, 225);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(284, 10);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(390, 23);
            this.txtSearch.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(276, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 260);
            this.panel2.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(185, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Display";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Update";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(141, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Delete";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(50, 189);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Insert";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(12, 160);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter E-Mail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(258, 23);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Enter E-Mail";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDOB
            // 
            // 
            // 
            // 
            this.txtDOB.CustomButton.Image = null;
            this.txtDOB.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtDOB.CustomButton.Name = "";
            this.txtDOB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDOB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDOB.CustomButton.TabIndex = 1;
            this.txtDOB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDOB.CustomButton.UseSelectable = true;
            this.txtDOB.CustomButton.Visible = false;
            this.txtDOB.Lines = new string[0];
            this.txtDOB.Location = new System.Drawing.Point(12, 130);
            this.txtDOB.MaxLength = 32767;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.PromptText = "Enter Date Of Birth";
            this.txtDOB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDOB.SelectedText = "";
            this.txtDOB.SelectionLength = 0;
            this.txtDOB.SelectionStart = 0;
            this.txtDOB.ShortcutsEnabled = true;
            this.txtDOB.Size = new System.Drawing.Size(258, 23);
            this.txtDOB.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtDOB.TabIndex = 9;
            this.txtDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDOB.UseSelectable = true;
            this.txtDOB.WaterMark = "Enter Date Of Birth";
            this.txtDOB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtDOB.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtMobileno
            // 
            // 
            // 
            // 
            this.txtMobileno.CustomButton.Image = null;
            this.txtMobileno.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtMobileno.CustomButton.Name = "";
            this.txtMobileno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMobileno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobileno.CustomButton.TabIndex = 1;
            this.txtMobileno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobileno.CustomButton.UseSelectable = true;
            this.txtMobileno.CustomButton.Visible = false;
            this.txtMobileno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtMobileno.Lines = new string[0];
            this.txtMobileno.Location = new System.Drawing.Point(12, 100);
            this.txtMobileno.MaxLength = 10;
            this.txtMobileno.Name = "txtMobileno";
            this.txtMobileno.PasswordChar = '\0';
            this.txtMobileno.PromptText = "Enter Mobile Number";
            this.txtMobileno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobileno.SelectedText = "";
            this.txtMobileno.SelectionLength = 0;
            this.txtMobileno.SelectionStart = 0;
            this.txtMobileno.ShortcutsEnabled = true;
            this.txtMobileno.Size = new System.Drawing.Size(258, 23);
            this.txtMobileno.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMobileno.TabIndex = 8;
            this.txtMobileno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMobileno.UseSelectable = true;
            this.txtMobileno.WaterMark = "Enter Mobile Number";
            this.txtMobileno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtMobileno.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileno_KeyPress);
            // 
            // txtRedgno
            // 
            // 
            // 
            // 
            this.txtRedgno.CustomButton.Image = null;
            this.txtRedgno.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtRedgno.CustomButton.Name = "";
            this.txtRedgno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRedgno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRedgno.CustomButton.TabIndex = 1;
            this.txtRedgno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRedgno.CustomButton.UseSelectable = true;
            this.txtRedgno.CustomButton.Visible = false;
            this.txtRedgno.Lines = new string[0];
            this.txtRedgno.Location = new System.Drawing.Point(12, 40);
            this.txtRedgno.MaxLength = 10;
            this.txtRedgno.Name = "txtRedgno";
            this.txtRedgno.PasswordChar = '\0';
            this.txtRedgno.PromptText = "Enter Registion No";
            this.txtRedgno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRedgno.SelectedText = "";
            this.txtRedgno.SelectionLength = 0;
            this.txtRedgno.SelectionStart = 0;
            this.txtRedgno.ShortcutsEnabled = true;
            this.txtRedgno.Size = new System.Drawing.Size(258, 23);
            this.txtRedgno.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtRedgno.TabIndex = 6;
            this.txtRedgno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRedgno.UseSelectable = true;
            this.txtRedgno.WaterMark = "Enter Registion No";
            this.txtRedgno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtRedgno.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedgno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedgno_KeyPress);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(12, 10);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter Full Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(258, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter Full Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtreciever);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbody);
            this.panel1.Controls.Add(this.txtsubject);
            this.panel1.Controls.Add(this.txtattachment);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtsender);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDOB);
            this.panel1.Controls.Add(this.txtMobileno);
            this.panel1.Controls.Add(this.txtRedgno);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 270);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(863, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Log Out";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtreciever
            // 
            // 
            // 
            // 
            this.txtreciever.CustomButton.Image = null;
            this.txtreciever.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtreciever.CustomButton.Name = "";
            this.txtreciever.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtreciever.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtreciever.CustomButton.TabIndex = 1;
            this.txtreciever.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtreciever.CustomButton.UseSelectable = true;
            this.txtreciever.CustomButton.Visible = false;
            this.txtreciever.Lines = new string[0];
            this.txtreciever.Location = new System.Drawing.Point(688, 10);
            this.txtreciever.MaxLength = 32767;
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.PasswordChar = '\0';
            this.txtreciever.PromptText = "Enter Reciever\'s Mail id";
            this.txtreciever.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtreciever.SelectedText = "";
            this.txtreciever.SelectionLength = 0;
            this.txtreciever.SelectionStart = 0;
            this.txtreciever.ShortcutsEnabled = true;
            this.txtreciever.Size = new System.Drawing.Size(169, 23);
            this.txtreciever.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtreciever.TabIndex = 22;
            this.txtreciever.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtreciever.UseSelectable = true;
            this.txtreciever.WaterMark = "Enter Reciever\'s Mail id";
            this.txtreciever.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtreciever.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(861, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Browse";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(688, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Send Mail";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbody
            // 
            // 
            // 
            // 
            this.txtbody.CustomButton.Image = null;
            this.txtbody.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtbody.CustomButton.Name = "";
            this.txtbody.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.txtbody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbody.CustomButton.TabIndex = 1;
            this.txtbody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbody.CustomButton.UseSelectable = true;
            this.txtbody.CustomButton.Visible = false;
            this.txtbody.Lines = new string[0];
            this.txtbody.Location = new System.Drawing.Point(688, 130);
            this.txtbody.MaxLength = 32767;
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.PasswordChar = '\0';
            this.txtbody.PromptText = "Enter Message";
            this.txtbody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbody.SelectedText = "";
            this.txtbody.SelectionLength = 0;
            this.txtbody.SelectionStart = 0;
            this.txtbody.ShortcutsEnabled = true;
            this.txtbody.Size = new System.Drawing.Size(258, 89);
            this.txtbody.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtbody.TabIndex = 25;
            this.txtbody.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbody.UseSelectable = true;
            this.txtbody.WaterMark = "Enter Message";
            this.txtbody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtbody.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.CustomButton.Image = null;
            this.txtsubject.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtsubject.CustomButton.Name = "";
            this.txtsubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsubject.CustomButton.TabIndex = 1;
            this.txtsubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsubject.CustomButton.UseSelectable = true;
            this.txtsubject.CustomButton.Visible = false;
            this.txtsubject.Lines = new string[0];
            this.txtsubject.Location = new System.Drawing.Point(688, 100);
            this.txtsubject.MaxLength = 32767;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PasswordChar = '\0';
            this.txtsubject.PromptText = "Enter Subject";
            this.txtsubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsubject.SelectedText = "";
            this.txtsubject.SelectionLength = 0;
            this.txtsubject.SelectionStart = 0;
            this.txtsubject.ShortcutsEnabled = true;
            this.txtsubject.Size = new System.Drawing.Size(258, 23);
            this.txtsubject.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtsubject.TabIndex = 24;
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsubject.UseSelectable = true;
            this.txtsubject.WaterMark = "Enter Subject";
            this.txtsubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtsubject.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtattachment
            // 
            // 
            // 
            // 
            this.txtattachment.CustomButton.Image = null;
            this.txtattachment.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtattachment.CustomButton.Name = "";
            this.txtattachment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtattachment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtattachment.CustomButton.TabIndex = 1;
            this.txtattachment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtattachment.CustomButton.UseSelectable = true;
            this.txtattachment.CustomButton.Visible = false;
            this.txtattachment.Lines = new string[0];
            this.txtattachment.Location = new System.Drawing.Point(688, 71);
            this.txtattachment.MaxLength = 32767;
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.PasswordChar = '\0';
            this.txtattachment.PromptText = "Add Attachment";
            this.txtattachment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtattachment.SelectedText = "";
            this.txtattachment.SelectionLength = 0;
            this.txtattachment.SelectionStart = 0;
            this.txtattachment.ShortcutsEnabled = true;
            this.txtattachment.Size = new System.Drawing.Size(169, 23);
            this.txtattachment.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtattachment.TabIndex = 23;
            this.txtattachment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtattachment.UseSelectable = true;
            this.txtattachment.WaterMark = "Add Attachment";
            this.txtattachment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtattachment.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(821, 40);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PromptText = "Sender Password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(125, 23);
            this.txtpassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtpassword.TabIndex = 21;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMark = "Sender Password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtsender
            // 
            // 
            // 
            // 
            this.txtsender.CustomButton.Image = null;
            this.txtsender.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtsender.CustomButton.Name = "";
            this.txtsender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsender.CustomButton.TabIndex = 1;
            this.txtsender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsender.CustomButton.UseSelectable = true;
            this.txtsender.CustomButton.Visible = false;
            this.txtsender.Lines = new string[0];
            this.txtsender.Location = new System.Drawing.Point(688, 40);
            this.txtsender.MaxLength = 32767;
            this.txtsender.Name = "txtsender";
            this.txtsender.PasswordChar = '\0';
            this.txtsender.PromptText = "Sender Mail id";
            this.txtsender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsender.SelectedText = "";
            this.txtsender.SelectionLength = 0;
            this.txtsender.SelectionStart = 0;
            this.txtsender.ShortcutsEnabled = true;
            this.txtsender.Size = new System.Drawing.Size(125, 23);
            this.txtsender.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtsender.TabIndex = 20;
            this.txtsender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsender.UseSelectable = true;
            this.txtsender.WaterMark = "Sender Mail id";
            this.txtsender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.txtsender.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(680, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 260);
            this.panel4.TabIndex = 18;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroPanel1.Controls.Add(this.button3);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(342, 51);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(318, 229);
            this.metroPanel1.TabIndex = 28;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(119, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 30);
            this.button3.TabIndex = 31;
            this.button3.Text = "Login";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(30, 110);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '*';
            this.metroTextBox2.PromptText = "Enter Password";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(258, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox2.TabIndex = 30;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Enter Password";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(30, 50);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Enter User Id";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(258, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBox1.TabIndex = 29;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Enter User Id";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 350);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 350);
            this.MinimumSize = new System.Drawing.Size(1000, 350);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "BirthDay Wisher";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtDOB;
        private MetroFramework.Controls.MetroTextBox txtMobileno;
        private MetroFramework.Controls.MetroTextBox txtRedgno;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtbody;
        private MetroFramework.Controls.MetroTextBox txtsubject;
        private MetroFramework.Controls.MetroTextBox txtattachment;
        private MetroFramework.Controls.MetroTextBox txtreciever;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroTextBox txtsender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

