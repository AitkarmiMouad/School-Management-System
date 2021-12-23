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

    public partial class classShedule : Form
    {
        static string MyConnectionString = ConfigurationManager.ConnectionStrings["schoolManagementConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(MyConnectionString);
        FunctionsClass functions = new FunctionsClass();
        public string parentUserID;

        public classShedule()
        {
            InitializeComponent();
        }
        private void classShedule_Load(object sender, EventArgs e)
        {
            Datepicker.Value = DateTime.Now;
            functions.fillComboBox(connection, sectionComboBox, "select nomFiliere,ID_filiere from Filiere where ID_dp=" + parentUserID);
            functions.fillComboBox(connection, classRoomComboBox, "select SalleName,ID_salle from Salle ");

            sectionComboBox.SelectedIndex = -1;
            groupComboBox.SelectedIndex = -1;
            classRoomComboBox.SelectedIndex = -1;
            groupComboBox.Enabled = false;

        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectionComboBox.SelectedIndex != -1)
            {
                functions.fillComboBox(connection, groupComboBox, "select CONVERT(nvarchar(10),annee)+CONVERT(nvarchar(10),numgroup) as 'display',ID_group from Groupe where ID_filiere=" + sectionComboBox.SelectedValue);                
                groupComboBox.Enabled = true;
            }
            else
            {
                groupComboBox.Enabled = false;
            }
        }
        
        private void classRoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromComboBox.Items.Clear();
            if (classRoomComboBox.SelectedIndex != -1)
            {
                
                FromComboBox.Items.AddRange(new object[] { 8,10,14,16 });
                FromComboBox.SelectedIndex = -1;
                FromComboBox.Enabled = true;

            }
            else
            {
                FromComboBox.Enabled = false;
            }
        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromComboBox.SelectedIndex != -1)
            {
                ToComboBox.Items.Clear();
                //List<int> toListTime=new List<int>();
                int from = Convert.ToInt32(FromComboBox.SelectedItem.ToString())+2;
                ToComboBox.Items.Add(from);
                ToComboBox.SelectedIndex = 0;
                ToComboBox.Enabled = true;
            }
            else
            {
                ToComboBox.Enabled = false;
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex != -1)
            {
                functions.fillComboBox(connection, lastNameComboBox, "select DISTINCT P.nom,P.prenom from Prof P,Enseigne E where P.ID_prof=E.ID_prof and E.ID_group=" + groupComboBox.SelectedValue);
                lastNameComboBox.SelectedIndex = -1;
                lastNameComboBox.Enabled = true;

            }
            else
            {
                lastNameComboBox.Enabled = false;
            }
        }

        private void lastNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex != -1)
            {
                functions.fillComboBox(connection, firstNameComboBox, "select  prenom,ID_prof from Prof where nom like'" + lastNameComboBox.SelectedValue+"'");
                firstNameComboBox.SelectedIndex = -1;
                firstNameComboBox.Enabled = true;

            }
            else
            {
                firstNameComboBox.Enabled = false;
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            try
            {
                // check combobox if empty
                foreach (Control c in teacherSalle.Controls)
                {
                    if(c is ComboBox)
                    {
                        if((c as ComboBox).SelectedIndex == -1)
                        {
                            MessageBox.Show("Please Enter All Salle Values", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                foreach (Control c in teacherGroup.Controls)
                {
                    if (c is ComboBox)
                    {
                        if ((c as ComboBox).SelectedIndex == -1)
                        {
                            MessageBox.Show("Please Enter All Teacher Values", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (connection.State == ConnectionState.Closed) connection.Open();
                DateTime dateValue = Convert.ToDateTime(Datepicker.Value);
                string professeur;
                string x = "select ID_prof from Prof where nom like '" + lastNameComboBox.SelectedValue + "' and prenom like '" + firstNameComboBox.Text + "' and ID_prof in(select ID_prof from Enseigne where ID_group = " + groupComboBox.SelectedValue+ ")";
                SqlCommand profCommand = new SqlCommand(x, connection);
                SqlDataReader reader=profCommand.ExecuteReader();
                reader.Read();
                professeur = reader.GetValue(0).ToString();


                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                //check if row exist
                string queryExist = "select * from Salle_Groupe where ID_salle=" + classRoomComboBox.SelectedValue + " and ID_group=" + groupComboBox.SelectedValue + " and timeFrom=" + FromComboBox.SelectedItem + " and timeTo=" + ToComboBox.SelectedItem + " and _date like '" + dateValue.ToString("yyyy-MM-dd") + "' and ID_prof=" + professeur ;                
                SqlCommand commandIfExist = new SqlCommand(queryExist, connection);
                SqlDataReader reader1 = commandIfExist.ExecuteReader();
                reader1.Read();
                if (reader1.HasRows)
                {
                    MessageBox.Show("This Class is already Submited", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                //insert into Table Salle groupe
                string query = "insert into Salle_Groupe (ID_salle,ID_group,timeFrom,timeTo,_date,ID_prof) values(" + classRoomComboBox.SelectedValue + "," + groupComboBox.SelectedValue + "," + FromComboBox.SelectedItem + "," + ToComboBox.SelectedItem + ",@p," + professeur + ")";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@p", dateValue.ToString("yyyy-MM-dd"));

                command.ExecuteNonQuery();

                MessageBox.Show("Class Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void RefreshAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = "delete from Salle_Groupe";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query1 = "DBCC CHECKIDENT(Salle_Groupe,RESEED,0)";
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.ExecuteNonQuery();
                MessageBox.Show("Schedule Cleared Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // check combobox if empty
                foreach (Control c in teacherSalle.Controls)
                {
                    if (c is ComboBox)
                    {
                        if ((c as ComboBox).SelectedIndex == -1)
                        {
                            MessageBox.Show("Please Enter All Salle Values", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                foreach (Control c in teacherGroup.Controls)
                {
                    if (c is ComboBox)
                    {
                        if ((c as ComboBox).SelectedIndex == -1)
                        {
                            MessageBox.Show("Please Enter All Teacher Values", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (connection.State == ConnectionState.Closed) connection.Open();
                DateTime dateValue = Convert.ToDateTime(Datepicker.Value);
                string professeur;
                string x = "select ID_prof from Prof where nom like '" + lastNameComboBox.SelectedValue + "' and prenom like '" + firstNameComboBox.Text + "' and ID_prof in(select ID_prof from Enseigne where ID_group = " + groupComboBox.SelectedValue + ")";
                SqlCommand profCommand = new SqlCommand(x, connection);
                SqlDataReader reader = profCommand.ExecuteReader();
                reader.Read();
                professeur = reader.GetValue(0).ToString();


                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                //check if row exist
                string queryExist = "select * from Salle_Groupe where ID_salle=" + classRoomComboBox.SelectedValue + " and ID_group=" + groupComboBox.SelectedValue + " and timeFrom=" + FromComboBox.SelectedItem + " and timeTo=" + ToComboBox.SelectedItem + " and _date like '" + dateValue.ToString("yyyy-MM-dd") + "' and ID_prof=" + professeur;
                SqlCommand commandIfExist = new SqlCommand(queryExist, connection);
                SqlDataReader reader1 = commandIfExist.ExecuteReader();
                reader1.Read();
                if (reader1.HasRows)
                {
                    MessageBox.Show("This Class is already Submited", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                // week 2 row exist
                string queryExist2 = "select * from Salle_Groupe where ID_salle=" + classRoomComboBox.SelectedValue + " and ID_group=" + groupComboBox.SelectedValue + " and timeFrom=" + FromComboBox.SelectedItem + " and timeTo=" + ToComboBox.SelectedItem + " and _date like '" + dateValue.AddDays(7).ToString("yyyy-MM-dd") + "' and ID_prof=" + professeur;
                SqlCommand commandIfExist2 = new SqlCommand(queryExist2, connection);
                SqlDataReader reader2 = commandIfExist2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows)
                {
                    MessageBox.Show("This Class is already Submited", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                //insert into Table Salle groupe
                string query = "insert into Salle_Groupe (ID_salle,ID_group,timeFrom,timeTo,_date,ID_prof) values(" + classRoomComboBox.SelectedValue + "," + groupComboBox.SelectedValue + "," + FromComboBox.SelectedItem + "," + ToComboBox.SelectedItem + ",@p," + professeur + ")";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@p", dateValue.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();

                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                // insert week 2
                string query2 = "insert into Salle_Groupe (ID_salle,ID_group,timeFrom,timeTo,_date,ID_prof) values(" + classRoomComboBox.SelectedValue + "," + groupComboBox.SelectedValue + "," + FromComboBox.SelectedItem + "," + ToComboBox.SelectedItem + ",@p," + professeur + ")";
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@p", dateValue.AddDays(7).ToString("yyyy-MM-dd"));
                command2.ExecuteNonQuery();

                MessageBox.Show("Class Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
