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
    public partial class SectionsFormdp : Form
    {
        public SectionsFormdp()
        {
            InitializeComponent();
        }
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;

        private void SectionsFormdp_Load(object sender, EventArgs e)
        {
            connection.Close();
            functions.fillComboBox(connection, sectionComboBox, "select nomFiliere,ID_filiere from Filiere where ID_dp=" + parentUserID);
            functions.dgvDataReader(connection, SectionDatagridview, "select * from Groupe where ID_filiere=" + sectionComboBox.SelectedValue);
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupsRadioBtn.Checked)
            {
                functions.dgvDataReader(connection, SectionDatagridview, "select * from Groupe where ID_filiere=" + sectionComboBox.SelectedValue);
                functions.DashboardLabels(connection, "Groupe","ID_group",CountLabel, " where ID_filiere=" + sectionComboBox.SelectedValue);

            }
            if (SubjectRadioBtn.Checked)
            {
                functions.dgvDataReader(connection, SectionDatagridview, "select * from Module where ID_filiere=" + sectionComboBox.SelectedValue);
                functions.DashboardLabels(connection, "Module", "ID_module", CountLabel, " where ID_filiere=" + sectionComboBox.SelectedValue);
            }
        }
    }
}
