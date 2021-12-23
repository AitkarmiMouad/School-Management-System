using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace School_Management_System
{
    class FunctionsClass
    {
        public void FullNameMainForm(SqlConnection connection,string tableUser,string Col, string UserId,string type,Label Target)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand userFullName = new SqlCommand("select nom,prenom from "+tableUser+" where "+Col+"=@ID", connection);
                userFullName.Parameters.AddWithValue("@ID", Convert.ToInt32(UserId));
                SqlDataReader reader = userFullName.ExecuteReader();
                reader.Read();
                Target.Text = reader.GetValue(0).ToString() + " " + reader.GetValue(1) + "\n"+type;

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

        public void GroupIntoLabel(SqlConnection connection,Label target,string value)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select CONVERT(nvarchar(15),F.nomFiliere)+' '+ CONVERT(nvarchar(15),G.annee)+CONVERT(nvarchar(15),G.numgroup) as 'Group' from Etudiant E,Groupe G,Filiere F where E.ID_group=G.ID_group and G.ID_filiere=F.ID_filiere and E.ID_group=@group", connection);
                command.Parameters.AddWithValue("@group", Convert.ToInt32(value));
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                target.Text = reader.GetValue(0).ToString();
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
        public void DashboardLabels(SqlConnection connection, string tableUser,string value,Label Target,string Condition)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select count("+value+") from " + tableUser + Condition , connection);
                Target.Text = command.ExecuteScalar().ToString();
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

        public DataTable dgvDataReader(SqlConnection connection,DataGridView dv,string query)
        {
            DataTable dt;
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dv.Invoke((MethodInvoker)delegate
                {
                    dv.DataSource = dt;
                });
                return dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt = new DataTable();
                return dt;
            }
            finally
            {
                connection.Close();
            }
        }

        public void fillComboBox(SqlConnection connection,ComboBox target,string query)
        {
            DataTable dt = new DataTable();

            try
            {
                if(connection.State==ConnectionState.Closed)connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                dt.Load(command.ExecuteReader());
                target.ValueMember = dt.Columns[1].ToString();
                target.DisplayMember = dt.Columns[0].ToString();
                target.DataSource = dt;
                
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

        public void fillComboBoxAndGridView(SqlConnection connection, ComboBox target,DataGridView dv, string query1,string query2)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand(query1, connection);
                dt.Load(command.ExecuteReader());
                target.ValueMember = dt.Columns[1].ToString();
                target.DisplayMember = dt.Columns[0].ToString();
                target.DataSource = dt;
                connection.Close();
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command1 = new SqlCommand(query2, connection);
                dt2.Load(command1.ExecuteReader());
                dv.DataSource = dt2;

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

        public bool CheckRegex(string str,string reg,string message)
        {
            Regex regex = new Regex(reg);
            if (!regex.IsMatch(str))
            {
                MessageBox.Show(message);
                return true;
            }
            else {
                return false;
            }
        }

        public DataTable ShowAccountInfo(SqlConnection connection, string tableUser, string ConditionId)
        {
            try
            {
                DataTable dt = new DataTable();
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("select * from " + tableUser + ConditionId, connection);
                dt.Load(command.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
