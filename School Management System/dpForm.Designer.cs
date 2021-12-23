
namespace School_Management_System
{
    partial class directeurpedaghForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Accountlblpanel = new System.Windows.Forms.Panel();
            this.accountLblButton = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.classlblButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.managePanel = new System.Windows.Forms.Panel();
            this.sectionLblButton = new System.Windows.Forms.Label();
            this.studentlblButton = new System.Windows.Forms.Label();
            this.teacherLblButton = new System.Windows.Forms.Label();
            this.manageLblButton = new System.Windows.Forms.Label();
            this.dashboardLblButton = new System.Windows.Forms.Label();
            this.fullNamelbl = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Accountlblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.managePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.Accountlblpanel);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.fullNamelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 584);
            this.panel1.TabIndex = 0;
            // 
            // Accountlblpanel
            // 
            this.Accountlblpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Accountlblpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.Accountlblpanel.Controls.Add(this.accountLblButton);
            this.Accountlblpanel.Location = new System.Drawing.Point(0, 512);
            this.Accountlblpanel.Name = "Accountlblpanel";
            this.Accountlblpanel.Size = new System.Drawing.Size(244, 52);
            this.Accountlblpanel.TabIndex = 41;
            // 
            // accountLblButton
            // 
            this.accountLblButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.accountLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.accountLblButton.ForeColor = System.Drawing.Color.White;
            this.accountLblButton.Location = new System.Drawing.Point(0, 0);
            this.accountLblButton.Name = "accountLblButton";
            this.accountLblButton.Size = new System.Drawing.Size(244, 45);
            this.accountLblButton.TabIndex = 38;
            this.accountLblButton.Text = "Account";
            this.accountLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountLblButton.Click += new System.EventHandler(this.accountLblButton_Click);
            this.accountLblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.accountLblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::School_Management_System.Properties.Resources.user_person_people_6100;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(93, 23);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(59, 52);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.classlblButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.managePanel);
            this.panel3.Controls.Add(this.manageLblButton);
            this.panel3.Controls.Add(this.dashboardLblButton);
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 320);
            this.panel3.TabIndex = 36;
            // 
            // classlblButton
            // 
            this.classlblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.classlblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classlblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.classlblButton.ForeColor = System.Drawing.Color.White;
            this.classlblButton.Location = new System.Drawing.Point(0, 52);
            this.classlblButton.Name = "classlblButton";
            this.classlblButton.Size = new System.Drawing.Size(244, 45);
            this.classlblButton.TabIndex = 41;
            this.classlblButton.Text = "Class";
            this.classlblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.classlblButton.Click += new System.EventHandler(this.classlblButton_Click);
            this.classlblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.classlblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "v";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managePanel
            // 
            this.managePanel.Controls.Add(this.sectionLblButton);
            this.managePanel.Controls.Add(this.studentlblButton);
            this.managePanel.Controls.Add(this.teacherLblButton);
            this.managePanel.Location = new System.Drawing.Point(0, 148);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(244, 139);
            this.managePanel.TabIndex = 36;
            this.managePanel.Visible = false;
            // 
            // sectionLblButton
            // 
            this.sectionLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.sectionLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sectionLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sectionLblButton.ForeColor = System.Drawing.Color.White;
            this.sectionLblButton.Location = new System.Drawing.Point(0, 0);
            this.sectionLblButton.Name = "sectionLblButton";
            this.sectionLblButton.Size = new System.Drawing.Size(244, 45);
            this.sectionLblButton.TabIndex = 34;
            this.sectionLblButton.Text = "Sections";
            this.sectionLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sectionLblButton.Click += new System.EventHandler(this.sectionLblButton_Click);
            this.sectionLblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.sectionLblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // studentlblButton
            // 
            this.studentlblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.studentlblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentlblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.studentlblButton.ForeColor = System.Drawing.Color.White;
            this.studentlblButton.Location = new System.Drawing.Point(0, 90);
            this.studentlblButton.Name = "studentlblButton";
            this.studentlblButton.Size = new System.Drawing.Size(244, 45);
            this.studentlblButton.TabIndex = 33;
            this.studentlblButton.Text = "Students";
            this.studentlblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentlblButton.Click += new System.EventHandler(this.studentlblButton_Click);
            this.studentlblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.studentlblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // teacherLblButton
            // 
            this.teacherLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.teacherLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacherLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.teacherLblButton.ForeColor = System.Drawing.Color.White;
            this.teacherLblButton.Location = new System.Drawing.Point(0, 45);
            this.teacherLblButton.Name = "teacherLblButton";
            this.teacherLblButton.Size = new System.Drawing.Size(244, 45);
            this.teacherLblButton.TabIndex = 32;
            this.teacherLblButton.Text = "Teachers";
            this.teacherLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teacherLblButton.Click += new System.EventHandler(this.teacherLblButton_Click);
            this.teacherLblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.teacherLblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // manageLblButton
            // 
            this.manageLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.manageLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.manageLblButton.ForeColor = System.Drawing.Color.White;
            this.manageLblButton.Location = new System.Drawing.Point(0, 102);
            this.manageLblButton.Name = "manageLblButton";
            this.manageLblButton.Size = new System.Drawing.Size(244, 45);
            this.manageLblButton.TabIndex = 29;
            this.manageLblButton.Text = "Manage";
            this.manageLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageLblButton.Click += new System.EventHandler(this.manageLblButton_Click);
            this.manageLblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.manageLblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // dashboardLblButton
            // 
            this.dashboardLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.dashboardLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dashboardLblButton.ForeColor = System.Drawing.Color.White;
            this.dashboardLblButton.Location = new System.Drawing.Point(0, 2);
            this.dashboardLblButton.Name = "dashboardLblButton";
            this.dashboardLblButton.Size = new System.Drawing.Size(244, 45);
            this.dashboardLblButton.TabIndex = 37;
            this.dashboardLblButton.Text = "Dashboard";
            this.dashboardLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardLblButton.Click += new System.EventHandler(this.dashboardLblButton_Click);
            this.dashboardLblButton.MouseLeave += new System.EventHandler(this.dashboardLblButton_MouseLeave);
            this.dashboardLblButton.MouseHover += new System.EventHandler(this.dashboardLblButton_MouseHover);
            // 
            // fullNamelbl
            // 
            this.fullNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.fullNamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fullNamelbl.Location = new System.Drawing.Point(9, 87);
            this.fullNamelbl.Name = "fullNamelbl";
            this.fullNamelbl.Size = new System.Drawing.Size(229, 52);
            this.fullNamelbl.TabIndex = 1;
            this.fullNamelbl.Text = "Admin \r\nEducational Director";
            this.fullNamelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.controlPanel;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.guna2ControlBox1);
            this.controlPanel.Controls.Add(this.guna2ControlBox3);
            this.controlPanel.Controls.Add(this.guna2ControlBox4);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(244, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(976, 35);
            this.controlPanel.TabIndex = 25;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(877, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 25;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(826, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 24;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox4.HoverState.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(928, 3);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 2;
            // 
            // panelShowForm
            // 
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(244, 35);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(976, 549);
            this.panelShowForm.TabIndex = 26;
            // 
            // directeurpedaghForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1220, 584);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "directeurpedaghForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My School";
            this.Load += new System.EventHandler(this.directeurpedaghForm_Load);
            this.panel1.ResumeLayout(false);
            this.Accountlblpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fullNamelbl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.Label sectionLblButton;
        private System.Windows.Forms.Label studentlblButton;
        private System.Windows.Forms.Label teacherLblButton;
        private System.Windows.Forms.Label manageLblButton;
        private System.Windows.Forms.Label accountLblButton;
        private System.Windows.Forms.Label dashboardLblButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel controlPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private System.Windows.Forms.Panel panelShowForm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel Accountlblpanel;
        private System.Windows.Forms.Label classlblButton;
    }
}