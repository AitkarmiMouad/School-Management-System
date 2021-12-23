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
    public partial class StudentdpForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        string foundID;
                
        public StudentdpForm()
        {
            InitializeComponent();
        }

        private void AbsenceBtn_Click(object sender, EventArgs e)
        {
            if (idtxtbx.Text == "")
            {
                MessageBox.Show("Please Choose A Student");
                return;
            }
            if (idtxtbx.Text == "") {
                MessageBox.Show("Please Choose A Student ID");
                return;
            }
            AbsenceStudent abs = new AbsenceStudent();
            abs.studentID = idtxtbx.Text;
            abs.groupID = Convert.ToInt32(StudentDataGridView.CurrentRow.Cells[8].Value);
            abs.ShowDialog();
        }

        private void ShowAllStudent_Click(object sender, EventArgs e)
        {
            functions.fillComboBoxAndGridView(connection,SectionComboBox ,StudentDataGridView, "select nomFiliere,ID_filiere from Filiere","select * from Etudiant");
            SectionComboBox.SelectedIndex = -1;
            GroupComboBox.SelectedIndex = -1;

        }
        
        private void StudentdpForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            functions.fillComboBox(connection, SectionComboBox, "select nomFiliere,ID_filiere from Filiere");
            SectionComboBox.SelectedIndex = -1;
            functions.dgvDataReader(connection, StudentDataGridView, "select * from Etudiant");
            
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionComboBox.SelectedIndex != -1)
            {
                StudentDataGridView.ClearSelection();
                functions.fillComboBox(connection, GroupComboBox, "select CONVERT(nvarchar(10),annee)+CONVERT(nvarchar(10),numgroup) as 'display',ID_group from Groupe where ID_filiere=" + SectionComboBox.SelectedValue);
                GroupComboBox.SelectedIndex = -1;
                functions.dgvDataReader(connection, StudentDataGridView, "select * from Etudiant where ID_group in(select ID_group from Groupe where ID_filiere=" + SectionComboBox.SelectedValue + ")");
                StudentDataGridView.ClearSelection();
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
                    GroupLabel.Text = "";
                }
            }


        }

        private void StudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (StudentDataGridView.CurrentRow.Index != -1)
            {
                idtxtbx.Text = StudentDataGridView.CurrentRow.Cells[0].Value.ToString();
                Firstnametxtbx.Text = StudentDataGridView.CurrentRow.Cells[1].Value.ToString();
                Lastnametxtbx.Text = StudentDataGridView.CurrentRow.Cells[2].Value.ToString();
                emailtxtbx.Text = StudentDataGridView.CurrentRow.Cells[3].Value.ToString();
                passwordtxtbx.Text = StudentDataGridView.CurrentRow.Cells[4].Value.ToString();
                phonetxtbx.Text = StudentDataGridView.CurrentRow.Cells[5].Value.ToString();
                if (StudentDataGridView.CurrentRow.Cells[6].Value.ToString().ToLower() == "m")
                {
                    maleradiobtn.Checked = true;
                    femaleradiobtn.Checked = false;

                }
                else
                {
                    femaleradiobtn.Checked = true;
                    maleradiobtn.Checked = false;

                }
                dateTimePicker1.Value = Convert.ToDateTime(StudentDataGridView.CurrentRow.Cells[7].Value);
                functions.GroupIntoLabel(connection,GroupLabel,StudentDataGridView.CurrentRow.Cells[8].Value.ToString());
                
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupComboBox.SelectedIndex != -1)
            {
                functions.dgvDataReader(connection, StudentDataGridView, "select * from Etudiant where ID_group=" + GroupComboBox.SelectedValue);
                StudentDataGridView.ClearSelection();
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
                    GroupLabel.Text = "";
                }
            }
            
        }
        
        private void ClearBtn_Click(object sender, EventArgs e)
        {
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
                GroupLabel.Text = "";
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

            if (functions.CheckRegex(Firstnametxtbx.Text, "^[a-z]+$", "First Name Invalid\nonly small characters allowed"))
            {
                Firstnametxtbx.Focus();
                Firstnametxtbx.SelectAll();
                Firstnametxtbx.Select();
                return;
            }
            if (functions.CheckRegex(Lastnametxtbx.Text, "^[a-z]+$", "Last Name Invalid\nonly small characters allowed"))
            {
                Lastnametxtbx.Focus();
                Lastnametxtbx.SelectAll();
                Lastnametxtbx.Select();
                return;
            }
            if (functions.CheckRegex(emailtxtbx.Text, @"^\w+([-_.]\w+)*$", "Email Invalid\nonly (characters , - , . , _) are allowed"))
            {
                emailtxtbx.Focus();
                emailtxtbx.SelectAll();
                emailtxtbx.Select();
                return;
            }
            if (functions.CheckRegex(passwordtxtbx.Text, @"^\w{6,}$", "Password Invalid\nonly characters and numbers allowed(6 char Min)"))
            {
                passwordtxtbx.Focus();
                passwordtxtbx.SelectAll();
                passwordtxtbx.Select();
                return;
            }
            if (functions.CheckRegex(phonetxtbx.Text, @"^\d{10}$", "Phone Invalid\nonly numbers allowed (10 digits)"))
            {
                phonetxtbx.Focus();
                phonetxtbx.SelectAll();
                phonetxtbx.Select();
                return;
            }
            if (GroupComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose a Section and a Group");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand ExistedValue = new SqlCommand("select count(email) from Etudiant where email like @email", connection);
                ExistedValue.Parameters.AddWithValue("@email", emailtxtbx.Text + ".etu@gmail.com");
                if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Etudiant (email,motdepasse,nom,prenom,tel,sex,datedenaiss,ID_group) values(@email,@motdepass,@nom,@prenom,@tel,@sex,@datedenaiss,@ID_group)", connection);
                    insertCommand.Parameters.AddWithValue("@email", emailtxtbx.Text + ".etu@gmail.com");
                    insertCommand.Parameters.AddWithValue("@motdepass", passwordtxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@nom", Firstnametxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@prenom", Lastnametxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@tel", phonetxtbx.Text);
                    insertCommand.Parameters.AddWithValue("@sex", (maleradiobtn.Checked) ? 'm' : 'f');
                    insertCommand.Parameters.AddWithValue("@datedenaiss", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@ID_group", GroupComboBox.SelectedValue);

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

        private void FindStudent_Click(object sender, EventArgs e)
        {
            FindForm find = new FindForm();
            find.ShowDialog();
            foundID = find.findID;
            if (foundID != null)
            {
                functions.dgvDataReader(connection, StudentDataGridView, "select * from Etudiant where ID_etudiant=" + foundID);
                if (StudentDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("ID Not Found");
                }
                else
                {
                    MessageBox.Show("ID Found");
                }
            }
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            if (idtxtbx.Text == "")
            {
                MessageBox.Show("Please Select An ID");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("update Etudiant set motdepasse=@motdepass,nom=@nom,prenom=@prenom,tel=@tel,sex=@sex,datedenaiss=@datedenaiss where ID_etudiant=" + idtxtbx.Text, connection);
                insertCommand.Parameters.AddWithValue("@motdepass", passwordtxtbx.Text);
                insertCommand.Parameters.AddWithValue("@nom", Firstnametxtbx.Text);
                insertCommand.Parameters.AddWithValue("@prenom", Lastnametxtbx.Text);
                insertCommand.Parameters.AddWithValue("@tel", phonetxtbx.Text);
                insertCommand.Parameters.AddWithValue("@sex", (maleradiobtn.Checked) ? 'm' : 'f');
                insertCommand.Parameters.AddWithValue("@datedenaiss", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully\nNote: You Can't Change the Emails or Groups", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (idtxtbx.Text == "")
            {
                MessageBox.Show("Please Select An ID");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("delete from Etudiant where ID_etudiant=" + idtxtbx.Text, connection);
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

        private void StudentdpForm_Shown(object sender, EventArgs e)
        {
            StudentDataGridView.ClearSelection();
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
                GroupLabel.Text = "";
            }
        }
    }
}
