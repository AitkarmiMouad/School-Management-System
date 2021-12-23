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
    public partial class StudentScheduleForm : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;
        public StudentScheduleForm()
        {
            InitializeComponent();
        }

        private DateTime GetMonday(DateTime date)
        {
            DayOfWeek d = date.DayOfWeek;

            if (d == DayOfWeek.Monday)
                return date;
            else if (d == DayOfWeek.Tuesday)
                return date.AddDays(-1);
            else if (d == DayOfWeek.Wednesday)
                return date.AddDays(-2);
            else if (d == DayOfWeek.Thursday)
                return date.AddDays(-3);
            else if (d == DayOfWeek.Friday)
                return date.AddDays(-4);
            else if (d == DayOfWeek.Saturday)
                return date.AddDays(-5);
            else if (d == DayOfWeek.Sunday)
                return date.AddDays(-6);
            else return DateTime.Now;
        }
        private DateTime GetFriday(DateTime date)
        {
            DayOfWeek d = date.DayOfWeek;

            if (d == DayOfWeek.Monday)
                return date;
            else if (d == DayOfWeek.Tuesday)
                return date.AddDays(3);
            else if (d == DayOfWeek.Wednesday)
                return date.AddDays(2);
            else if (d == DayOfWeek.Thursday)
                return date.AddDays(1);
            else if (d == DayOfWeek.Friday)
                return date;
            else if (d == DayOfWeek.Saturday)
                return date.AddDays(-1);
            else if (d == DayOfWeek.Sunday)
                return date.AddDays(-2);
            else return DateTime.Now;
        }

        private void insertInTableLayout(TableLayoutPanel t,DataRow row)
        {
            foreach (Control c in t.Controls)
            {
                if (t.GetRow(c) == 0)
                {
                    (c as Label).Text = row[0].ToString();
                }
                if (t.GetRow(c) == 1)
                {
                    (c as Label).Text = row[1].ToString();
                }
                if (t.GetRow(c) == 2)
                {
                    (c as Label).Text = (row[6] == null) ? "..." : row[6].ToString();
                    if ((c as Label).Text != "...") (c as Label).ForeColor = Color.Gold;
                }
            }
        }
        private void StudentScheduleForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                // class group dial etudiant
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select allTable.*,E.nomExam from (select P.prenom,S.SalleName,SG.timeFrom,SG.timeTo,SG._date,SG.ID_Salle_Group AS 'idSalleGroup' from Salle_Groupe SG,Prof P,Salle S where SG.ID_group in(select ID_group from Etudiant where ID_etudiant=" + parentUserID + ") and SG._date between '" + GetMonday(DateTime.Now).ToString("yyyy-MM-dd") + "' and '" + GetFriday(DateTime.Now).ToString("yyyy-MM-dd") + "' and P.ID_prof=SG.ID_prof and SG.ID_salle=S.ID_salle) allTable full JOIN Exam E ON allTable.idSalleGroup=E.ID_Salle_Group", connection);
                dt.Load(command.ExecuteReader());
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[4] != DBNull.Value)
                        {
                            if (Convert.ToDateTime(row[4]).DayOfWeek == DayOfWeek.Monday)
                            {
                                if (Convert.ToInt32(row[2]) == 8 && Convert.ToInt32(row[3]) == 10)
                                {
                                    insertInTableLayout(Lundi8_10, row);
                                }
                                if (Convert.ToInt32(row[2]) == 10 && Convert.ToInt32(row[3]) == 12)
                                {
                                    insertInTableLayout(Lundi10_12, row);
                                }
                                if (Convert.ToInt32(row[2]) == 14 && Convert.ToInt32(row[3]) == 16)
                                {
                                    insertInTableLayout(Lundi2_4, row);
                                }
                                if (Convert.ToInt32(row[2]) == 16 && Convert.ToInt32(row[3]) == 18)
                                {
                                    insertInTableLayout(Lundi4_6, row);
                                }
                            }

                            else if (Convert.ToDateTime(row[4]).DayOfWeek == DayOfWeek.Tuesday)
                            {
                                if (Convert.ToInt32(row[2]) == 8 && Convert.ToInt32(row[3]) == 10)
                                {
                                    insertInTableLayout(Mardi8_10, row);
                                }
                                if (Convert.ToInt32(row[2]) == 10 && Convert.ToInt32(row[3]) == 12)
                                {
                                    insertInTableLayout(Mardi10_12, row);
                                }
                                if (Convert.ToInt32(row[2]) == 14 && Convert.ToInt32(row[3]) == 16)
                                {
                                    insertInTableLayout(Mardi2_4, row);
                                }
                                if (Convert.ToInt32(row[2]) == 16 && Convert.ToInt32(row[3]) == 18)
                                {
                                    insertInTableLayout(Mardi4_6, row);
                                }
                            }



                            else if (Convert.ToDateTime(row[4]).DayOfWeek == DayOfWeek.Wednesday)
                            {
                                if (Convert.ToInt32(row[2]) == 8 && Convert.ToInt32(row[3]) == 10)
                                {
                                    insertInTableLayout(Mercredi8_10, row);
                                }
                                if (Convert.ToInt32(row[2]) == 10 && Convert.ToInt32(row[3]) == 12)
                                {
                                    insertInTableLayout(Mercredi10_12, row);
                                }
                                if (Convert.ToInt32(row[2]) == 14 && Convert.ToInt32(row[3]) == 16)
                                {
                                    insertInTableLayout(Mercredi2_4, row);
                                }
                                if (Convert.ToInt32(row[2]) == 16 && Convert.ToInt32(row[3]) == 18)
                                {
                                    insertInTableLayout(Mercredi4_6, row);
                                }
                            }



                            else if (Convert.ToDateTime(row[4]).DayOfWeek == DayOfWeek.Thursday)
                            {
                                if (Convert.ToInt32(row[2]) == 8 && Convert.ToInt32(row[3]) == 10)
                                {
                                    insertInTableLayout(Jeudi8_10, row);
                                }
                                if (Convert.ToInt32(row[2]) == 10 && Convert.ToInt32(row[3]) == 12)
                                {
                                    insertInTableLayout(Jeudi10_12, row);
                                }
                                if (Convert.ToInt32(row[2]) == 14 && Convert.ToInt32(row[3]) == 16)
                                {
                                    insertInTableLayout(Jeudi2_4, row);
                                }
                                if (Convert.ToInt32(row[2]) == 16 && Convert.ToInt32(row[3]) == 18)
                                {
                                    insertInTableLayout(Jeudi4_6, row);
                                }

                            }


                            else if (Convert.ToDateTime(row[4]).DayOfWeek == DayOfWeek.Friday)
                            {
                                if (Convert.ToInt32(row[2]) == 8 && Convert.ToInt32(row[3]) == 10)
                                {
                                    insertInTableLayout(Vendredi8_10, row);
                                }
                                if (Convert.ToInt32(row[2]) == 10 && Convert.ToInt32(row[3]) == 12)
                                {
                                    insertInTableLayout(Vendredi10_12, row);
                                }
                                if (Convert.ToInt32(row[2]) == 14 && Convert.ToInt32(row[3]) == 16)
                                {
                                    insertInTableLayout(Vendredi2_4, row);
                                }
                                if (Convert.ToInt32(row[2]) == 16 && Convert.ToInt32(row[3]) == 18)
                                {
                                    insertInTableLayout(Vendredi4_6, row);
                                }
                            }
                        }
                    }
                       
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
