using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        UIstyle style2 = new UIstyle();
        bool CheckValidInfo = false;

        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);

        private void firstnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            style2.enterKey(lastnametxt, e);
        }

        private void lastnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            style2.enterKey(emailtxtbx, e);
        }

        private void emailtxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            style2.enterKey(passwordtxtbx, e);

        }

        private void passwordtxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            style2.enterKey(phonetxtbx, e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void firstnametxt_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo = style2.txtChanged(firstnametxt, firstnamepicturebx, "^[a-z]+$", errorProvider1, "only small characters allowed");
        }

        private void lastnametxt_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo = style2.txtChanged(lastnametxt, lastnamepicturebx, "^[a-z]+$", errorProvider1, "only small characters allowed");

        }

        private void emailtxtbx_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo = style2.txtChanged(emailtxtbx, emailpicturebx, @"^\w+([-_.]\w+)*$", errorProvider1, "only (characters , - , . , _) are allowed");

        }

        private void passwordtxtbx_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo = style2.txtChanged(passwordtxtbx, passwordpicturebx, @"^\w{6,}$", errorProvider1, "only characters and numbers allowed");

        }

        private void phonetxtbx_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo = style2.txtChanged(phonetxtbx, phonepicturebx, @"^\d{10}$", errorProvider1, "only numbers allowed (10 digits)");

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (CheckValidInfo == false)
            {
                messageLabel.Text = "invalid info\nplease try again...";
                messageLabel.Visible = true;
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand ExistedValue = new SqlCommand("select count(email) from DirecteurPedaghogique where email like @email", connection);
                    ExistedValue.Parameters.AddWithValue("@email", emailtxtbx.Text+".dp@gmail.com");
                    if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                    {
                        SqlCommand insertCommand = new SqlCommand("insert into DirecteurPedaghogique (email,motdepasse,nom,prenom,tel,sex,datedenaiss) values(@email,@motdepass,@nom,@prenom,@tel,@sex,@datedenaiss)",connection);
                        insertCommand.Parameters.AddWithValue("@email", emailtxtbx.Text + ".dp@gmail.com");
                        insertCommand.Parameters.AddWithValue("@motdepass", passwordtxtbx.Text);
                        insertCommand.Parameters.AddWithValue("@nom", firstnametxt.Text);
                        insertCommand.Parameters.AddWithValue("@prenom", lastnametxt.Text);
                        insertCommand.Parameters.AddWithValue("@tel", phonetxtbx.Text);
                        insertCommand.Parameters.AddWithValue("@sex", (maleRadioBtn.Checked) ? 'm' : 'f');
                        string dateOfBirth = yearOfBirth.Value + "/" + monthOfBirth.Value + "/" + dayOfBirth.Value;
                        insertCommand.Parameters.AddWithValue("@datedenaiss", dateOfBirth);
                        await insertCommand.ExecuteNonQueryAsync();
                        directeurpedaghForm f = new directeurpedaghForm();
                        this.Hide();
                        SqlCommand idUser = new SqlCommand("select ID_dp from DirecteurPedaghogique where email like @email", connection);
                        idUser.Parameters.AddWithValue("@email", emailtxtbx.Text + ".dp@gmail.com");
                        SqlDataReader reader = idUser.ExecuteReader();
                        reader.Read();
                        f.UserId = Convert.ToString(reader.GetValue(0));
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        messageLabel.Text = "Email already used\nplease try again...";
                        messageLabel.Visible = true;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
