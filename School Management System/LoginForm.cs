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
    public partial class LoginForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PermissionForm f = new PermissionForm();
            this.Hide();
            f.Icon = this.Icon;
            f.ShowDialog();
            this.Close();

        }
        UIstyle style1 = new UIstyle();
        private void userNameTxtbx_Enter(object sender, EventArgs e)
        {
            style1.selectedTextBox(userNameTxtbx, userNamePicturebx);
        }

        private void passwordTxtbx_Enter(object sender, EventArgs e)
        {
            style1.selectedTextBox(passwordTxtbx, passwordPicturebx);
        }

        private void userNameTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            style1.enterKey(passwordTxtbx, e);
        }
        bool CheckValidInfo=false;
        private void userNameTxtbx_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo =style1.txtChanged(userNameTxtbx, userNamePicturebx, @"^(\w+([-_.]\w+)*\.(etu|dp|prof){1}@gmail\.com)$", errorProvider1, "only (characters , numbers , - , . , _) are allowed");
        }

        private void passwordTxtbx_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            CheckValidInfo = false;
            CheckValidInfo =style1.txtChanged(passwordTxtbx, passwordPicturebx, @"^\w{6,}$", errorProvider2, "only characters and numbers allowed");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CheckValidInfo==false)
            {
                messageLabel.Text = "invalid info\nplease try again...";
                messageLabel.Visible = true;
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("loginUser",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@adressLogin", userNameTxtbx.Text);
                    command.Parameters.AddWithValue("@passwordLogin", passwordTxtbx.Text);
                    SqlParameter type = new SqlParameter("@type",SqlDbType.VarChar,10);
                    SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                    type.Direction = ParameterDirection.Output;
                    id.Direction = ParameterDirection.Output;
                    command.Parameters.Add(type);
                    command.Parameters.Add(id);
                    command.ExecuteNonQuery();
                    string formType = type.Value.ToString();
                    string userId = id.Value.ToString();
                    if (formType == "directeur")
                    {
                        directeurpedaghForm f = new directeurpedaghForm();
                        f.UserId = userId;
                        f.Icon = this.Icon;
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (formType == "prof")
                    {
                        TeacherForm f = new TeacherForm();
                        f.UserId = userId;
                        f.Icon = this.Icon;

                        this.Hide();
                        f.ShowDialog();
                        this.Close();

                    }
                    else if (formType == "etudiant")
                    {
                        StudentForm f = new StudentForm();
                        f.UserId = userId;
                        f.Icon = this.Icon;

                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else 
                    {
                        messageLabel.Text = "Email or Password Incorrect\nPlease Try Again...";
                        messageLabel.Visible = true;
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
