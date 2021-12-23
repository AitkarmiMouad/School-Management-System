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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        UIstyle style = new UIstyle();
        FunctionsClass functions = new FunctionsClass();
        public string UserId;
        private void dashboardLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            TeadcherDashboardForm tdf = new TeadcherDashboardForm();
            tdf.parentUserID = UserId;
            style.openFormInPanel(tdf, panelShowForm);
        }

        private void accountLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            TeacherAccount ta = new TeacherAccount();
            ta.parentUserID = UserId;
            style.openFormInPanel(ta, panelShowForm);

        }

        private void Gradeslblbtn_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            TeacherGradesForm tgf = new TeacherGradesForm();
            tgf.parentUserID = UserId;
            style.openFormInPanel(tgf, panelShowForm);

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            TeadcherDashboardForm tdf = new TeadcherDashboardForm();
            tdf.parentUserID = UserId;
            style.openFormInPanel(tdf, panelShowForm);
            functions.FullNameMainForm(connection, "Prof","ID_prof", UserId,"Teacher", fullNamelbl);

        }

        private void ExamslblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            examteacherForm etf = new examteacherForm();
            etf.parentUserID = UserId;
            style.openFormInPanel(etf, panelShowForm);

        }

        private void dashboardLblButton_MouseHover(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.FromArgb(49, 49, 66))
                (sender as Label).BackColor = Color.FromArgb(71, 71, 89);
        }

        private void dashboardLblButton_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.FromArgb(71, 71, 89))
                (sender as Label).BackColor = Color.FromArgb(49, 49, 66);
        }
    }
}
