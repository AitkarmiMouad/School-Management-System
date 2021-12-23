using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace School_Management_System
{
    class UIstyle
    {
        public void selectedTextBox(TextBox txtbx,PictureBox picturebx)
        {
            if (txtbx.Focused && txtbx.Text=="")
            {
                picturebx.BackColor = System.Drawing.Color.White;
            }
            else
            {
                picturebx.BackColor = System.Drawing.Color.Silver;
            }
        }
        public void enterKey(TextBox NextTxtbx, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                NextTxtbx.Focus();
                NextTxtbx.Select();
            }
        }

        public bool txtChanged(TextBox txtbx, PictureBox picturebx,string pattern,ErrorProvider ep,string errorprovidermsg)
        {
            ep.Clear();
            Regex reg = new Regex(pattern);
            string str = txtbx.Text;
            if (str == "")
            {
                picturebx.BackColor = System.Drawing.Color.Silver;
                return false;
            }
            else if (reg.IsMatch(str))
            {
                picturebx.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
                return true;
            }
            else
            {
                ep.SetError(txtbx, errorprovidermsg);
                picturebx.BackColor = System.Drawing.Color.IndianRed;
                return false;
            }
        }

        public void labelColorEffect(Label l,Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is Label)
                {
                    c.BackColor=System.Drawing.Color.FromArgb(49, 49, 66);
                }
            }
            l.BackColor= System.Drawing.Color.FromArgb(40, 40, 54);
        }
        public void dropdownItems(bool b,Label[] labels)
        {
            foreach(Label l in labels){
                l.Visible = b;
            }
        }
        
        public void openFormInPanel(Form f,Panel p)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);
            p.Tag = f;
            f.BringToFront();
            f.Show();
        }


    }
}
