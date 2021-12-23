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
    public partial class examteacherForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public examteacherForm()
        {
            InitializeComponent();
        }

        private void examteacherForm_Load(object sender, EventArgs e)
        {
            //functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Filiere',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',SG._date as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name' from Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and ES.ID_prof=" + Convert.ToInt32(parentUserID));
            //TeacherDataGridView.ClearSelection();
            functions.fillComboBox(connection, SectionComboBox, "select nomFiliere,ID_filiere from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof = " + Convert.ToInt32(parentUserID) + " ))");
            rangeComboBox.SelectedIndex = 0;

        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionComboBox.SelectedIndex != -1)
            {
                //functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Filiere',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',SG._date as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name' from Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and ES.ID_prof=" + Convert.ToInt32(parentUserID) + " and F.ID_filiere=" + SectionComboBox.SelectedValue);
                //TeacherDataGridView.ClearSelection();
                // I THINK ITS NOT WORKING WELL  //functions.fillComboBox(connection, groupComboBox, "select distinct CONVERT(nvarchar(10),G.annee/10) as 'Annee',G.annee from Groupe G,Filiere F where G.ID_filiere=F.ID_filiere and F.ID_filiere=" + SectionComboBox.SelectedValue);
                
                functions.fillComboBox(connection, groupComboBox, "select distinct CONVERT(nvarchar(10),G.annee/10) as 'Annee',G.annee from Groupe G,Filiere F,Enseigne E where E.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and F.ID_filiere=" + SectionComboBox.SelectedValue + " and E.ID_group in (select ID_group from Enseigne where ID_prof=" + Convert.ToInt32(parentUserID) + ")");
                groupComboBox.SelectedIndex = 0;
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Section',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',FORMAT(SG._date,'yyyy-MM-dd') as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name',M.nomModule as 'Subject' from Module M,Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_module=M.ID_module and E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and G.annee=" + groupComboBox.SelectedValue + " and ES.ID_prof=" + parentUserID);
            TeacherDataGridView.ClearSelection();
        }

        private void FillChechedListBox(SqlConnection connection, CheckedListBox target, string query)
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                dt.Load(command.ExecuteReader());
                ((ListBox)target).DataSource = dt;
                ((ListBox)target).DisplayMember = "DateTime";
                ((ListBox)target).ValueMember = "salleGroup";
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

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex != -1)
            {
                functions.fillComboBox(connection, subjectComboBox, "select distinct M.nomModule as 'Subject',ID_module from Module M where M.ID_module in(select ID_module from Enseigne where ID_prof=" + parentUserID+" and ID_group in(select ID_group from Groupe where annee=" + groupComboBox.SelectedValue + "))");

                rangeComboBox.SelectedIndex = -1;
                rangeComboBox.SelectedIndex = 0;
            }

        }

        private void rangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangeComboBox.SelectedIndex != -1)
            {
                if (rangeComboBox.SelectedIndex == 0)   // All
                {
                    functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Section',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',FORMAT(SG._date,'yyyy-MM-dd') as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name',M.nomModule as 'Subject' from Module M,Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_module=M.ID_module and E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and G.annee=" + groupComboBox.SelectedValue + " and ES.ID_prof=" + parentUserID);
                    TeacherDataGridView.ClearSelection();
                    FillChechedListBox(connection, checkedListBox1, "select CONVERT(nvarchar(10),FORMAT(SG._date,'dd/MM/yyyy'))+'  | '+CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.ID_group)+'  | '+CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'DateTime',SG.ID_Salle_Group as 'salleGroup',SG._date as 'Date' from Salle_Groupe SG,Groupe G where SG.ID_group=G.ID_group and G.annee=" + groupComboBox.SelectedValue + " and SG.ID_prof=" + parentUserID);

                }
                else if (rangeComboBox.SelectedIndex == 1)      // Past Week
                {
                    functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Section',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',FORMAT(SG._date,'yyyy-MM-dd') as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name',M.nomModule as 'Subject' from Module M,Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_module=M.ID_module and E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and G.annee=" + groupComboBox.SelectedValue + " and SG._date between '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + " and ES.ID_prof=" + parentUserID);
                    TeacherDataGridView.ClearSelection();
                    FillChechedListBox(connection, checkedListBox1, "select CONVERT(nvarchar(10),FORMAT(SG._date,'dd/MM/yyyy'))+'  | '+CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.ID_group)+'  | '+CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'DateTime',SG.ID_Salle_Group as 'salleGroup',SG._date as 'Date' from Salle_Groupe SG,Groupe G where SG.ID_group=G.ID_group and G.annee=" + groupComboBox.SelectedValue + " and SG._date between '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + " and SG.ID_prof=" + parentUserID);

                }
                else if(rangeComboBox.SelectedIndex == 2)      // This Week
                {
                    functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Section',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',FORMAT(SG._date,'yyyy-MM-dd') as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name',M.nomModule as 'Subject' from Module M,Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_module=M.ID_module and E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and G.annee=" + groupComboBox.SelectedValue+" and SG._date between '"+DateTime.Now.ToString("yyyy-MM-dd") + "' and '"+DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "'" + " and ES.ID_prof=" + parentUserID);
                    TeacherDataGridView.ClearSelection();
                    FillChechedListBox(connection, checkedListBox1, "select CONVERT(nvarchar(10),FORMAT(SG._date,'dd/MM/yyyy'))+'  | '+CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.ID_group)+'  | '+CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'DateTime',SG.ID_Salle_Group as 'salleGroup',SG._date as 'Date' from Salle_Groupe SG,Groupe G where SG.ID_group=G.ID_group and G.annee=" + groupComboBox.SelectedValue + " and SG._date between '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "'" + " and SG.ID_prof=" + parentUserID);

                }
                else if (rangeComboBox.SelectedIndex == 3) //  After This Week
                {
                    functions.dgvDataReader(connection, TeacherDataGridView, "select distinct E.ID_exam,F.nomFiliere as 'Section',CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'Group',FORMAT(SG._date,'yyyy-MM-dd') as 'Date',CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'Time',E.nomExam as 'Name',M.nomModule as 'Subject' from Module M,Filiere F,Exam E,Groupe G,Salle_Groupe SG,Enseigne ES where E.ID_module=M.ID_module and E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=ES.ID_group and SG.ID_prof=ES.ID_prof and ES.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and G.annee=" + groupComboBox.SelectedValue + " and SG._date between '" + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.AddDays(15).ToString("yyyy-MM-dd") + "'" + " and ES.ID_prof=" + parentUserID);
                    TeacherDataGridView.ClearSelection();
                    FillChechedListBox(connection, checkedListBox1, "select CONVERT(nvarchar(10),FORMAT(SG._date,'dd/MM/yyyy'))+'  | '+CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.ID_group)+'  | '+CONVERT(nvarchar(10),SG.timeFrom)+' - '+CONVERT(nvarchar(10),SG.timeTo) as 'DateTime',SG.ID_Salle_Group as 'salleGroup',SG._date as 'Date' from Salle_Groupe SG,Groupe G where SG.ID_group=G.ID_group and G.annee=" + groupComboBox.SelectedValue + " and SG._date between '" + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.AddDays(15).ToString("yyyy-MM-dd") + "'" + " and SG.ID_prof=" + parentUserID);

                }



            }
        }

        private void Addexambtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBx.Text == "")
            {
                MessageBox.Show("Please Enter Name Of Exam", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (subjectComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter A valid Subject Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                if(MessageBox.Show("Do You wanna Submit Exams For the Selected Classes", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {                    
                    try
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();

                        foreach(object item in checkedListBox1.CheckedItems)
                        {
                            var row = (item as DataRowView).Row;
                            int idSalleGroup = Convert.ToInt32(row["salleGroup"]); 
                            DateTime Date = (DateTime)row["Date"];
                            
                            SqlCommand ExistedValue = new SqlCommand("select count(ID_exam) from Exam where ID_Salle_Group = @idSalleGroup", connection);
                            ExistedValue.Parameters.AddWithValue("@idSalleGroup", idSalleGroup);

                            if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                            {
                                SqlCommand insertCommand = new SqlCommand("insert into Exam (nomExam,dateExam,ID_Salle_Group,ID_module) values(@nomExam,@date,@idSalleGroup,@module)", connection);
                                insertCommand.Parameters.AddWithValue("@nomExam", nameTxtBx.Text);
                                insertCommand.Parameters.AddWithValue("@date", Date.ToString("yyyy-MM-dd"));
                                insertCommand.Parameters.AddWithValue("@idSalleGroup", idSalleGroup);
                                insertCommand.Parameters.AddWithValue("@module", subjectComboBox.SelectedValue);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Please Choose Classes From The List", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void DeleteExambtn_Click(object sender, EventArgs e)
        {
            if (TeacherDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please Select An Exam From The Grid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TeacherDataGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please Select An Exam From The Grid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand ExistedValue = new SqlCommand("select count(ID_exam) from Exam_Etudiant where ID_exam = @exam", connection);
                ExistedValue.Parameters.AddWithValue("@exam", Convert.ToInt32(TeacherDataGridView.CurrentRow.Cells[0].Value));

                if (Convert.ToInt32(ExistedValue.ExecuteScalar()) == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("delete from Exam where ID_exam=" + Convert.ToInt32(TeacherDataGridView.CurrentRow.Cells[0].Value), connection);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("This Exam is already Submited\nYou can't delete it", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
