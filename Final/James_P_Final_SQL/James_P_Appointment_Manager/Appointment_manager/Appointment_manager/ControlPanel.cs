using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Appointment_manager
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();       //create the form instance in memory
            temp.Show();                    //show the form on screen
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                Search temp = new Search();
                temp.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check login

            //if login suceeds shut down login and enable control panel
            int intLevel = contactLogin(txtUName.Text, txtPwd.Text);
            if (intLevel <= 5 && intLevel != 0)
            {
                panLogin.Enabled = false;
                panLogin.Visible = false;

                panControls.Enabled = true;
                panControls.Visible = true;
                labFeedback2.Text = "";
            }

            //if invalid login display message
            else
            {
                panLogin.Enabled = true;
                panLogin.Visible = true;

                panControls.Enabled = false;
                panControls.Visible = false;

                labFeedback2.Text = "Invalid Login";
            }
        }

        private int contactLogin(string strUName, string strPwd)
        {
            //initiate admin variable
            int intAdminLevel = 0;

            //create database reader
            SqlDataReader dr;

            //command for sql statement
            SqlCommand comm = new SqlCommand();

            //sql statement for query
            string strSQL = "SELECT Admin_level FROM contact_users WHERE (UName = @UName AND Pwd = @Pwd)";

            //parameters
            comm.Parameters.AddWithValue("@UName", strUName);
            comm.Parameters.AddWithValue("@Pwd", strPwd);

            SqlConnection conn = new SqlConnection();
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            //get data
            conn.Open();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                intAdminLevel = Convert.ToInt16(dr["Admin_level"].ToString());
            }

            conn.Close();

            return intAdminLevel;
        }

    }
}
