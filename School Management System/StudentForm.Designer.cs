
namespace School_Management_System
{
    partial class StudentForm
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
            this.gradeslblBtn = new System.Windows.Forms.Label();
            this.scheduleLblBtn = new System.Windows.Forms.Label();
            this.fullNamelbl = new System.Windows.Forms.Label();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.Accountlblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(244, 545);
            this.panel1.TabIndex = 1;
            // 
            // Accountlblpanel
            // 
            this.Accountlblpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Accountlblpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.Accountlblpanel.Controls.Add(this.accountLblButton);
            this.Accountlblpanel.Location = new System.Drawing.Point(0, 473);
            this.Accountlblpanel.Name = "Accountlblpanel";
            this.Accountlblpanel.Size = new System.Drawing.Size(244, 52);
            this.Accountlblpanel.TabIndex = 41;
            // 
            // accountLblButton
            // 
            this.accountLblButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountLblButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.accountLblButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.accountLblButton.ForeColor = System.Drawing.Color.White;
            this.accountLblButton.Location = new System.Drawing.Point(0, 0);
            this.accountLblButton.Name = "accountLblButton";
            this.accountLblButton.Size = new System.Drawing.Size(244, 45);
            this.accountLblButton.TabIndex = 38;
            this.accountLblButton.Text = "Account";
            this.accountLblButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountLblButton.Click += new System.EventHandler(this.accountLblButton_Click);
            this.accountLblButton.MouseLeave += new System.EventHandler(this.scheduleLblBtn_MouseLeave);
            this.accountLblButton.MouseHover += new System.EventHandler(this.scheduleLblBtn_MouseHover);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::School_Management_System.Properties.Resources.graduated;
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
            this.panel3.Controls.Add(this.gradeslblBtn);
            this.panel3.Controls.Add(this.scheduleLblBtn);
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 320);
            this.panel3.TabIndex = 36;
            // 
            // gradeslblBtn
            // 
            this.gradeslblBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.gradeslblBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gradeslblBtn.ForeColor = System.Drawing.Color.White;
            this.gradeslblBtn.Location = new System.Drawing.Point(0, 52);
            this.gradeslblBtn.Name = "gradeslblBtn";
            this.gradeslblBtn.Size = new System.Drawing.Size(244, 45);
            this.gradeslblBtn.TabIndex = 41;
            this.gradeslblBtn.Text = "Grades";
            this.gradeslblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradeslblBtn.Click += new System.EventHandler(this.gradeslblBtn_Click);
            this.gradeslblBtn.MouseLeave += new System.EventHandler(this.scheduleLblBtn_MouseLeave);
            this.gradeslblBtn.MouseHover += new System.EventHandler(this.scheduleLblBtn_MouseHover);
            // 
            // scheduleLblBtn
            // 
            this.scheduleLblBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.scheduleLblBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.scheduleLblBtn.ForeColor = System.Drawing.Color.White;
            this.scheduleLblBtn.Location = new System.Drawing.Point(0, 2);
            this.scheduleLblBtn.Name = "scheduleLblBtn";
            this.scheduleLblBtn.Size = new System.Drawing.Size(244, 45);
            this.scheduleLblBtn.TabIndex = 37;
            this.scheduleLblBtn.Text = "Schedule";
            this.scheduleLblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scheduleLblBtn.Click += new System.EventHandler(this.scheduleLblBtn_Click);
            this.scheduleLblBtn.MouseLeave += new System.EventHandler(this.scheduleLblBtn_MouseLeave);
            this.scheduleLblBtn.MouseHover += new System.EventHandler(this.scheduleLblBtn_MouseHover);
            // 
            // fullNamelbl
            // 
            this.fullNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.fullNamelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fullNamelbl.Location = new System.Drawing.Point(9, 87);
            this.fullNamelbl.Name = "fullNamelbl";
            this.fullNamelbl.Size = new System.Drawing.Size(229, 66);
            this.fullNamelbl.TabIndex = 1;
            this.fullNamelbl.Text = "Full Name\r\nSection/Group\r\nStudent";
            this.fullNamelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelShowForm
            // 
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(244, 35);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(960, 510);
            this.panelShowForm.TabIndex = 28;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.guna2ControlBox1);
            this.controlPanel.Controls.Add(this.guna2ControlBox3);
            this.controlPanel.Controls.Add(this.guna2ControlBox4);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(244, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(960, 35);
            this.controlPanel.TabIndex = 27;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(861, 3);
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(810, 3);
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
            this.guna2ControlBox4.Location = new System.Drawing.Point(912, 3);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.controlPanel;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1204, 545);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.Accountlblpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Accountlblpanel;
        private System.Windows.Forms.Label accountLblButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label gradeslblBtn;
        private System.Windows.Forms.Label scheduleLblBtn;
        private System.Windows.Forms.Label fullNamelbl;
        private System.Windows.Forms.Panel panelShowForm;
        private System.Windows.Forms.Panel controlPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}