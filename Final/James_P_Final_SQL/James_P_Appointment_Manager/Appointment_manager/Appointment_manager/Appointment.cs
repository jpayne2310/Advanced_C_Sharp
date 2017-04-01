using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Appointment_manager
{
    public class Appointment
    {
        private DateTime std;
        private DateTime etd;
        private string client;
        private string location;
        private string comments;
        private string feedback;
        private string feedback2;

        #region Gets&Sets
        public string Feedback
        {
            get { return feedback; }
        }

        public string Feedback2
        {
            get { return feedback2; }
        }

        public DateTime STD
        {
            get { return std; }

            set{std = value;}
        }

        public DateTime ETD
        {
            get { return etd; }

            set 
            {
                etd = value;
                //check to insure that the end time is later than the start time
                if (etd <= std)
                {
                    feedback2 += "ERROR: Ending time must be later than starting time.\n";
                }
            }
        }

        public string Client
        {
            get { return client; }
            set
            {
                //check to make sure field is filled in
                if (myValidate.FilledIn(value) == false)
                {
                    feedback2 += "ERROR: You must enter who your appointment is with.\n";
                }
                else
                {
                    client = value;
                }
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                //check to make sure field is filled in
                if (myValidate.FilledIn(value) == false)
                {
                    feedback2 += "ERROR: Location Field Required.\n";
                }
                else
                {
                    location = value;
                }
            }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        #endregion


        //Set Constructor
        public Appointment()
            {
                feedback = "";
                feedback2 = "";  
            }

        public string AddRecord()
        {
            //reset the string
            string strFeedback = "";
            //SQL command line
            string strSQL = "INSERT INTO Appointment (STD, ETD, Client, Location, Comments) VALUES (@STD, @ETD, @Client, @Location, @Comments);";

            SqlConnection conn = new SqlConnection();
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";
            conn.ConnectionString = strConn;

            //send command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //fill in the parameters
            comm.Parameters.AddWithValue("@STD", std.ToString());
            comm.Parameters.AddWithValue("@ETD", etd.ToString());
            comm.Parameters.AddWithValue("@Client", client);
            comm.Parameters.AddWithValue("@Location", location);
            comm.Parameters.AddWithValue("@Comments", comments);

            try
            {
                conn.Open();

                //give command and disconnect
                strFeedback = comm.ExecuteNonQuery().ToString() + " Record Added to Database Table";
                conn.Close();
            }
            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }

            return strFeedback;
        }

        public DataSet SearchRecords(string client, string location, string startTime, string endTime)
        {
            //create an empty data continer
            DataSet ds = new DataSet();

            //make connect/command objects and set properties
            SqlConnection conn = new SqlConnection();
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM Appointment";

            //search by date 'and' time
            if (startTime.Length > 0)
            {
                //default for no end time entered
                if (endTime.Length < 1)
                {
                    endTime = (startTime + " 23:59");
                }
                comm.CommandText += " WHERE STD between @STD AND @ETD";
                comm.Parameters.AddWithValue("@STD", startTime);
                comm.Parameters.AddWithValue("@ETD", endTime);
            }

            //search by client
            if (client.Length > 0)
            {
                comm.CommandText += " WHERE 0=0 AND Client LIKE @Client";
                comm.Parameters.AddWithValue("@Client", "%" + client + "%");
            }

            //search by location
            if (location.Length > 0)
            {
                comm.CommandText += " WHERE 0=0 AND Location LIKE @Location";
                comm.Parameters.AddWithValue("@Location", "%" + location + "%");
            }


            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;


            //perform search and fill ds
            conn.Open();
            da.Fill(ds, "Appointment");
            conn.Close();
            //return the results
            return ds;
        }



        public SqlDataReader FindOneAppointment(int intAppointment_ID)
        {
            //create databace tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connection string
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";


            //SQL for one person
            string sqlString = "SELECT ID, STD, ETD, Client, Location, Comments FROM Appointment WHERE ID = @Appointment_ID;";

            //define the connection object
            conn.ConnectionString = strConn;

            //get person with matching ID#
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Appointment_ID", intAppointment_ID);

            //open DB connection
            conn.Open();

            //return data
            return comm.ExecuteReader();
        }

        public Int32 DeleteOneAppointment(int intAppointment_ID)
        {
            Int32 intRecords = 0;
            //create databace tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connection string
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";


            //SQL command line
            string strSQL = "DELETE FROM Appointment WHERE ID = @Appointment_ID;";

            conn.ConnectionString = strConn;

            //get appointment with matching ID#
            comm.Connection = conn;
            comm.CommandText = strSQL;
            comm.Parameters.AddWithValue("@Appointment_ID", intAppointment_ID);

            //open DB connection
            conn.Open();

            //execute deletion and record the number of records effected
            intRecords = comm.ExecuteNonQuery();

            //close the connection
            conn.Close();

            return intRecords;

        }


        public Int32 UpdateOneAppointment(int AppointmentID)
        {
            Int32 IntRecords = 0;
            //string strSQL = "INSERT INTO Appointment (STD, ETD, Client, Location, Comments) VALUES (@STD, @ETD, @Client, @Location, @Comments);";
            string strSQL = "UPDATE Appointment SET STD = @STD, ETD = @ETD, Client = @Client, Location = @Location, Comments = @Comments WHERE ID = @AppointmentID;";

            //create databace tools
            SqlConnection conn = new SqlConnection();

            //connection string
            string strConn = "Server = sql.neit.edu; Database = SE255_jpayne; User Id = SE255_jpayne; Password = 001389421;";
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //fill in the parameters
            comm.Parameters.AddWithValue("@STD", std);
            comm.Parameters.AddWithValue("@ETD", etd);
            comm.Parameters.AddWithValue("@Client", client);
            comm.Parameters.AddWithValue("@Location", location);
            comm.Parameters.AddWithValue("@Comments", comments);
            comm.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                //Open the connection
                conn.Open();

                //Run the Update and store the number of records effected
                IntRecords = comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
               feedback = "ERROR: " + err.Message;
            }

            finally
            {
                //close the connection
                conn.Close();
            }
            return IntRecords;
        }
    }
}
