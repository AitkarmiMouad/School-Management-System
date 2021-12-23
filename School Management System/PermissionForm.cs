using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class PermissionForm : Form
    {
        public PermissionForm()
        {
            InitializeComponent();
        }
        int checkcount = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "admin")
            {
                SignupForm f = new SignupForm();
                f.Icon = this.Icon;

                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            else
            {
                checkcount--;
                messageLabel.Text = "invalid info , try again..\n" + checkcount + "attempt left";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (checkcount == 0)
            {
                LoginForm f = new LoginForm();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
        UIstyle style2 = new UIstyle();
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            style2.enterKey(textBox2, e);

        }
    }
}
