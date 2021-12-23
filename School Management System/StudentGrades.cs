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
    public partial class StudentGrades : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public StudentGrades()
        {
            InitializeComponent();
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            functions.dgvDataReader(connection,GradesDataGridView, "select M.nomModule as 'Subject',E.nomExam as 'Exam Type',EE.Note as 'Grade' from Exam E,Exam_Etudiant EE,Module M where E.ID_exam=EE.ID_exam and E.ID_module=M.ID_module and EE.ID_etudiant="+parentUserID+" order by M.nomModule");
        }
    }
}
