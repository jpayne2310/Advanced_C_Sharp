using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Appointment_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpStartDT.CustomFormat = "MM-d-yyyy  hh:mm";
            dtpEndingDT.CustomFormat = "MM-d-yyyy  hh:mm";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //reset error output labels
            labFeedback.Text = "";
            labFeedback2.Text = "";
            //define object for class
            Appointment contactBody = new Appointment();
            contactBody.STime = dtpStartDT.Value;
            contactBody.ETime = dtpEndingDT.Value;
            contactBody.Client = txtClient.Text;
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
            labFeedback.Text = "";
            labFeedback2.Text = "";
        }
    }
}
