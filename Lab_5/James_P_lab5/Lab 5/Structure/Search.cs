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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Call the search function in person(v2)
            PersonV2 temp = new PersonV2();
            DataSet ds = temp.SearchRecords(txtFName.Text, txtLName.Text);

            //Get the results and display
            gvResults.DataSource = ds;
            gvResults.DataMember = ds.Tables["Persons"].ToString();
            

        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPerson_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(strPerson_ID);

            int intPerson_ID = Convert.ToInt32(strPerson_ID);

            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }
    }
}
