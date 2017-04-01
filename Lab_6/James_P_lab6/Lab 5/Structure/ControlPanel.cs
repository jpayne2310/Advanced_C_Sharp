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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();       //create the form instance in memory
            temp.Show();                    //show the form on screen
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search temp = new Search();
            temp.ShowDialog();
        }
    }
}
