using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Structure
{
    public partial class Form1 : Form
    {
        //Default Constructor
        public Form1()
        {
            InitializeComponent();
            //set default zip code
            txtzip.Text = "02865";

            //disable buttons when there is no need for them
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;

        }

        //Overload Constructor
        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            //disable buttons when there is no need for them
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;

            //get data for one person and fill the fields
            PersonV2 temp = new PersonV2();
            OleDbDataReader dr = temp.FindOnePerson(intPerson_ID);

            //fill FindOnePerson into form
            while (dr.Read())
            {
                txtfName.Text = dr["FName"].ToString();
                txtmName.Text = dr["MName"].ToString();
                txtlName.Text = dr["LName"].ToString();
                txtstreet1.Text = dr["Street1"].ToString();
                txtstreet2.Text = dr["Street2"].ToString();
                txtcity.Text = dr["City"].ToString();
                txtstate.Text = dr["State"].ToString();
                txtzip.Text = dr["Zip"].ToString();
                txtzip2.Text = dr["Zip2"].ToString();
                txtphone.Text = dr["Phone"].ToString();
                txtemail.Text = dr["Email"].ToString();
                txtfacebook.Text = dr["Facebook"].ToString();
                //added this labe to be able to use the variable
                labPerson_ID.Text = dr["ID"].ToString();
            }
        }


            private void btnSubmit_Click(object sender, EventArgs e)
            {
                PersonV2 body1234 = new PersonV2();
                //assign body parts
                body1234.FName = txtfName.Text;
                body1234.MName += txtmName.Text;
                body1234.LName += txtlName.Text;
                body1234.Street1 += txtstreet1.Text;
                body1234.Street2 += txtstreet2.Text;
                body1234.City += txtcity.Text;
                body1234.State += txtstate.Text;
                body1234.Zip += txtzip.Text;
                body1234.Zip2 += txtzip2.Text;
                body1234.Phone += txtphone.Text;
                body1234.Email += txtemail.Text;
                body1234.Facebook += txtfacebook.Text;

                //check for an error
                if (body1234.Feedback.Contains("ERROR:"))
                {
                    lblFeedback.Text = body1234.Feedback;
                }
                else if (body1234.Feedback2.Contains("ERROR:"))
                {
                    lblFeedback.Text = body1234.Feedback2;
                }
                //output label and list
                else
                {
                    //FillLabel(body1234);
                   // FillList(body1234);

                    //send object too database
                    lblFeedback.Text = body1234.AddRecord();
                }
            }
        
            public void FillLabel(PersonV2 temp)
            {
                //output for label taken from text boxes
                lblFeedback.Text = temp.FName + "\n";
                lblFeedback.Text += temp.MName + "\n";
                lblFeedback.Text += temp.LName + "\n";
                lblFeedback.Text += temp.Street1 + "\n";
                lblFeedback.Text += temp.Street2 + "\n";
                lblFeedback.Text += temp.City + "\n";
                lblFeedback.Text += temp.State + "\n";
                lblFeedback.Text += temp.Zip + "\n";
                lblFeedback.Text += temp.Zip2 + "\n";
                lblFeedback.Text += temp.Phone + "\n";
                lblFeedback.Text += temp.Email + "\n";
                lblFeedback.Text += temp.Facebook + "\n";
            }

            //I just wanted to see this work
            public void FillList(PersonV2 temp)
            {
                listBox1.Items.Add(temp.FName + " " + temp.MName + " " + temp.LName + " " +
                    temp.Street1 + " " + temp.Street2 + " " + temp.City + " " +
                    temp.State + " " + temp.Zip + " " + temp.Zip2 + " " + temp.Phone + " " +
                    temp.Email + " " + temp.Facebook);
            }
            
            private void btnClear_Click(object sender, EventArgs e)
            {
                //looping to clear form items
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                    else if (c is ComboBox)
                        ((ComboBox)c).SelectedIndex = 0;
                    else if (c is ListBox)
                        ((ListBox)c).Items.Clear();
                    else if (c is MaskedTextBox)
                        ((MaskedTextBox)c).Clear();
                }
                //clear feedback label
                lblFeedback.Text = "";
                //reset default zip code
                txtzip.Text = "02865";
            }

            private void DisplayInfo()
            {
                //Not sure why, but why not?
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                 DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if(dr == DialogResult.Yes)
                    {

                        //create a new object for the delete function 
                        PersonV2 temp = new PersonV2();

                        Int32 intPerson_ID = Convert.ToInt32(labPerson_ID.Text);

                        //enable ID to be used for function
                        Int32 intRecords = temp.DeleteOnePerson(intPerson_ID);

                        //display acknowledgement
                        lblFeedback.Text = intRecords.ToString() + " Records Deleted.";
                    }
                else if (dr == DialogResult.No)
                    {
                        lblFeedback.Text = "Please make up your mind!!! ";
                    }
                else if(dr == DialogResult.Cancel)
                    {
                        lblFeedback.Text = "You should reconsider\n";
                        lblFeedback.Text += "Sometimes you just\n have to let go!";
                    }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

              DialogResult dr = MessageBox.Show("Are you sure you want to update this record?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

              if (dr == DialogResult.Yes)
              {
                  //create a new object for the update function 
                  PersonV2 temp = new PersonV2();

                  //Fill in data
                  temp.FName = txtfName.Text;
                  temp.MName += txtmName.Text;
                  temp.LName += txtlName.Text;
                  temp.Street1 += txtstreet1.Text;
                  temp.Street2 += txtstreet2.Text;
                  temp.City += txtcity.Text;
                  temp.State += txtstate.Text;
                  temp.Zip += txtzip.Text;
                  temp.Zip2 += txtzip2.Text;
                  temp.Phone += txtphone.Text;
                  temp.Email += txtemail.Text;
                  temp.Facebook += txtfacebook.Text;
                  //check for an error
                  if (temp.Feedback.Contains("ERROR:"))
                  {
                      lblFeedback.Text = temp.Feedback;
                  }
                  if (temp.Feedback2.Contains("ERROR:"))
                  {
                      lblFeedback.Text = temp.Feedback2;
                  }
                  //output label and list
                  else
                  {
                      Int32 intRecords = temp.UpdateOnePerson(Convert.ToInt32(labPerson_ID.Text));
                      lblFeedback.Text = intRecords.ToString() + " Records Updated.";
                  }
              }
              else if (dr == DialogResult.No)
                  {
                      lblFeedback.Text = "Sometimes it's just better to \nleave things the way they are.";
                  }
              else if (dr == DialogResult.Cancel)
                  {
                      lblFeedback.Text = "You are somewhat indecisive!";
                  }
            }
       }
}
