using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Structure
{
    public class PersonV2: Person
    {
        private string facebook;
        private string feedback2;


        public string Feedback2
        {
            get { return feedback2; }

        }

        public string Facebook 
        {
            get { return facebook; }
            set
            {
                //check for valid email 
                if (myValidate.IsFacebookValid(value) == false)
                {
                    feedback2 = "ERROR: Invalid Facebook address format.\n";
                }
                else
                {
                    facebook = value;
                }
            }
        }       

        public PersonV2()
            : base()
        {
            feedback2 = "";
            
        }

        public string AddRecord()
        {
            //string results = "Connected";
            string strFeedback = "";
            //SQL command line
            string strSQL = "INSERT INTO Persons (FName, MName, LName, Street1, Street2, City, State, Zip, Zip2, Email, Facebook) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Zip2, @Email, @Facebook);"; 

            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contacts.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;

            //send command
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //Fill in the parameters
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Zip2", Zip2);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Facebook", Facebook);

            try
            {
                conn.Open();

                //bark command and hangup
                strFeedback = comm.ExecuteNonQuery().ToString() + " Records Added";
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
