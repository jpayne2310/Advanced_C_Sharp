﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Structure
{
    public class PersonV2 : Person
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
            string strSQL = "INSERT INTO Persons (FName, MName, LName, Street1, Street2, City, State, Zip, Zip2, Phone, Email, Facebook) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Zip2, @Phone, @Email, @Facebook);";

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
            comm.Parameters.AddWithValue("@Phone", Phone);
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

        public DataSet SearchRecords(string fname, string lname)
        {
            //create an empty data continer
            DataSet ds = new DataSet();

            //make connect/command objects and set properties
            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contacts.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;

            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM Persons WHERE 0=0";

            if (fname.Length > 0)
            {
                comm.CommandText += " AND FName LIKE @Fname";
                comm.Parameters.AddWithValue("@FName", "%" + fname + "%");
            }


            if (lname.Length > 0)
            {
                comm.CommandText += " AND LName LIKE @Lname";
                comm.Parameters.AddWithValue("@LName", "%" + lname + "%");
            }

            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;


            //perform search and fill ds
            conn.Open();
            da.Fill(ds, "Persons");
            conn.Close();
            //return the results
            return ds;
        }



        public OleDbDataReader FindOnePerson(int intPerson_ID)
        {
            //create databace tools
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand comm = new OleDbCommand();

            //connection string
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contacts.accdb;Persist Security Info=False;";


            //SQL for one person
            string sqlString = "SELECT ID, FName, MName, LName, Street1, Street2, City, State, Zip, Zip2, Phone, Email, Facebook FROM Persons WHERE ID = @Person_ID;";

            //define the connection object
            conn.ConnectionString = strConn;

            //get person with matching ID#
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //open DB connection
            conn.Open();

            //return data
            return comm.ExecuteReader();
        }

        public Int32 DeleteOnePerson(int intPerson_ID)
        {
            Int32 intRecords = 0;
            //create databace tools
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand comm = new OleDbCommand();

            //connection string
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contacts.accdb;Persist Security Info=False;";


            //SQL command line
            string strSQL = "DELETE FROM Persons WHERE ID = @Person_ID;";

            conn.ConnectionString = strConn;

            //get person with matching ID#
            comm.Connection = conn;
            comm.CommandText = strSQL;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //open DB connection
            conn.Open();

            //execute deletion and record the number of records effected
            intRecords = comm.ExecuteNonQuery();

            //close the connection
            conn.Close();

            return intRecords;

        }


        public Int32 UpdateOnePerson(int personID)
        {
            Int32 IntRecords = 0;

            string strSQL = "UPDATE Persons SET FName = @FName, MName = @MName, LName = @LNname, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, Zip = @Zip, Zip2 = @Zip2, Phone = @Phone, Email = @Email, Facebook = @Facebook WHERE ID = @Person_ID;";

            //create databace tools
            OleDbConnection conn = new OleDbConnection();

            //connection string
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contacts.accdb;Persist Security Info=False;";
            conn.ConnectionString = strConn;

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
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Facebook", Facebook);
            comm.Parameters.AddWithValue("@Person_ID", personID);

            try
            {
                //Open the connection
                conn.Open();

                //Run the Update and store the number of records effected
                IntRecords = comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
            }
            finally
            {
                //close the connection
                conn.Close();
            }
            return IntRecords;
        }
    };
}
