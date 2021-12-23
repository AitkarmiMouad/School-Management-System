
namespace School_Management_System
{
    partial class TeachersdpForm
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
            this.AddGroupTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.ShowSectionGroupBx = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.maleradiobtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.femaleradiobtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Emailtxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNametxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNametxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Idtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.FindTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.AddTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showAllBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ShowSectionGroupBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddGroupTeacher
            // 
            this.AddGroupTeacher.AutoRoundedCorners = true;
            this.AddGroupTeacher.BorderRadius = 23;
            this.AddGroupTeacher.CheckedState.Parent = this.AddGroupTeacher;
            this.AddGroupTeacher.CustomImages.Parent = this.AddGroupTeacher;
            this.AddGroupTeacher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddGroupTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGroupTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.AddGroupTeacher.HoverState.Parent = this.AddGroupTeacher;
            this.AddGroupTeacher.Location = new System.Drawing.Point(143, 73);
            this.AddGroupTeacher.Name = "AddGroupTeacher";
            this.AddGroupTeacher.ShadowDecoration.Parent = this.AddGroupTeacher;
            this.AddGroupTeacher.Size = new System.Drawing.Size(119, 48);
            this.AddGroupTeacher.TabIndex = 85;
            this.AddGroupTeacher.Text = "Group";
            this.AddGroupTeacher.Click += new System.EventHandler(this.AddGroupTeacher_Click);
            // 
            // ShowSectionGroupBx
            // 
            this.ShowSectionGroupBx.Controls.Add(this.dateTimePicker1);
            this.ShowSectionGroupBx.Controls.Add(this.label9);
            this.ShowSectionGroupBx.Controls.Add(this.maleradiobtn);
            this.ShowSectionGroupBx.Controls.Add(this.femaleradiobtn);
            this.ShowSectionGroupBx.Controls.Add(this.label8);
            this.ShowSectionGroupBx.Controls.Add(this.phone);
            this.ShowSectionGroupBx.Controls.Add(this.label7);
            this.ShowSectionGroupBx.Controls.Add(this.password);
            this.ShowSectionGroupBx.Controls.Add(this.label5);
            this.ShowSectionGroupBx.Controls.Add(this.Emailtxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label4);
            this.ShowSectionGroupBx.Controls.Add(this.LastNametxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label3);
            this.ShowSectionGroupBx.Controls.Add(this.FirstNametxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label2);
            this.ShowSectionGroupBx.Controls.Add(this.Idtxtbx);
            this.ShowSectionGroupBx.Controls.Add(this.label1);
            this.ShowSectionGroupBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ShowSectionGroupBx.ForeColor = System.Drawing.Color.White;
            this.ShowSectionGroupBx.Location = new System.Drawing.Point(10, 127);
            this.ShowSectionGroupBx.Name = "ShowSectionGroupBx";
            this.ShowSectionGroupBx.Size = new System.Drawing.Size(392, 410);
            this.ShowSectionGroupBx.TabIndex = 84;
            this.ShowSectionGroupBx.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 29);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "Date Of Birth";
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
            this.maleradiobtn.Location = new System.Drawing.Point(171, 309);
            this.maleradiobtn.Name = "maleradiobtn";
            this.maleradiobtn.Size = new System.Drawing.Size(78, 32);
            this.maleradiobtn.TabIndex = 68;
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
            this.femaleradiobtn.Location = new System.Drawing.Point(286, 309);
            this.femaleradiobtn.Name = "femaleradiobtn";
            this.femaleradiobtn.Size = new System.Drawing.Size(100, 32);
            this.femaleradiobtn.TabIndex = 67;
            this.femaleradiobtn.Text = "Female";
            this.femaleradiobtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.femaleradiobtn.UncheckedState.BorderThickness = 2;
            this.femaleradiobtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.femaleradiobtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.femaleradiobtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 28);
            this.label8.TabIndex = 66;
            this.label8.Text = "Sex";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(155, 264);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(232, 29);
            this.phone.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 64;
            this.label7.Text = "Phone";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(155, 216);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 29);
            this.password.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password";
            // 
            // Emailtxtbx
            // 
            this.Emailtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxtbx.Location = new System.Drawing.Point(155, 169);
            this.Emailtxtbx.Name = "Emailtxtbx";
            this.Emailtxtbx.Size = new System.Drawing.Size(232, 29);
            this.Emailtxtbx.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 60;
            this.label4.Text = "Email";
            // 
            // LastNametxtbx
            // 
            this.LastNametxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNametxtbx.Location = new System.Drawing.Point(155, 121);
            this.LastNametxtbx.Name = "LastNametxtbx";
            this.LastNametxtbx.Size = new System.Drawing.Size(232, 29);
            this.LastNametxtbx.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Last Name";
            // 
            // FirstNametxtbx
            // 
            this.FirstNametxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNametxtbx.Location = new System.Drawing.Point(154, 74);
            this.FirstNametxtbx.Name = "FirstNametxtbx";
            this.FirstNametxtbx.Size = new System.Drawing.Size(232, 29);
            this.FirstNametxtbx.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "First Name";
            // 
            // Idtxtbx
            // 
            this.Idtxtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxtbx.Location = new System.Drawing.Point(154, 26);
            this.Idtxtbx.Name = "Idtxtbx";
            this.Idtxtbx.ReadOnly = true;
            this.Idtxtbx.Size = new System.Drawing.Size(232, 29);
            this.Idtxtbx.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Id";
            // 
            // DeleteTeacher
            // 
            this.DeleteTeacher.AutoRoundedCorners = true;
            this.DeleteTeacher.BorderRadius = 23;
            this.DeleteTeacher.CheckedState.Parent = this.DeleteTeacher;
            this.DeleteTeacher.CustomImages.Parent = this.DeleteTeacher;
            this.DeleteTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.DeleteTeacher.HoverState.Parent = this.DeleteTeacher;
            this.DeleteTeacher.Location = new System.Drawing.Point(10, 73);
            this.DeleteTeacher.Name = "DeleteTeacher";
            this.DeleteTeacher.ShadowDecoration.Parent = this.DeleteTeacher;
            this.DeleteTeacher.Size = new System.Drawing.Size(119, 48);
            this.DeleteTeacher.TabIndex = 80;
            this.DeleteTeacher.Text = "Delete";
            this.DeleteTeacher.Click += new System.EventHandler(this.DeleteTeacher_Click);
            // 
            // UpdateTeacher
            // 
            this.UpdateTeacher.AutoRoundedCorners = true;
            this.UpdateTeacher.BorderRadius = 23;
            this.UpdateTeacher.CheckedState.Parent = this.UpdateTeacher;
            this.UpdateTeacher.CustomImages.Parent = this.UpdateTeacher;
            this.UpdateTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTeacher.ForeColor = System.Drawing.Color.White;
            this.UpdateTeacher.HoverState.Parent = this.UpdateTeacher;
            this.UpdateTeacher.Location = new System.Drawing.Point(274, 13);
            this.UpdateTeacher.Name = "UpdateTeacher";
            this.UpdateTeacher.ShadowDecoration.Parent = this.UpdateTeacher;
            this.UpdateTeacher.Size = new System.Drawing.Size(119, 48);
            this.UpdateTeacher.TabIndex = 79;
            this.UpdateTeacher.Text = "Update";
            this.UpdateTeacher.Click += new System.EventHandler(this.UpdateTeacher_Click);
            // 
            // FindTeacher
            // 
            this.FindTeacher.AutoRoundedCorners = true;
            this.FindTeacher.BorderRadius = 23;
            this.FindTeacher.CheckedState.Parent = this.FindTeacher;
            this.FindTeacher.CustomImages.Parent = this.FindTeacher;
            this.FindTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindTeacher.ForeColor = System.Drawing.Color.White;
            this.FindTeacher.HoverState.Parent = this.FindTeacher;
            this.FindTeacher.Location = new System.Drawing.Point(143, 13);
            this.FindTeacher.Name = "FindTeacher";
            this.FindTeacher.ShadowDecoration.Parent = this.FindTeacher;
            this.FindTeacher.Size = new System.Drawing.Size(119, 48);
            this.FindTeacher.TabIndex = 78;
            this.FindTeacher.Text = "Find";
            this.FindTeacher.Click += new System.EventHandler(this.FindTeacher_Click);
            // 
            // AddTeacher
            // 
            this.AddTeacher.AutoRoundedCorners = true;
            this.AddTeacher.BorderRadius = 23;
            this.AddTeacher.CheckedState.Parent = this.AddTeacher;
            this.AddTeacher.CustomImages.Parent = this.AddTeacher;
            this.AddTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacher.ForeColor = System.Drawing.Color.White;
            this.AddTeacher.HoverState.Parent = this.AddTeacher;
            this.AddTeacher.Location = new System.Drawing.Point(10, 13);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.ShadowDecoration.Parent = this.AddTeacher;
            this.AddTeacher.Size = new System.Drawing.Size(119, 48);
            this.AddTeacher.TabIndex = 77;
            this.AddTeacher.Text = "Add";
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(423, 67);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(541, 470);
            this.guna2DataGridView1.TabIndex = 76;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.SelectionChanged += new System.EventHandler(this.guna2DataGridView1_SelectionChanged);
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
            this.ClearBtn.Location = new System.Drawing.Point(274, 73);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(119, 48);
            this.ClearBtn.TabIndex = 86;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllBtn.AutoRoundedCorners = true;
            this.showAllBtn.BorderRadius = 23;
            this.showAllBtn.CheckedState.Parent = this.showAllBtn;
            this.showAllBtn.CustomImages.Parent = this.showAllBtn;
            this.showAllBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.showAllBtn.HoverState.Parent = this.showAllBtn;
            this.showAllBtn.Location = new System.Drawing.Point(845, 12);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.ShadowDecoration.Parent = this.showAllBtn;
            this.showAllBtn.Size = new System.Drawing.Size(119, 48);
            this.showAllBtn.TabIndex = 87;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // TeachersdpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddGroupTeacher);
            this.Controls.Add(this.ShowSectionGroupBx);
            this.Controls.Add(this.DeleteTeacher);
            this.Controls.Add(this.UpdateTeacher);
            this.Controls.Add(this.FindTeacher);
            this.Controls.Add(this.AddTeacher);
            this.Controls.Add(this.guna2DataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeachersdpForm";
            this.Text = "TeachersdpForm";
            this.Load += new System.EventHandler(this.TeachersdpForm_Load);
            this.ShowSectionGroupBx.ResumeLayout(false);
            this.ShowSectionGroupBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddGroupTeacher;
        private System.Windows.Forms.GroupBox ShowSectionGroupBx;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2RadioButton maleradiobtn;
        private Guna.UI2.WinForms.Guna2RadioButton femaleradiobtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Emailtxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNametxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNametxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Idtxtbx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button DeleteTeacher;
        private Guna.UI2.WinForms.Guna2Button UpdateTeacher;
        private Guna.UI2.WinForms.Guna2Button FindTeacher;
        private Guna.UI2.WinForms.Guna2Button AddTeacher;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button showAllBtn;
    }
}