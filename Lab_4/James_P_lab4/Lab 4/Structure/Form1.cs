using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set default zip code
            txtzip.Text = "02865";
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
                    FillList(body1234);

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
        }
}
