
namespace School_Management_System
{
    partial class classShedule
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teacherGroup = new System.Windows.Forms.GroupBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherSalle = new System.Windows.Forms.GroupBox();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.classRoomComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RefreshAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addClassButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.teacherGroup.SuspendLayout();
            this.teacherSalle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(500, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last Name";
            // 
            // teacherGroup
            // 
            this.teacherGroup.Controls.Add(this.firstNameComboBox);
            this.teacherGroup.Controls.Add(this.lastNameComboBox);
            this.teacherGroup.Controls.Add(this.label6);
            this.teacherGroup.Controls.Add(this.label7);
            this.teacherGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGroup.ForeColor = System.Drawing.Color.White;
            this.teacherGroup.Location = new System.Drawing.Point(0, 0);
            this.teacherGroup.Name = "teacherGroup";
            this.teacherGroup.Size = new System.Drawing.Size(952, 100);
            this.teacherGroup.TabIndex = 15;
            this.teacherGroup.TabStop = false;
            this.teacherGroup.Text = "Teacher";
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firstNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.firstNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstNameComboBox.Enabled = false;
            this.firstNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstNameComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.firstNameComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(648, 40);
            this.firstNameComboBox.MaxDropDownItems = 15;
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(271, 36);
            this.firstNameComboBox.TabIndex = 53;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lastNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lastNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.lastNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lastNameComboBox.Enabled = false;
            this.lastNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastNameComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.lastNameComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(184, 40);
            this.lastNameComboBox.MaxDropDownItems = 15;
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(271, 36);
            this.lastNameComboBox.TabIndex = 52;
            this.lastNameComboBox.SelectedIndexChanged += new System.EventHandler(this.lastNameComboBox_SelectedIndexChanged);
            // 
            // teacherSalle
            // 
            this.teacherSalle.Controls.Add(this.FromComboBox);
            this.teacherSalle.Controls.Add(this.ToComboBox);
            this.teacherSalle.Controls.Add(this.classRoomComboBox);
            this.teacherSalle.Controls.Add(this.groupComboBox);
            this.teacherSalle.Controls.Add(this.sectionComboBox);
            this.teacherSalle.Controls.Add(this.label8);
            this.teacherSalle.Controls.Add(this.RefreshAllButton);
            this.teacherSalle.Controls.Add(this.label2);
            this.teacherSalle.Controls.Add(this.Datepicker);
            this.teacherSalle.Controls.Add(this.label5);
            this.teacherSalle.Controls.Add(this.label4);
            this.teacherSalle.Controls.Add(this.label3);
            this.teacherSalle.Controls.Add(this.label1);
            this.teacherSalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSalle.ForeColor = System.Drawing.Color.White;
            this.teacherSalle.Location = new System.Drawing.Point(0, 0);
            this.teacherSalle.Name = "teacherSalle";
            this.teacherSalle.Size = new System.Drawing.Size(952, 272);
            this.teacherSalle.TabIndex = 16;
            this.teacherSalle.TabStop = false;
            this.teacherSalle.Text = "Salle";
            // 
            // FromComboBox
            // 
            this.FromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.FromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromComboBox.Enabled = false;
            this.FromComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.FromComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(184, 199);
            this.FromComboBox.MaxDropDownItems = 15;
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(186, 36);
            this.FromComboBox.TabIndex = 51;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ToComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToComboBox.Enabled = false;
            this.ToComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.ToComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(496, 199);
            this.ToComboBox.MaxDropDownItems = 15;
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(187, 36);
            this.ToComboBox.TabIndex = 50;
            // 
            // classRoomComboBox
            // 
            this.classRoomComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classRoomComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classRoomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.classRoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classRoomComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classRoomComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.classRoomComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.classRoomComboBox.FormattingEnabled = true;
            this.classRoomComboBox.Location = new System.Drawing.Point(184, 144);
            this.classRoomComboBox.MaxDropDownItems = 15;
            this.classRoomComboBox.Name = "classRoomComboBox";
            this.classRoomComboBox.Size = new System.Drawing.Size(499, 36);
            this.classRoomComboBox.TabIndex = 49;
            this.classRoomComboBox.SelectedIndexChanged += new System.EventHandler(this.classRoomComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.groupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.Enabled = false;
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.groupComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(496, 90);
            this.groupComboBox.MaxDropDownItems = 15;
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(187, 36);
            this.groupComboBox.TabIndex = 48;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sectionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sectionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.sectionComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(184, 90);
            this.sectionComboBox.MaxDropDownItems = 15;
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(186, 36);
            this.sectionComboBox.TabIndex = 16;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(95, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "Section";
            // 
            // RefreshAllButton
            // 
            this.RefreshAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshAllButton.AutoRoundedCorners = true;
            this.RefreshAllButton.BorderRadius = 29;
            this.RefreshAllButton.CheckedState.Parent = this.RefreshAllButton;
            this.RefreshAllButton.CustomImages.Parent = this.RefreshAllButton;
            this.RefreshAllButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RefreshAllButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.RefreshAllButton.HoverState.Parent = this.RefreshAllButton;
            this.RefreshAllButton.Location = new System.Drawing.Point(767, 30);
            this.RefreshAllButton.Name = "RefreshAllButton";
            this.RefreshAllButton.ShadowDecoration.Parent = this.RefreshAllButton;
            this.RefreshAllButton.Size = new System.Drawing.Size(167, 61);
            this.RefreshAllButton.TabIndex = 46;
            this.RefreshAllButton.Text = "Refresh All ClassRooms";
            this.RefreshAllButton.Click += new System.EventHandler(this.RefreshAllButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Group";
            // 
            // Datepicker
            // 
            this.Datepicker.BorderColor = System.Drawing.Color.White;
            this.Datepicker.BorderThickness = 1;
            this.Datepicker.CheckedState.Parent = this.Datepicker;
            this.Datepicker.CustomFormat = "dd/MM/yyyy";
            this.Datepicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.Datepicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datepicker.HoverState.Parent = this.Datepicker;
            this.Datepicker.Location = new System.Drawing.Point(184, 37);
            this.Datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Datepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.ShadowDecoration.Parent = this.Datepicker;
            this.Datepicker.Size = new System.Drawing.Size(499, 36);
            this.Datepicker.TabIndex = 20;
            this.Datepicker.Value = new System.DateTime(2021, 4, 19, 0, 26, 20, 670);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(413, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "ClassRoom_ID";
            // 
            // addClassButton
            // 
            this.addClassButton.AutoRoundedCorners = true;
            this.addClassButton.BorderRadius = 23;
            this.addClassButton.CheckedState.Parent = this.addClassButton;
            this.addClassButton.CustomImages.Parent = this.addClassButton;
            this.addClassButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClassButton.ForeColor = System.Drawing.Color.White;
            this.addClassButton.HoverState.Parent = this.addClassButton;
            this.addClassButton.Location = new System.Drawing.Point(12, 408);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.ShadowDecoration.Parent = this.addClassButton;
            this.addClassButton.Size = new System.Drawing.Size(178, 48);
            this.addClassButton.TabIndex = 45;
            this.addClassButton.Text = "Add";
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.teacherSalle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 272);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.teacherGroup);
            this.panel2.Location = new System.Drawing.Point(12, 290);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 100);
            this.panel2.TabIndex = 47;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 462);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(178, 54);
            this.guna2Button1.TabIndex = 48;
            this.guna2Button1.Text = "Add For 2 Weeks";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // classShedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addClassButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "classShedule";
            this.Text = "classShedule";
            this.Load += new System.EventHandler(this.classShedule_Load);
            this.teacherGroup.ResumeLayout(false);
            this.teacherGroup.PerformLayout();
            this.teacherSalle.ResumeLayout(false);
            this.teacherSalle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox teacherGroup;
        private System.Windows.Forms.GroupBox teacherSalle;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker Datepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button addClassButton;
        private Guna.UI2.WinForms.Guna2Button RefreshAllButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.ComboBox classRoomComboBox;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}