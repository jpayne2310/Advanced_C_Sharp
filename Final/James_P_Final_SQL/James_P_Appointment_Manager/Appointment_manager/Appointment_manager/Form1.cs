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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PayneTools.FillClientDDL(cmbClient);

            //format for date and time
            dtpStartDT.CustomFormat = "MM-d-yyyy  HH:mm";
            dtpEndingDT.CustomFormat = "MM-d-yyyy  HH:mm";
        }

        //Overload Constructor
        public Form1(Int32 intAppointment_ID)
        {
            InitializeComponent();
            PayneTools.FillClientDDL(cmbClient);

            //disable buttons when there is no need for them
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;

            //get data for one person and fill the fields
            Appointment temp = new Appointment();
            SqlDataReader dr = temp.FindOneAppointment(intAppointment_ID);

            //fill FindAppointment into form
            while (dr.Read())
            {
                dtpStartDT.Value = Convert.ToDateTime(dr["STD"]);
                dtpEndingDT.Value = Convert.ToDateTime(dr["ETD"]);
                cmbClient.SelectedItem = dr["Client"].ToString();
                txtLocation.Text = dr["Location"].ToString();
                txtComments.Text = dr["Comments"].ToString();
               
                //added this label to be able to use the variable
                labLocation_ID.Text = dr["ID"].ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //reset error output labels
            labFeedback.Text = "";
            labFeedback2.Text = "";
            //define object for class
            Appointment contactBody = new Appointment();
            contactBody.STD = dtpStartDT.Value;
            contactBody.ETD = dtpEndingDT.Value;
            //allow combo box selection or texted input
            if (cmbClient.SelectedIndex == -1 || cmbClient.SelectedIndex == null)
                {
                    contactBody.Client = cmbClient.Text;
                }
            else
                {
                    contactBody.Client = cmbClient.SelectedItem.ToString();
                }
            contactBody.Location = txtLocation.Text;
            contactBody.Comments = txtComments.Text;

            
            //check for error
            if (contactBody.Feedback2.Contains("ERROR:"))
            {
                labFeedback2.Text = contactBody.Feedback2;
            }

            else
            {
                //send object too database
                labFeedback.Text = contactBody.AddRecord();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                //create a new object for the delete function 
                Appointment temp = new Appointment();

                Int32 intAppointment_ID = Convert.ToInt32(labLocation_ID.Text);

                //enable ID to be used for function
                Int32 intRecords = temp.DeleteOneAppointment(intAppointment_ID);

                //display acknowledgement
                lblFeedback.Text = intRecords.ToString() + " Records Deleted.";
            }
            else if (dr == DialogResult.No)
            {
                lblFeedback.Text = "Please make up your mind!!! ";
            }
            else if (dr == DialogResult.Cancel)
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
                Appointment temp = new Appointment();

                //Fill in data
                temp.STD = dtpStartDT.Value;
                temp.ETD = dtpEndingDT.Value;
                //allow combo box selection or texted input
                if (cmbClient.SelectedIndex == -1 || cmbClient.SelectedIndex == null)
                {
                    temp.Client = cmbClient.Text;
                }
                else
                {
                    temp.Client = cmbClient.SelectedItem.ToString();
                }
                temp.Location += txtLocation.Text;
                temp.Comments += txtComments.Text;
               
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
                    Int32 intRecords = temp.UpdateOneAppointment(Convert.ToInt32(labLocation_ID.Text));
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

        public void clear()
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
            //clear feedback labels
            lblFeedback.Text = "";
            labFeedback2.Text = "";
            labFeedback.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
