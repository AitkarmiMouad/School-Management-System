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
    public partial class TeacherGradesForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public TeacherGradesForm()
        {
            InitializeComponent();
        }
        private void TeacherGradesForm_Load(object sender, EventArgs e)
        {
            functions.fillComboBox(connection, SectionComboBox, "select nomFiliere,ID_filiere from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof = " + Convert.ToInt32(parentUserID) + " ))");
            
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            functions.fillComboBox(connection, subjectComboBox, "select M.nomModule as 'Subject',ID_module from Module M where M.ID_module in(select ID_module from Enseigne where ID_group=" + groupComboBox.SelectedValue+" and ID_prof="+parentUserID+ ")");
            
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionComboBox.SelectedIndex != -1)
            {
                functions.fillComboBox(connection, groupComboBox, "select distinct CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'group',G.ID_group from Groupe G,Filiere F,Enseigne E where E.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and F.ID_filiere=" + SectionComboBox.SelectedValue+ " and E.ID_group in (select ID_group from Enseigne where ID_prof="+ Convert.ToInt32(parentUserID) + ")");
                
            }
        }
        
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is ComboBox)
                {
                    if((c as ComboBox).SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Enter A valid Exam Name", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            try
            {
                DataTable dt = new DataTable();
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand ExistedValue = new SqlCommand("select ID_etudiant,nom,prenom from Etudiant where ID_group = @group", connection);
                ExistedValue.Parameters.AddWithValue("@group", groupComboBox.SelectedValue);
                dt.Load(ExistedValue.ExecuteReader());

                SqlCommand comm = new SqlCommand("select count(*) from Exam_Etudiant where ID_exam="+ExamComboBox.SelectedValue, connection);
                if (Convert.ToInt32(comm.ExecuteScalar())==0)
                { 
                    foreach(DataRow row in dt.Rows)
                    {
                      SqlCommand insertCommand = new SqlCommand("insert into Exam_Etudiant (ID_etudiant,ID_exam) values(@etudiant,@exam)", connection);
                      insertCommand.Parameters.AddWithValue("@etudiant", row[0]);
                      insertCommand.Parameters.AddWithValue("@exam", ExamComboBox.SelectedValue);
                      insertCommand.ExecuteNonQuery();
                    }
                }

                functions.dgvDataReader(connection, GradesDataGridView, "select distinct ET.ID_etudiant,ET.nom, ET.prenom, EX.Note from Exam_Etudiant EX, Etudiant ET where ET.ID_etudiant = EX.ID_etudiant and EX.ID_exam = " + ExamComboBox.SelectedValue);
                GradesDataGridView.Columns[0].ReadOnly = true;
                GradesDataGridView.Columns[1].ReadOnly = true;
                GradesDataGridView.Columns[2].ReadOnly = true;

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

        private void GradesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (GradesDataGridView.CurrentCell.ColumnIndex == 3)
            {
                if(e.Control!=null) //&& e.Control is TextBox
                {
                    e.Control.KeyPress += delegate (object MyS, KeyPressEventArgs MyE)
                    {
                        if (char.IsDigit(MyE.KeyChar)==true || MyE.KeyChar=='.' || char.IsControl(MyE.KeyChar))
                        {
                            MyE.Handled = false;
                        }
                        else
                        {
                            MyE.Handled = true;
                        }
                    };
                }

            }
        }
        
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (GradesDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No Data To Submit !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("Are You Sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) { 
            try
            {
                foreach (DataGridViewRow row in GradesDataGridView.Rows)
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    SqlCommand update = new SqlCommand("update Exam_Etudiant set Note=@exam where ID_etudiant=@etudiant", connection);
                    update.Parameters.AddWithValue("@etudiant", row.Cells[0].Value);
                    update.Parameters.AddWithValue("@exam", row.Cells[3].Value);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Successfully Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            functions.fillComboBox(connection, ExamComboBox, "select E.nomExam as 'Exam Name',E.ID_exam from Exam E,Salle_Groupe SG where E.ID_Salle_Group=SG.ID_Salle_Group and SG.ID_group=" + groupComboBox.SelectedValue + " and E.ID_module=" + subjectComboBox.SelectedValue);

        }
    }
}
