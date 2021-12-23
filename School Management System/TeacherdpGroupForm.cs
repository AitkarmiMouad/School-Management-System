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
    public partial class TeacherdpGroupForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public string idProf;


        public TeacherdpGroupForm()
        {
            InitializeComponent();
        }

        private void TeacherdpGroupForm_Load(object sender, EventArgs e)
        {
            functions.fillComboBox(connection, SectionComboBox, "select nomFiliere,ID_filiere from Filiere where ID_dp=" + parentUserID);
            SectionComboBox.SelectedIndex = -1;
            functions.dgvDataReader(connection, guna2DataGridView1, "select ID_prof as 'ID Teacher',ID_group as 'ID Group',ID_module as 'ID Subject' from Enseigne where ID_prof=" + idProf);


        }
       
        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionComboBox.SelectedIndex != -1) { 
                functions.fillComboBox(connection, GroupComboBox, "select CONVERT(nvarchar(10),annee)+CONVERT(nvarchar(10),numgroup) as 'display',ID_group from Groupe where ID_filiere=" + SectionComboBox.SelectedValue);
                functions.fillComboBox(connection, SubjectComboBox, "select nomModule,ID_module from Module where ID_filiere=" + SectionComboBox.SelectedValue);
                GroupComboBox.SelectedIndex = -1;
                SubjectComboBox.SelectedIndex = -1;
                functions.dgvDataReader(connection, guna2DataGridView1, "select ID_prof as 'ID Teacher',ID_group as 'ID Group',ID_module as 'ID Subject' from Enseigne where ID_prof=" + idProf + " and ID_group in(select ID_group from Groupe where ID_filiere=" + SectionComboBox.SelectedValue + ")");

            }
        }
       
        private void BtnSubmitTeachGroup_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is ComboBox) { 
                if ((c as ComboBox).SelectedIndex==-1)
                {
                MessageBox.Show("Please Enter All Values");
                return;
                }
                }
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("insert into Enseigne values(@id_prof,@id_group,@id_module)", connection);
                insertCommand.Parameters.AddWithValue("@id_prof", idProf);
                insertCommand.Parameters.AddWithValue("@id_group", GroupComboBox.SelectedValue);
                insertCommand.Parameters.AddWithValue("@id_module", SubjectComboBox.SelectedValue);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                {
                    if ((c as ComboBox).SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Enter All Values");
                        return;
                    }
                }
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("delete from Enseigne where ID_prof= @id_prof and ID_group=@id_group and ID_module=@id_module", connection);
                insertCommand.Parameters.AddWithValue("@id_prof", idProf);
                insertCommand.Parameters.AddWithValue("@id_group", GroupComboBox.SelectedValue);
                insertCommand.Parameters.AddWithValue("@id_module", SubjectComboBox.SelectedValue);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

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

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupComboBox.SelectedIndex != -1)
            {                
                functions.dgvDataReader(connection, guna2DataGridView1, "select ID_prof as 'ID Teacher',ID_group as 'ID Group',ID_module as 'ID Subject' from Enseigne where ID_prof=" + idProf + " and ID_group=" + GroupComboBox.SelectedValue);

            }
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectComboBox.SelectedIndex != -1)
            {
                functions.dgvDataReader(connection, guna2DataGridView1, "select ID_prof as 'ID Teacher',ID_group as 'ID Group',ID_module as 'ID Subject' from Enseigne where ID_prof=" + idProf + " and ID_group=" + GroupComboBox.SelectedValue + " and ID_module="+SubjectComboBox.SelectedValue);

            }
        }
    }
}
