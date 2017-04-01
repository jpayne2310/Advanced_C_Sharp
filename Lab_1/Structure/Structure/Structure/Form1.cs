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

        public class Person
        {
            public string fName;
            public string mName;
            public string lName;
            public string street1;
            public string street2;
            public string city;
            public string state;
            public string zip;
            public string phone;
            public string email;
        };

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person body1234 = new Person();
            //assign body parts
            body1234.fName = txtfName.Text;
            body1234.mName += txtmName.Text;
            body1234.lName += txtlName.Text;
            body1234.street1 += txtstreet1.Text;
            body1234.street2 += txtstreet2.Text;
            body1234.city += txtcity.Text;
            body1234.state += txtstate.Text;
            body1234.zip += txtzip.Text;
            body1234.phone += txtphone.Text;
            body1234.email += txtemail.Text;

            FillLabel(body1234);

            FillList(body1234);
        }

        public void FillLabel(Person temp)
        {
            //output for label taken from text boxes
            lblFeedback.Text = temp.fName + " Poopy" + "\n";
            lblFeedback.Text += temp.mName + "\n";
            lblFeedback.Text += temp.lName + "\n";
            lblFeedback.Text += temp.street1 + "\n";
            lblFeedback.Text += temp.street2 + "\n";
            lblFeedback.Text += temp.city + "\n";
            lblFeedback.Text += temp.state + "\n";
            lblFeedback.Text += temp.zip + "\n";
            lblFeedback.Text += temp.phone + "\n";
            lblFeedback.Text += temp.email + "\n";
        }

        //I just wanted to see this work
        public void FillList(Person temp)
        {
            listBox1.Items.Add(temp.fName + " Poopy " + temp.mName + " " + temp.lName + " " +
                temp.street1 + " " + temp.street2 + " " + temp.city + " " +
                temp.state + " " + temp.zip + " " + temp.phone + " " +
                temp.email);
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

            }
            //clear feedback label
            lblFeedback.Text = "";
        }

    }
}
