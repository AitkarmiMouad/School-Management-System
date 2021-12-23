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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        UIstyle style = new UIstyle();
        FunctionsClass functions = new FunctionsClass();
        public string UserId;

        private void scheduleLblBtn_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            StudentScheduleForm ssf = new StudentScheduleForm();
            ssf.parentUserID = UserId;
            style.openFormInPanel(ssf, panelShowForm);

        }

        private void gradeslblBtn_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            StudentGrades sg = new StudentGrades();
            sg.parentUserID = UserId;
            style.openFormInPanel(sg, panelShowForm);

        }

        private void accountLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            StudentAccount sa = new StudentAccount();
            sa.parentUserID = UserId;
            style.openFormInPanel(sa, panelShowForm);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentScheduleForm ssf = new StudentScheduleForm();
            ssf.parentUserID = UserId;
            style.openFormInPanel(ssf, panelShowForm);
            try
            {
                DataTable dt = new DataTable();
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select E.nom,E.prenom,CONVERT(nvarchar(10),F.nomFiliere)+' '+CONVERT(nvarchar(10),G.annee)+CONVERT(nvarchar(10),G.numgroup) as 'group' from Etudiant E,Groupe G,Filiere F where F.ID_filiere=G.ID_filiere and G.ID_group=E.ID_group and E.ID_etudiant="+UserId, connection);
                dt.Load(command.ExecuteReader());
                fullNamelbl.Text = dt.Rows[0][0] + " " + dt.Rows[0][1] + "\n" + dt.Rows[0][2];
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

        private void scheduleLblBtn_MouseHover(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.FromArgb(49, 49, 66))
                (sender as Label).BackColor = Color.FromArgb(71, 71, 89);
        }

        private void scheduleLblBtn_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.FromArgb(71, 71, 89))
                (sender as Label).BackColor = Color.FromArgb(49, 49, 66);
        }
    }
}
