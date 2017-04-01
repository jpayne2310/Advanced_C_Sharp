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
    class PayneTools
    {
        //fill combo box
        public static ComboBox FillClientDDL(ComboBox cb)
        {
            //create databace tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connection string
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";

            //SQL for one person
            string sqlString = "SELECT Client FROM Appointment";

            //define the connection object
            conn.ConnectionString = strConn;

            //get person with matching ID#
            comm.Connection = conn;
            comm.CommandText = sqlString;

            //open DB connection
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
        
            //loop thur datareader and populate combobox
            while (dr.Read())
            {
                cb.Items.Add(dr["Client"].ToString());
            }
            
            cb.Items.Insert(0, "");
            cb.SelectedIndex = 0;
            
            conn.Close();
            dr.Close();

            //return combobox

            return cb;


        }


    }
}
