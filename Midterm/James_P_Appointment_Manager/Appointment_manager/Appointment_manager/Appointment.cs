using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace Appointment_manager
{
    public class Appointment
    {
        private DateTime sTime;
        private DateTime eTime;
        private string client;
        private string location;
        private string comments;
        private string feedback;
        private string feedback2;

        public string Feedback
        {
            get { return feedback; }
        }

        public string Feedback2
        {
            get { return feedback2; }
        }

        public DateTime STime
        {
            get { return sTime; }

            set{sTime = value;}
        }

        public DateTime ETime
        {
            get { return eTime; }

            set
            {
                eTime = value;
                //check to insure that the end time is later than the start time
                if (eTime <= sTime)
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
            string strSQL = "INSERT INTO Appointment (STime, ETime, Client, Location, Comments) VALUES (@STime, @ETime, @Client, @Location, @Comments);";

            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Appointment.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;

            //send command
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //fill in the parameters
            comm.Parameters.AddWithValue("@STime", sTime);
            comm.Parameters.AddWithValue("@ETime", eTime);
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
    }
}
