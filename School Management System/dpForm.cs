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
    public partial class directeurpedaghForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        UIstyle style = new UIstyle();
        FunctionsClass functions = new FunctionsClass();
        public string UserId;

        public directeurpedaghForm()
        {
            InitializeComponent();
        }
                      
        private void directeurpedaghForm_Load(object sender, EventArgs e)
        {
            eduDashboardForm f = new eduDashboardForm();
            f.parentUserID = UserId;
            style.openFormInPanel(f, panelShowForm);
            functions.FullNameMainForm(connection, "DirecteurPedaghogique","ID_dp", UserId,"Educational Director", fullNamelbl);

        }
        
        private void dashboardLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            eduDashboardForm edf = new eduDashboardForm();
            edf.parentUserID = UserId;
            style.openFormInPanel(edf, panelShowForm);

        }

        private void accountLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            Accountdp adp = new Accountdp();
            adp.parentUserID = UserId;
            style.openFormInPanel(adp, panelShowForm);

        }

        private void sectionLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            SectionsFormdp sfdp = new SectionsFormdp();
            sfdp.parentUserID = UserId;
            style.openFormInPanel(sfdp, panelShowForm);
        }

        private void teacherLblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            style.labelColorEffect((Label)sender, panel3);
            TeachersdpForm tdp = new TeachersdpForm();
            tdp.parentUserID = UserId;
            style.openFormInPanel(tdp, panelShowForm);

        }

        private void studentlblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            StudentdpForm sdp = new StudentdpForm();
            sdp.parentUserID = UserId;
            style.openFormInPanel(sdp, panelShowForm);

        }

        private void manageLblButton_Click(object sender, EventArgs e)
        {
            managePanel.Visible = !managePanel.Visible;
        }

        private void classlblButton_Click(object sender, EventArgs e)
        {
            style.labelColorEffect((Label)sender, managePanel);
            style.labelColorEffect((Label)sender, panel3);
            style.labelColorEffect((Label)sender, Accountlblpanel);
            classShedule cs = new classShedule();
            cs.parentUserID = UserId;
            style.openFormInPanel(cs, panelShowForm);

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
