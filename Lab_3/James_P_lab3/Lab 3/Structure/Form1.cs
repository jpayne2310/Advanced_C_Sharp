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
        }



            private void btnSubmit_Click(object sender, EventArgs e)
            {
                Person body1234 = new Person();
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

                //check for an error
                if (body1234.Feedback.Contains("ERROR:"))
                {
                    lblFeedback.Text = body1234.Feedback;
                }
                //output label and list
                else
                {
                    FillLabel(body1234);
                    FillList(body1234);
                }
            }

            public void FillLabel(Person temp)
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
            }

            //I just wanted to see this work
            public void FillList(Person temp)
            {
                listBox1.Items.Add(temp.FName + " " + temp.MName + " " + temp.LName + " " +
                    temp.Street1 + " " + temp.Street2 + " " + temp.City + " " +
                    temp.State + " " + temp.Zip + " " + temp.Zip2 + " " + temp.Phone + " " +
                    temp.Email);
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
            }
        }
}
