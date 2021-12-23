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
    public partial class TeachersdpForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        string foundID;


        public TeachersdpForm()
        {
            InitializeComponent();
        }
        private void AddGroupTeacher_Click(object sender, EventArgs e)
        {
            if (Idtxtbx.Text == "")
            {
                MessageBox.Show("Please Choose A Teacher");
                return;
            }
            TeacherdpGroupForm tdpG = new TeacherdpGroupForm();
            tdpG.parentUserID = parentUserID;
            tdpG.idProf = Idtxtbx.Text;
            tdpG.ShowDialog();

        }
        private void TeachersdpForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            functions.dgvDataReader(connection, guna2DataGridView1, "select * from Prof");
            
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in ShowSectionGroupBx.Controls)
            {
                if (c is DateTimePicker)
                {
                    (c as DateTimePicker).Value = DateTime.Now;
                }
                if(c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
        }
        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow.Index != -1)
            {
                Idtxtbx.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                FirstNametxtbx.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
                LastNametxtbx.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                Emailtxtbx.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
                password.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
                phone.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
                if(guna2DataGridView1.CurrentRow.Cells[6].Value.ToString().ToLower() == "m")
                {
                    maleradiobtn.Checked = true;
                    femaleradiobtn.Checked = false;

                }
                else
                {
                    femaleradiobtn.Checked = true;
                    maleradiobtn.Checked = false;

                }
                dateTimePicker1.Value =Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells[7].Value);

            }
        }
        private void AddTeacher_Click(object sender, EventArgs e)
        {
            if (functions.CheckRegex(FirstNametxtbx.Text, "^[a-z]+$", "First Name Invalid\nonly small characters allowed")) {
                FirstNametxtbx.Focus();
                FirstNametxtbx.SelectAll();
                FirstNametxtbx.Select();
                return;
            }
            if (functions.CheckRegex(LastNametxtbx.Text, "^[a-z]+$", "Last Name Invalid\nonly small characters allowed"))
            {
                LastNametxtbx.Focus();
                LastNametxtbx.SelectAll();
                LastNametxtbx.Select();
                return;
            }
            if (functions.CheckRegex(Emailtxtbx.Text, @"^\w+([-_.]\w+)*$", "Email Invalid\nonly (characters , - , . , _) are allowed"))
            {
                Emailtxtbx.Focus();
                Emailtxtbx.SelectAll();
                Emailtxtbx.Select();
                return;
            }
            if (functions.CheckRegex(password.Text, @"^\w{6,}$", "Password Invalid\nonly characters and numbers allowed(6 char Min)"))
            {
                password.Focus();
                password.SelectAll();
                password.Select();
                return;
            }
            if (functions.CheckRegex(phone.Text, @"^\d{10}$", "Phone Invalid\nonly numbers allowed (10 digits)"))
            {
                phone.Focus();
                phone.SelectAll();
                phone.Select();
                return;
            }

            try
            {
                if(connection.State==ConnectionState.Closed)connection.Open();
                SqlCommand ExistedValue = new SqlCommand("select count(email) from Prof where email like @email", connection);
                ExistedValue.Parameters.AddWithValue("@email", Emailtxtbx.Text + ".prof@gmail.com");
                if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Prof (email,motdepasse,nom,prenom,tel,sex,datedenaiss) values(@email,@motdepass,@nom,@prenom,@tel,@sex,@datedenaiss)", connection);
                    insertCommand.Parameters.AddWithValue("@email", Emailtxtbx.Text + ".prof@gmail.com");
                    insertCommand.Parameters.AddWithValue("@motdepass", password.Text);
                    insertCommand.Parameters.AddWithValue("@nom", FirstNametxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@prenom", LastNametxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@tel", phone.Text);
                    insertCommand.Parameters.AddWithValue("@sex", (maleradiobtn.Checked) ? 'm' : 'f');
                    insertCommand.Parameters.AddWithValue("@datedenaiss", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email already used\nplease try again...");
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
            foreach (Control c in ShowSectionGroupBx.Controls)
            {
                if (c is DateTimePicker)
                {
                    (c as DateTimePicker).Value = DateTime.Now;
                }
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }

        }
        private void FindTeacher_Click(object sender, EventArgs e)
        {
            FindForm find = new FindForm();
            find.ShowDialog();
            foundID = find.findID;
            if (foundID != null)
            {
                functions.dgvDataReader(connection, guna2DataGridView1, "select * from Prof where ID_prof="+ foundID);
                if (guna2DataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("ID Not Found");
                }
                else
                {
                    MessageBox.Show("ID Found");
                }
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            functions.dgvDataReader(connection, guna2DataGridView1, "select * from Prof");
        }

        private void UpdateTeacher_Click(object sender, EventArgs e)
        {
            if (Idtxtbx.Text == "")
            {
                MessageBox.Show("Please Select An ID");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("update Prof set motdepasse=@motdepass,nom=@nom,prenom=@prenom,tel=@tel,sex=@sex,datedenaiss=@datedenaiss where ID_prof="+ Idtxtbx.Text, connection);
                insertCommand.Parameters.AddWithValue("@motdepass", password.Text);
                insertCommand.Parameters.AddWithValue("@nom", FirstNametxtbx.Text);
                insertCommand.Parameters.AddWithValue("@prenom", LastNametxtbx.Text);
                insertCommand.Parameters.AddWithValue("@tel", phone.Text);
                insertCommand.Parameters.AddWithValue("@sex", (maleradiobtn.Checked) ? 'm' : 'f');
                insertCommand.Parameters.AddWithValue("@datedenaiss", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully\nNote: You Can't Change the Emails", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void DeleteTeacher_Click(object sender, EventArgs e)
        {
            if (Idtxtbx.Text == "")
            {
                MessageBox.Show("Please Select An ID");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("delete from Prof where ID_prof=" + Idtxtbx.Text, connection);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
