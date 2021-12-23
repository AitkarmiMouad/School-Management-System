
namespace School_Management_System
{
    partial class examteacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteExambtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addexambtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeComboBox = new System.Windows.Forms.ComboBox();
            this.showAllBtn = new Guna.UI2.WinForms.Guna2Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 85;
            this.label6.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 87;
            this.label1.Text = "Year";
            // 
            // TeacherDataGridView
            // 
            this.TeacherDataGridView.AllowUserToAddRows = false;
            this.TeacherDataGridView.AllowUserToDeleteRows = false;
            this.TeacherDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TeacherDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TeacherDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.TeacherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeacherDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeacherDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TeacherDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.TeacherDataGridView.EnableHeadersVisualStyles = false;
            this.TeacherDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherDataGridView.Location = new System.Drawing.Point(403, 12);
            this.TeacherDataGridView.Name = "TeacherDataGridView";
            this.TeacherDataGridView.ReadOnly = true;
            this.TeacherDataGridView.RowHeadersVisible = false;
            this.TeacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherDataGridView.Size = new System.Drawing.Size(561, 525);
            this.TeacherDataGridView.TabIndex = 89;
            this.TeacherDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.TeacherDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TeacherDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TeacherDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TeacherDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TeacherDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TeacherDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.TeacherDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeacherDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.TeacherDataGridView.ThemeStyle.ReadOnly = true;
            this.TeacherDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TeacherDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeacherDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TeacherDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TeacherDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TeacherDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DeleteExambtn
            // 
            this.DeleteExambtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteExambtn.AutoRoundedCorners = true;
            this.DeleteExambtn.BorderRadius = 23;
            this.DeleteExambtn.CheckedState.Parent = this.DeleteExambtn;
            this.DeleteExambtn.CustomImages.Parent = this.DeleteExambtn;
            this.DeleteExambtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteExambtn.ForeColor = System.Drawing.Color.White;
            this.DeleteExambtn.HoverState.Parent = this.DeleteExambtn;
            this.DeleteExambtn.Location = new System.Drawing.Point(141, 489);
            this.DeleteExambtn.Name = "DeleteExambtn";
            this.DeleteExambtn.ShadowDecoration.Parent = this.DeleteExambtn;
            this.DeleteExambtn.Size = new System.Drawing.Size(119, 48);
            this.DeleteExambtn.TabIndex = 93;
            this.DeleteExambtn.Text = "Delete";
            this.DeleteExambtn.Click += new System.EventHandler(this.DeleteExambtn_Click);
            // 
            // Addexambtn
            // 
            this.Addexambtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Addexambtn.AutoRoundedCorners = true;
            this.Addexambtn.BorderRadius = 23;
            this.Addexambtn.CheckedState.Parent = this.Addexambtn;
            this.Addexambtn.CustomImages.Parent = this.Addexambtn;
            this.Addexambtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addexambtn.ForeColor = System.Drawing.Color.White;
            this.Addexambtn.HoverState.Parent = this.Addexambtn;
            this.Addexambtn.Location = new System.Drawing.Point(16, 489);
            this.Addexambtn.Name = "Addexambtn";
            this.Addexambtn.ShadowDecoration.Parent = this.Addexambtn;
            this.Addexambtn.Size = new System.Drawing.Size(119, 48);
            this.Addexambtn.TabIndex = 92;
            this.Addexambtn.Text = "Add";
            this.Addexambtn.Click += new System.EventHandler(this.Addexambtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 94;
            this.label3.Text = "Name";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.nameTxtBx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBx.ForeColor = System.Drawing.Color.White;
            this.nameTxtBx.Location = new System.Drawing.Point(127, 183);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(235, 33);
            this.nameTxtBx.TabIndex = 95;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(376, 261);
            this.checkedListBox1.TabIndex = 96;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 261);
            this.panel1.TabIndex = 97;
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
            this.SectionComboBox.Location = new System.Drawing.Point(127, 13);
            this.SectionComboBox.MaxDropDownItems = 15;
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(235, 36);
            this.SectionComboBox.TabIndex = 97;
            this.SectionComboBox.SelectedIndexChanged += new System.EventHandler(this.SectionComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.groupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.groupComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(127, 55);
            this.groupComboBox.MaxDropDownItems = 15;
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(235, 36);
            this.groupComboBox.TabIndex = 98;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 99;
            this.label2.Text = "Range";
            // 
            // rangeComboBox
            // 
            this.rangeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rangeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rangeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.rangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rangeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rangeComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.rangeComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.rangeComboBox.FormattingEnabled = true;
            this.rangeComboBox.Items.AddRange(new object[] {
            "All",
            "Past Week",
            "This Week",
            "After This Week"});
            this.rangeComboBox.Location = new System.Drawing.Point(127, 139);
            this.rangeComboBox.MaxDropDownItems = 15;
            this.rangeComboBox.Name = "rangeComboBox";
            this.rangeComboBox.Size = new System.Drawing.Size(235, 36);
            this.rangeComboBox.TabIndex = 100;
            this.rangeComboBox.SelectedIndexChanged += new System.EventHandler(this.rangeComboBox_SelectedIndexChanged);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllBtn.AutoRoundedCorners = true;
            this.showAllBtn.BorderRadius = 23;
            this.showAllBtn.CheckedState.Parent = this.showAllBtn;
            this.showAllBtn.CustomImages.Parent = this.showAllBtn;
            this.showAllBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.showAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.showAllBtn.HoverState.Parent = this.showAllBtn;
            this.showAllBtn.Location = new System.Drawing.Point(278, 489);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.ShadowDecoration.Parent = this.showAllBtn;
            this.showAllBtn.Size = new System.Drawing.Size(119, 48);
            this.showAllBtn.TabIndex = 101;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subjectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subjectComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.subjectComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(127, 97);
            this.subjectComboBox.MaxDropDownItems = 15;
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(235, 36);
            this.subjectComboBox.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 108;
            this.label4.Text = "Subject";
            // 
            // examteacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.rangeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteExambtn);
            this.Controls.Add(this.Addexambtn);
            this.Controls.Add(this.TeacherDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "examteacherForm";
            this.Text = "examteacherForm";
            this.Load += new System.EventHandler(this.examteacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView TeacherDataGridView;
        private Guna.UI2.WinForms.Guna2Button DeleteExambtn;
        private Guna.UI2.WinForms.Guna2Button Addexambtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rangeComboBox;
        private Guna.UI2.WinForms.Guna2Button showAllBtn;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label4;
    }
}