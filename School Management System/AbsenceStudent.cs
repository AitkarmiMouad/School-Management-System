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
    public partial class AbsenceStudent : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public string studentID;
        public int groupID;

        public AbsenceStudent()
        {
            InitializeComponent();
        }
        private string SalleGroup(SqlConnection connection,DateTime date)
        {
            try
            {
                DataTable dt = new DataTable();
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select ID_Salle_Group from Salle_Groupe where ID_group="+groupID+" and _date=@date", connection);
                command.Parameters.AddWithValue("@date", date.ToString("yyyy/MM/dd"));
                dt.Load(command.ExecuteReader());
                if (dt.Rows.Count == 0) 
                {
                    MessageBox.Show("No Classes Found");
                    return null; 
                }
                else 
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }  
        private void AbsenceStudent_Load(object sender, EventArgs e)
        {
            functions.fillComboBox(connection, timeComboBox, "select CONVERT(nvarchar(15),timeFrom)+' - '+CONVERT(nvarchar(15),timeTo) as 'Time',ID_Salle_Group from Salle_Groupe where ID_group=" + groupID + " and _date like '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
            timeComboBox.SelectedIndex = -1;
            functions.dgvDataReader(connection, AbsenceDataGridView, "select A.ID_absence as 'Id Absence',SG.ID_salle,SG.ID_group,SG.timeFrom,SG.timeTo,SG._date as 'Date',SG.ID_prof from Salle_Groupe SG,Absence A where A.ID_SalleGroup=SG.ID_Salle_Group and A.ID_etudiant=" + studentID);
            functions.DashboardLabels(connection, "Absence", "ID_absence", AbsenceCountLabel, " where ID_etudiant=" + studentID);

        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            functions.dgvDataReader(connection, AbsenceDataGridView, "select A.ID_absence as 'Id Absence',SG.ID_salle,SG.ID_group,SG.timeFrom,SG.timeTo,SG._date as 'Date',SG.ID_prof from Salle_Groupe SG,Absence A where A.ID_SalleGroup=SG.ID_Salle_Group and A.ID_etudiant=" + studentID);
            functions.DashboardLabels(connection, "Absence", "ID_absence", AbsenceCountLabel, " where ID_etudiant=" + studentID);
        }
        string salleGroup;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {            
            timeComboBox.DataSource = null;
            timeComboBox.Items.Clear();
            salleGroup = SalleGroup(connection, dateTimePicker1.Value);
            if (salleGroup != null)
            {
                functions.fillComboBox(connection, timeComboBox, "select CONVERT(nvarchar(15),timeFrom)+' - '+CONVERT(nvarchar(15),timeTo) as 'Time',ID_Salle_Group from Salle_Groupe where ID_group=" + groupID + " and _date like '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");
                timeComboBox.SelectedIndex = -1;
            }
            functions.dgvDataReader(connection, AbsenceDataGridView, "select A.ID_absence as 'Id Absence',SG.ID_salle,SG.ID_group,SG.timeFrom,SG.timeTo,SG._date as 'Date',SG.ID_prof from Salle_Groupe SG,Absence A where A.ID_SalleGroup=SG.ID_Salle_Group and A.ID_etudiant=" + studentID);
            functions.DashboardLabels(connection, "Absence", "ID_absence", AbsenceCountLabel, " where ID_etudiant=" + studentID);

        }

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            if (timeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose a Valid Date and Time");
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand ExistedValue = new SqlCommand("select count(ID_absence) from Absence where ID_etudiant=@etudiant and ID_SalleGroup=@salleGroup", connection);
                ExistedValue.Parameters.AddWithValue("@etudiant",studentID);
                ExistedValue.Parameters.AddWithValue("@salleGroup", timeComboBox.SelectedValue);
                if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Absence (ID_etudiant,ID_SalleGroup) values(@etudiant,@salleGroup)", connection);
                    insertCommand.Parameters.AddWithValue("@etudiant", studentID);
                    insertCommand.Parameters.AddWithValue("@salleGroup", timeComboBox.SelectedValue);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Absence Already Added");
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

        private void btnDeleteAbsence_Click(object sender, EventArgs e)
        {
            if (AbsenceDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please Choose a Valid Absence from grid view");
                return;
            }
            try
            {

                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand insertCommand = new SqlCommand("delete from Absence where ID_absence=@absence", connection);
                insertCommand.Parameters.AddWithValue("@absence",Convert.ToInt32( AbsenceDataGridView.CurrentRow.Cells[0].Value));
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

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeComboBox.SelectedIndex != -1)
            {
                functions.dgvDataReader(connection, AbsenceDataGridView, "select A.ID_absence as 'Id Absence',SG.ID_salle,SG.ID_group,SG.timeFrom,SG.timeTo,SG._date as 'Date',SG.ID_prof from Salle_Groupe SG,Absence A where A.ID_SalleGroup=SG.ID_Salle_Group and A.ID_SalleGroup=" + timeComboBox.SelectedValue+" and A.ID_etudiant="+ studentID);

            }
        }
    }
}
