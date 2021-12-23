
namespace School_Management_System
{
    partial class StudentdpForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AbsenceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ShowAllStudent = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateStudent = new Guna.UI2.WinForms.Guna2Button();
            this.FindStudent = new Guna.UI2.WinForms.Guna2Button();
            this.AddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.ShowSectionGroupBx = new System.Windows.Forms.GroupBox();
            this.maleradiobtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.femaleradiobtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phonetxtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordtxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lastnametxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Firstnametxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtxtbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.ShowSectionGroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 83;
            this.label6.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 85;
            this.label1.Text = "Group";
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AllowUserToAddRows = false;
            this.StudentDataGridView.AllowUserToDeleteRows = false;
            this.StudentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StudentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.StudentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDataGridView.EnableHeadersVisualStyles = false;
            this.StudentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentDataGridView.Location = new System.Drawing.Point(423, 66);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            this.StudentDataGridView.RowHeadersVisible = false;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(541, 470);
            this.StudentDataGridView.TabIndex = 87;
            this.StudentDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.StudentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StudentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.StudentDataGridView.ThemeStyle.ReadOnly = true;
            this.StudentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StudentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentDataGridView.SelectionChanged += new System.EventHandler(this.StudentDataGridView_SelectionChanged);
            // 
            // AbsenceBtn
            // 
            this.AbsenceBtn.AutoRoundedCorners = true;
            this.AbsenceBtn.BorderRadius = 23;
            this.AbsenceBtn.CheckedState.Parent = this.AbsenceBtn;
            this.AbsenceBtn.CustomImages.Parent = this.AbsenceBtn;
            this.AbsenceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AbsenceBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsenceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.AbsenceBtn.HoverState.Parent = this.AbsenceBtn;
            this.AbsenceBtn.Location = new System.Drawing.Point(144, 120);
            this.AbsenceBtn.Name = "AbsenceBtn";
            this.AbsenceBtn.ShadowDecoration.Parent = this.AbsenceBtn;
            this.AbsenceBtn.Size = new System.Drawing.Size(119, 48);
            this.AbsenceBtn.TabIndex = 93;
            this.AbsenceBtn.Text = "Absence";
            this.AbsenceBtn.Click += new System.EventHandler(this.AbsenceBtn_Click);
            // 
            // ShowAllStudent
            // 
            this.ShowAllStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllStudent.AutoRoundedCorners = true;
            this.ShowAllStudent.BorderRadius = 23;
            this.ShowAllStudent.CheckedState.Parent = this.ShowAllStudent;
            this.ShowAllStudent.CustomImages.Parent = this.ShowAllStudent;
            this.ShowAllStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ShowAllStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ShowAllStudent.HoverState.Parent = this.ShowAllStudent;
            this.ShowAllStudent.Location = new System.Drawing.Point(845, 12);
            this.ShowAllStudent.Name = "ShowAllStudent";
            this.ShowAllStudent.ShadowDecoration.Parent = this.ShowAllStudent;
            this.ShowAllStudent.Size = new System.Drawing.Size(119, 48);
            this.ShowAllStudent.TabIndex = 92;
            this.ShowAllStudent.Text = "Show All";
            this.ShowAllStudent.Click += new System.EventHandler(this.ShowAllStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.AutoRoundedCorners = true;
            this.DeleteStudent.BorderRadius = 23;
            this.DeleteStudent.CheckedState.Parent = this.DeleteStudent;
            this.DeleteStudent.CustomImages.Parent = this.DeleteStudent;
            this.DeleteStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudent.ForeColor = System.Drawing.Color.White;
            this.DeleteStudent.HoverState.Parent = this.DeleteStudent;
            this.DeleteStudent.Location = new System.Drawing.Point(12, 120);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.ShadowDecoration.Parent = this.DeleteStudent;
            this.DeleteStudent.Size = new System.Drawing.Size(119, 48);
            this.DeleteStudent.TabIndex = 91;
            this.DeleteStudent.Text = "Delete";
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.AutoRoundedCorners = true;
            this.UpdateStudent.BorderRadius = 23;
            this.UpdateStudent.CheckedState.Parent = this.UpdateStudent;
            this.UpdateStudent.CustomImages.Parent = this.UpdateStudent;
            this.UpdateStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStudent.ForeColor = System.Drawing.Color.White;
            this.UpdateStudent.HoverState.Parent = this.UpdateStudent;
            this.UpdateStudent.Location = new System.Drawing.Point(276, 66);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.ShadowDecoration.Parent = this.UpdateStudent;
            this.UpdateStudent.Size = new System.Drawing.Size(119, 48);
            this.UpdateStudent.TabIndex = 90;
            this.UpdateStudent.Text = "Update";
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // FindStudent
            // 
            this.FindStudent.AutoRoundedCorners = true;
            this.FindStudent.BorderRadius = 23;
            this.FindStudent.CheckedState.Parent = this.FindStudent;
            this.FindStudent.CustomImages.Parent = this.FindStudent;
            this.FindStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindStudent.ForeColor = System.Drawing.Color.White;
            this.FindStudent.HoverState.Parent = this.FindStudent;
            this.FindStudent.Location = new System.Drawing.Point(144, 66);
            this.FindStudent.Name = "FindStudent";
            this.FindStudent.ShadowDecoration.Parent = this.FindStudent;
            this.FindStudent.Size = new System.Drawing.Size(119, 48);
            this.FindStudent.TabIndex = 89;
            this.FindStudent.Text = "Find";
            this.FindStudent.Click += new System.EventHandler(this.FindStudent_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.AutoRoundedCorners = true;
            this.AddStudent.BorderRadius = 23;
            this.AddStudent.CheckedState.Parent = this.AddStudent;
            this.AddStudent.CustomImages.Parent = this.AddStudent;
            this.AddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent.ForeColor = System.Drawing.Color.White;
            this.AddStudent.HoverState.Parent = this.AddStudent;
            this.AddStudent.Location = new System.Drawing.Point(12, 66);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.ShadowDecoration.Parent = this.AddStudent;
            this.AddStudent.Size = new System.Drawing.Size(119, 48);
            this.AddStudent.TabIndex = 88;
            this.AddStudent.Text = "Add";
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ShowSectionGroupBx
            // 
            this.ShowSectionGroupBx.Controls.Add(this.maleradiobtn);
            this.ShowSectionGroupBx.Controls.Add(this.femaleradiobtn);
            this.ShowSectionGroupBx.Controls.Add(this.label11);
            this.ShowSectionGroupBx.Controls.Add(this.dateTimePicker1);
            this.ShowSectionGroupBx.Controls.Add(this.GroupLabel);
            this.ShowSectionGroupBx.Controls.Add(this.label8);
            this.ShowSectionGroupBx.Controls.Add(this.label9);
            this.ShowSectionGroupBx.Controls.Add(this.phonetxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label7);
            this.ShowSectionGroupBx.Controls.Add(this.passwordtxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label5);
            this.ShowSectionGroupBx.Controls.Add(this.emailtxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label4);
            this.ShowSectionGroupBx.Controls.Add(this.Lastnametxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label3);
            this.ShowSectionGroupBx.Controls.Add(this.Firstnametxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label2);
            this.ShowSectionGroupBx.Controls.Add(this.idtxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label10);
            this.ShowSectionGroupBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowSectionGroupBx.ForeColor = System.Drawing.Color.White;
            this.ShowSectionGroupBx.Location = new System.Drawing.Point(12, 167);
            this.ShowSectionGroupBx.Name = "ShowSectionGroupBx";
            this.ShowSectionGroupBx.Size = new System.Drawing.Size(392, 372);
            this.ShowSectionGroupBx.TabIndex = 94;
            this.ShowSectionGroupBx.TabStop = false;
            // 
            // maleradiobtn
            // 
            this.maleradiobtn.AutoSize = true;
            this.maleradiobtn.Checked = true;
            this.maleradiobtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleradiobtn.CheckedState.BorderThickness = 0;
            this.maleradiobtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleradiobtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.maleradiobtn.CheckedState.InnerOffset = -4;
            this.maleradiobtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.maleradiobtn.ForeColor = System.Drawing.Color.White;
            this.maleradiobtn.Location = new System.Drawing.Point(170, 257);
            this.maleradiobtn.Name = "maleradiobtn";
            this.maleradiobtn.Size = new System.Drawing.Size(78, 32);
            this.maleradiobtn.TabIndex = 76;
            this.maleradiobtn.TabStop = true;
            this.maleradiobtn.Text = "Male";
            this.maleradiobtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.maleradiobtn.UncheckedState.BorderThickness = 2;
            this.maleradiobtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.maleradiobtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.maleradiobtn.UseVisualStyleBackColor = true;
            // 
            // femaleradiobtn
            // 
            this.femaleradiobtn.AutoSize = true;
            this.femaleradiobtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleradiobtn.CheckedState.BorderThickness = 0;
            this.femaleradiobtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleradiobtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.femaleradiobtn.CheckedState.InnerOffset = -4;
            this.femaleradiobtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.femaleradiobtn.ForeColor = System.Drawing.Color.White;
            this.femaleradiobtn.Location = new System.Drawing.Point(285, 257);
            this.femaleradiobtn.Name = "femaleradiobtn";
            this.femaleradiobtn.Size = new System.Drawing.Size(100, 32);
            this.femaleradiobtn.TabIndex = 75;
            this.femaleradiobtn.Text = "Female";
            this.femaleradiobtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.femaleradiobtn.UncheckedState.BorderThickness = 2;
            this.femaleradiobtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.femaleradiobtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.femaleradiobtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 28);
            this.label11.TabIndex = 74;
            this.label11.Text = "Sex";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 29);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // GroupLabel
            // 
            this.GroupLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLabel.ForeColor = System.Drawing.Color.White;
            this.GroupLabel.Location = new System.Drawing.Point(154, 335);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(229, 28);
            this.GroupLabel.TabIndex = 72;
            this.GroupLabel.Text = "......";
            this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 71;
            this.label8.Text = "Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "Date Of Birth";
            // 
            // phonetxtbx
            // 
            this.phonetxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxtbx.Location = new System.Drawing.Point(154, 221);
            this.phonetxtbx.Name = "phonetxtbx";
            this.phonetxtbx.Size = new System.Drawing.Size(232, 29);
            this.phonetxtbx.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 64;
            this.label7.Text = "Phone";
            // 
            // passwordtxtbx
            // 
            this.passwordtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtbx.Location = new System.Drawing.Point(154, 181);
            this.passwordtxtbx.Name = "passwordtxtbx";
            this.passwordtxtbx.Size = new System.Drawing.Size(232, 29);
            this.passwordtxtbx.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password";
            // 
            // emailtxtbx
            // 
            this.emailtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtbx.Location = new System.Drawing.Point(154, 142);
            this.emailtxtbx.Name = "emailtxtbx";
            this.emailtxtbx.Size = new System.Drawing.Size(232, 29);
            this.emailtxtbx.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 60;
            this.label4.Text = "Email";
            // 
            // Lastnametxtbx
            // 
            this.Lastnametxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastnametxtbx.Location = new System.Drawing.Point(154, 103);
            this.Lastnametxtbx.Name = "Lastnametxtbx";
            this.Lastnametxtbx.Size = new System.Drawing.Size(232, 29);
            this.Lastnametxtbx.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Last Name";
            // 
            // Firstnametxtbx
            // 
            this.Firstnametxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnametxtbx.Location = new System.Drawing.Point(153, 64);
            this.Firstnametxtbx.Name = "Firstnametxtbx";
            this.Firstnametxtbx.Size = new System.Drawing.Size(232, 29);
            this.Firstnametxtbx.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "First Name";
            // 
            // idtxtbx
            // 
            this.idtxtbx.Enabled = false;
            this.idtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxtbx.Location = new System.Drawing.Point(153, 25);
            this.idtxtbx.Name = "idtxtbx";
            this.idtxtbx.Size = new System.Drawing.Size(232, 29);
            this.idtxtbx.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 28);
            this.label10.TabIndex = 54;
            this.label10.Text = "Id";
            // 
            // ClearBtn
            // 
            this.ClearBtn.AutoRoundedCorners = true;
            this.ClearBtn.BorderRadius = 23;
            this.ClearBtn.CheckedState.Parent = this.ClearBtn;
            this.ClearBtn.CustomImages.Parent = this.ClearBtn;
            this.ClearBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.HoverState.Parent = this.ClearBtn;
            this.ClearBtn.Location = new System.Drawing.Point(276, 120);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(119, 48);
            this.ClearBtn.TabIndex = 95;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SectionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SectionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.SectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SectionComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.SectionComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Location = new System.Drawing.Point(96, 13);
            this.SectionComboBox.MaxDropDownItems = 15;
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(299, 36);
            this.SectionComboBox.TabIndex = 96;
            this.SectionComboBox.SelectedIndexChanged += new System.EventHandler(this.SectionComboBox_SelectedIndexChanged);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GroupComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.GroupComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(500, 13);
            this.GroupComboBox.MaxDropDownItems = 15;
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(299, 36);
            this.GroupComboBox.TabIndex = 97;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // StudentdpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(976, 548);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ShowSectionGroupBx);
            this.Controls.Add(this.AbsenceBtn);
            this.Controls.Add(this.ShowAllStudent);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.UpdateStudent);
            this.Controls.Add(this.FindStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentdpForm";
            this.Text = "StudentdpForm";
            this.Load += new System.EventHandler(this.StudentdpForm_Load);
            this.Shown += new System.EventHandler(this.StudentdpForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.ShowSectionGroupBx.ResumeLayout(false);
            this.ShowSectionGroupBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView StudentDataGridView;
        private Guna.UI2.WinForms.Guna2Button AbsenceBtn;
        private Guna.UI2.WinForms.Guna2Button ShowAllStudent;
        private Guna.UI2.WinForms.Guna2Button DeleteStudent;
        private Guna.UI2.WinForms.Guna2Button UpdateStudent;
        private Guna.UI2.WinForms.Guna2Button FindStudent;
        private Guna.UI2.WinForms.Guna2Button AddStudent;
        private System.Windows.Forms.GroupBox ShowSectionGroupBx;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phonetxtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwordtxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lastnametxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Firstnametxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtxtbx;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2RadioButton maleradiobtn;
        private Guna.UI2.WinForms.Guna2RadioButton femaleradiobtn;
        private System.Windows.Forms.Label label11;
    }
}