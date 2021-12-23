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
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }
        public string findID=null;
        private void FindBtn_Click(object sender, EventArgs e)
        {
            findID = IdTextBox.Text;
            this.Close();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }
    }
}
