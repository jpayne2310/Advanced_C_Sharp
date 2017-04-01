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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strAppointment_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(strAppointment_ID);

            int intAppointment_ID = Convert.ToInt32(strAppointment_ID);

            Form1 Editor = new Form1(intAppointment_ID);
            Editor.ShowDialog();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //Call the search function in Appointment
            Appointment temp = new Appointment();
            DataSet ds = temp.SearchRecords(txtSearchAp.Text, txtLocationFinder.Text, txtStartDate.Text, txtEndDate.Text);

            //Get the results and display
            gvResults.DataSource = ds;
            gvResults.DataMember = ds.Tables["Appointment"].ToString();
        }


    }
}
