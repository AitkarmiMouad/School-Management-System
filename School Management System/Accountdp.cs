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
using System.IO;

namespace School_Management_System
{
    public partial class Accountdp : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;

        public Accountdp()
        {
            InitializeComponent();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            Application.OpenForms["directeurpedaghForm"].Hide();
            f.ShowDialog();
            Application.OpenForms["directeurpedaghForm"].Close();

        }

        private void Accountdp_Load(object sender, EventArgs e)
        {
            DataTable dt= functions.ShowAccountInfo(connection, "DirecteurPedaghogique", " where ID_dp=" + parentUserID);
            Idtxtbx.Text = dt.Rows[0][0].ToString();
            FirstNametxtbx.Text = dt.Rows[0][3].ToString();
            LastNametxtbx.Text = dt.Rows[0][4].ToString();
            Emailtxtbx.Text = dt.Rows[0][1].ToString();
            password.Text = dt.Rows[0][2].ToString();
            phone.Text = dt.Rows[0][5].ToString();
            Sextxtbx.Text = dt.Rows[0][6].ToString();
            DateofBirthtxtbx.Text = Convert.ToDateTime(dt.Rows[0][7]).ToString("dd/MM/yyyy");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (password.Enabled == true)
            {
                password.Enabled = false;
            }
            else
            {
                password.Enabled = true;
            }
            if (password.Enabled==false)
            {
                if (functions.CheckRegex(password.Text, @"^\w{6,}$", "Password Invalid\nonly characters and numbers allowed(6 char Min)"))
                {
                    password.Focus();
                    password.SelectAll();
                    password.Select();
                    return;
                }
                
                try
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand insertCommand = new SqlCommand("update DirecteurPedaghogique set motdepasse=@motdepass where ID_dp=" +parentUserID, connection);
                    insertCommand.Parameters.AddWithValue("@motdepass", password.Text);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void label10_Click(object sender, EventArgs e)
        {
            if (phone.Enabled == true)
            {
                phone.Enabled = false;
            }
            else
            {
                phone.Enabled = true;
            }
            if (phone.Enabled == false)
            {
                if (functions.CheckRegex(phone.Text, @"^\d{10}$", "Phone Invalid\nonly numbers allowed (10 digits)"))
                {
                    phone.Focus();
                    phone.SelectAll();
                    phone.Select();
                    return;
                }

                try
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand insertCommand = new SqlCommand("update DirecteurPedaghogique set tel=@phone where ID_dp=" + parentUserID, connection);
                    insertCommand.Parameters.AddWithValue("@phone", phone.Text);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
