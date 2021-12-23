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
    public partial class TeadcherDashboardForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        DataTable table;

        public TeadcherDashboardForm()
        {
            InitializeComponent();
        }

        private async void TeadcherDashboardForm_Load(object sender, EventArgs e)
        {
            functions.DashboardLabels(connection, "DirecteurPedaghogique", "distinct(ID_dp)", dashboardDPlbl, " where ID_dp in(select ID_dp from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof =" + Convert.ToInt32(parentUserID) + ")))");
            functions.DashboardLabels(connection, "Filiere", "distinct(ID_filiere)", dashboardSectionlbl, " where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof =" + Convert.ToInt32(parentUserID)+ "))");
            functions.DashboardLabels(connection, "Enseigne", "distinct(ID_group)", dashboardgrouplbl, " where ID_prof = " + Convert.ToInt32(parentUserID));
            functions.DashboardLabels(connection, "Etudiant", "distinct(ID_etudiant)", dashboardstudentlbl, " where ID_group in(select ID_group from Enseigne where ID_prof = " + Convert.ToInt32(parentUserID) + ")");
            // Data grid View Content
            dashboardDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select distinct ID_dp,nom,prenom,email from DirecteurPedaghogique where ID_dp in(select ID_dp from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof =" + Convert.ToInt32(parentUserID) + ")))";
            await Task.Run(new Action(AsyncVoid));
            dashboardDatagridView.Columns[0].HeaderText = "ID Educational Director";
            dashboardDatagridView.Columns[1].HeaderText = "Last Name";
            dashboardDatagridView.Columns[2].HeaderText = "First Name";
            dashboardDatagridView.Columns[3].HeaderText = "Email";
        }

        string query;
        private void AsyncVoid()
        {
            table = functions.dgvDataReader(connection, dashboardDatagridView, query);
        }

        private async void dashboardDPlbl_Click(object sender, EventArgs e)
        {
            dashboardDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select distinct ID_dp,nom,prenom,email from DirecteurPedaghogique where ID_dp in(select ID_dp from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof =" + Convert.ToInt32(parentUserID) + ")))";
            await Task.Run(new Action(AsyncVoid));
            dashboardDatagridView.Columns[0].HeaderText = "ID Educational Director";
            dashboardDatagridView.Columns[1].HeaderText = "Last Name";
            dashboardDatagridView.Columns[2].HeaderText = "First Name";
            dashboardDatagridView.Columns[3].HeaderText = "Email";
            
        }

        private async void dashboardSectionlbl_Click(object sender, EventArgs e)
        {
            dashboardDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select distinct * from Filiere where ID_filiere in(select ID_filiere from Groupe where ID_group in(select ID_group from Enseigne where ID_prof =" + Convert.ToInt32(parentUserID)+ "))";
            await Task.Run(new Action(AsyncVoid));
            dashboardDatagridView.Columns[0].HeaderText = "ID Section";
            dashboardDatagridView.Columns[1].HeaderText = "Section Name";
            dashboardDatagridView.Columns[2].HeaderText = "ID Education Director";

        }

        private async void dashboardgrouplbl_Click(object sender, EventArgs e)
        {
            dashboardDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select distinct G.ID_group,G.numgroup,G.annee,F.nomFiliere from Groupe G,Filiere F,Enseigne E where F.ID_filiere=G.ID_filiere and E.ID_prof = " + Convert.ToInt32(parentUserID) + " and E.ID_group=G.ID_group order by F.nomFiliere,G.numgroup,G.annee ";
            await Task.Run(new Action(AsyncVoid));
            dashboardDatagridView.Columns[0].HeaderText = "ID group";
            dashboardDatagridView.Columns[1].HeaderText = "Group Number";
            dashboardDatagridView.Columns[2].HeaderText = "Group Year";
            dashboardDatagridView.Columns[3].HeaderText = "Section Of Group";

        }

        private async void dashboardstudentlbl_Click(object sender, EventArgs e)
        {
            dashboardDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            query = "select distinct E.ID_etudiant,E.nom,E.prenom,E.email,E.sex,G.numgroup,G.annee,F.nomFiliere from Etudiant E,Enseigne ES,Groupe G,Filiere F where E.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and ES.ID_prof = " + Convert.ToInt32(parentUserID) + "  and ES.ID_group=G.ID_group order by F.nomFiliere,G.numgroup,G.annee,E.nom";
            await Task.Run(new Action(AsyncVoid));
            dashboardDatagridView.Columns[0].HeaderText = "ID Student";
            dashboardDatagridView.Columns[1].HeaderText = "Last Name";
            dashboardDatagridView.Columns[2].HeaderText = "First Name";
            dashboardDatagridView.Columns[3].HeaderText = "Email";
            dashboardDatagridView.Columns[4].HeaderText = "Gender";
            dashboardDatagridView.Columns[5].HeaderText = "Group Number";
            dashboardDatagridView.Columns[6].HeaderText = "Group Year";
            dashboardDatagridView.Columns[7].HeaderText = "Section";

        }
    }
}
