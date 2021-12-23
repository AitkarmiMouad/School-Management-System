using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace School_Management_System
{    
    public partial class eduDashboardForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        DataTable table;

        public eduDashboardForm()
        {
            InitializeComponent();
        }
        
        public async void eduDashboardForm_Load(object sender, EventArgs e)
        {
            functions.DashboardLabels(connection, "Groupe", "ID_group", dashboardgrouplbl, " where ID_filiere IN(select ID_filiere from Filiere where ID_dp=" + Convert.ToInt32(parentUserID) + ") ");
            functions.DashboardLabels(connection, "Filiere", "ID_filiere", dashboardSectionlbl, " where ID_dp =" + Convert.ToInt32(parentUserID));
            functions.DashboardLabels(connection, "Enseigne", "distinct(ID_prof)", dashboardteacherlbl, " where ID_group IN(select ID_group from Groupe where ID_filiere IN (select ID_filiere from Filiere where ID_dp = " + Convert.ToInt32(parentUserID) + ")) ");
            functions.DashboardLabels(connection, "Etudiant", "ID_etudiant", dashboardstudentlbl, " where ID_group IN(select ID_group from Groupe where ID_filiere IN (select ID_filiere from Filiere where ID_dp = " + Convert.ToInt32(parentUserID) + "))");
            // Data grid View Content
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select * from Filiere";
            await Task.Run(new Action(AsyncVoid));
            if (guna2DataGridView1.Columns.Contains("ID_dp") == true)
            {
                guna2DataGridView1.Columns.Remove("ID_dp");
            }
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Section Name";

        }
        string query;
        private void AsyncVoid()
        {
            table=functions.dgvDataReader(connection, guna2DataGridView1, query);
        }
        private async void dashboardSectionlbl_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select * from Filiere where ID_dp="+parentUserID;
            await Task.Run(new Action(AsyncVoid));
            if (guna2DataGridView1.Columns.Contains("ID_dp") == true)
            {
                guna2DataGridView1.Columns.Remove("ID_dp");                
            }
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Section Name";


        }

        private async void dashboardgrouplbl_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            query = "select G.ID_group,G.numgroup,G.annee,F.nomFiliere from Groupe G,Filiere F where F.ID_filiere=G.ID_filiere and F.ID_dp = " + Convert.ToInt32(parentUserID) + " order by F.nomFiliere,G.numgroup,G.annee ";
            await Task.Run(new Action(AsyncVoid));            
            guna2DataGridView1.Columns[0].HeaderText = "ID group";
            guna2DataGridView1.Columns[1].HeaderText = "Group Number";
            guna2DataGridView1.Columns[2].HeaderText = "Group Year";
            guna2DataGridView1.Columns[3].HeaderText = "Section Of Group";
        }

        private async void dashboardteacherlbl_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            query = "select P.*,count(E.ID_group) from Prof P,Enseigne E where E.ID_prof=P.ID_prof and ID_group in(select ID_group from Groupe where ID_filiere in (select ID_filiere from Filiere where ID_dp = " + Convert.ToInt32(parentUserID) + ")) group by P.ID_prof,P.nom,P.prenom,P.email,P.motdepasse,P.tel,P.sex,P.datedenaiss order by P.nom,P.prenom";
            await Task.Run(new Action(AsyncVoid));
            guna2DataGridView1.Columns[0].HeaderText = "ID Teacher";
            guna2DataGridView1.Columns[1].HeaderText = "Last Name";
            guna2DataGridView1.Columns[2].HeaderText = "First Name";
            guna2DataGridView1.Columns[3].HeaderText = "Email";
            guna2DataGridView1.Columns[4].HeaderText = "Password";
            guna2DataGridView1.Columns[5].HeaderText = "Phone";
            guna2DataGridView1.Columns[6].HeaderText = "Gender";
            guna2DataGridView1.Columns[7].HeaderText = "Birth Day";
            guna2DataGridView1.Columns[8].HeaderText = "Total Groups";
        }

        private async void dashboardstudentlbl_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            query = "select E.*,G.numgroup,G.annee,F.nomFiliere from Etudiant E,Groupe G,Filiere F where E.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and F.ID_dp = " + Convert.ToInt32(parentUserID) + " order by F.nomFiliere,G.numgroup,G.annee,E.nom";
            await Task.Run(new Action(AsyncVoid));
            guna2DataGridView1.Columns[0].HeaderText = "ID Student";
            guna2DataGridView1.Columns[1].HeaderText = "Last Name";
            guna2DataGridView1.Columns[2].HeaderText = "First Name";
            guna2DataGridView1.Columns[3].HeaderText = "Email";
            guna2DataGridView1.Columns[4].HeaderText = "Password";
            guna2DataGridView1.Columns[5].HeaderText = "Phone";
            guna2DataGridView1.Columns[6].HeaderText = "Gender";
            guna2DataGridView1.Columns[7].HeaderText = "Birth Day";
            guna2DataGridView1.Columns[8].HeaderText = "Group Number";
            guna2DataGridView1.Columns[9].HeaderText = "Group Year";
            guna2DataGridView1.Columns[10].HeaderText = "Section";
        }
                
        public void AsyncExportToExcel()
        {
            string strPath;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose Emplacement";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.FileName = "NewFile.xlsx";
            if (DialogResult.OK == (new Invoker(sfd).Invoke()))
            {
                strPath = sfd.FileName;
                if (Path.GetExtension(sfd.FileName).ToLower() != ".xlsx")
                    strPath += ".xlsx";
            }
            else
            {
                return;
            }

            using (var fs = new FileStream(strPath, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Sheet1");

                List<String> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;

                foreach (DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                int rowIndex = 1;
                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    int cellIndex = 0;
                    foreach (String col in columns)
                    {
                        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                        cellIndex++;
                    }

                    rowIndex++;
                }
                workbook.Write(fs);
            }
        }

        private async void ExportToExcelBtn_Click(object sender, EventArgs e)
        {
            await Task.Run(new Action(AsyncExportToExcel));

        }
    }
}
