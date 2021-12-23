
namespace School_Management_System
{
    partial class AbsenceStudent
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
            this.BtnAddAbsence = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAbsence = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AbsenceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AbsenceCountLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowAllBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AbsenceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddAbsence
            // 
            this.BtnAddAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAbsence.AutoRoundedCorners = true;
            this.BtnAddAbsence.BorderRadius = 23;
            this.BtnAddAbsence.CheckedState.Parent = this.BtnAddAbsence;
            this.BtnAddAbsence.CustomImages.Parent = this.BtnAddAbsence;
            this.BtnAddAbsence.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAbsence.ForeColor = System.Drawing.Color.White;
            this.BtnAddAbsence.HoverState.Parent = this.BtnAddAbsence;
            this.BtnAddAbsence.Location = new System.Drawing.Point(405, 12);
            this.BtnAddAbsence.Name = "BtnAddAbsence";
            this.BtnAddAbsence.ShadowDecoration.Parent = this.BtnAddAbsence;
            this.BtnAddAbsence.Size = new System.Drawing.Size(119, 48);
            this.BtnAddAbsence.TabIndex = 91;
            this.BtnAddAbsence.Text = "Add";
            this.BtnAddAbsence.Click += new System.EventHandler(this.BtnAddAbsence_Click);
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAbsence.AutoRoundedCorners = true;
            this.btnDeleteAbsence.BorderRadius = 23;
            this.btnDeleteAbsence.CheckedState.Parent = this.btnDeleteAbsence;
            this.btnDeleteAbsence.CustomImages.Parent = this.btnDeleteAbsence;
            this.btnDeleteAbsence.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAbsence.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAbsence.HoverState.Parent = this.btnDeleteAbsence;
            this.btnDeleteAbsence.Location = new System.Drawing.Point(530, 12);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.ShadowDecoration.Parent = this.btnDeleteAbsence;
            this.btnDeleteAbsence.Size = new System.Drawing.Size(119, 48);
            this.btnDeleteAbsence.TabIndex = 92;
            this.btnDeleteAbsence.Text = "Delete";
            this.btnDeleteAbsence.Click += new System.EventHandler(this.btnDeleteAbsence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 28);
            this.label6.TabIndex = 93;
            this.label6.Text = "Time";
            // 
            // AbsenceDataGridView
            // 
            this.AbsenceDataGridView.AllowUserToAddRows = false;
            this.AbsenceDataGridView.AllowUserToDeleteRows = false;
            this.AbsenceDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AbsenceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AbsenceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbsenceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbsenceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.AbsenceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AbsenceDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AbsenceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AbsenceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AbsenceDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AbsenceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AbsenceDataGridView.EnableHeadersVisualStyles = false;
            this.AbsenceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbsenceDataGridView.Location = new System.Drawing.Point(12, 159);
            this.AbsenceDataGridView.Name = "AbsenceDataGridView";
            this.AbsenceDataGridView.ReadOnly = true;
            this.AbsenceDataGridView.RowHeadersVisible = false;
            this.AbsenceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbsenceDataGridView.Size = new System.Drawing.Size(637, 315);
            this.AbsenceDataGridView.TabIndex = 95;
            this.AbsenceDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.AbsenceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AbsenceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AbsenceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AbsenceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AbsenceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AbsenceDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.AbsenceDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AbsenceDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.AbsenceDataGridView.ThemeStyle.ReadOnly = true;
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbsenceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AbsenceCountLabel
            // 
            this.AbsenceCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AbsenceCountLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsenceCountLabel.ForeColor = System.Drawing.Color.White;
            this.AbsenceCountLabel.Location = new System.Drawing.Point(420, 128);
            this.AbsenceCountLabel.Name = "AbsenceCountLabel";
            this.AbsenceCountLabel.Size = new System.Drawing.Size(229, 28);
            this.AbsenceCountLabel.TabIndex = 96;
            this.AbsenceCountLabel.Text = "......";
            this.AbsenceCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeComboBox
            // 
            this.timeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.timeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.timeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeComboBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.timeComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(104, 47);
            this.timeComboBox.MaxDropDownItems = 15;
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(283, 36);
            this.timeComboBox.TabIndex = 97;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 29);
            this.dateTimePicker1.TabIndex = 98;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Date";
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllBtn.AutoRoundedCorners = true;
            this.ShowAllBtn.BorderRadius = 23;
            this.ShowAllBtn.CheckedState.Parent = this.ShowAllBtn;
            this.ShowAllBtn.CustomImages.Parent = this.ShowAllBtn;
            this.ShowAllBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ShowAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ShowAllBtn.HoverState.Parent = this.ShowAllBtn;
            this.ShowAllBtn.Location = new System.Drawing.Point(530, 66);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.ShadowDecoration.Parent = this.ShowAllBtn;
            this.ShowAllBtn.Size = new System.Drawing.Size(119, 48);
            this.ShowAllBtn.TabIndex = 100;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // AbsenceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(661, 486);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.AbsenceCountLabel);
            this.Controls.Add(this.AbsenceDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeleteAbsence);
            this.Controls.Add(this.BtnAddAbsence);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbsenceStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absence Student";
            this.Load += new System.EventHandler(this.AbsenceStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbsenceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnAddAbsence;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAbsence;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView AbsenceDataGridView;
        private System.Windows.Forms.Label AbsenceCountLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ShowAllBtn;
    }
}