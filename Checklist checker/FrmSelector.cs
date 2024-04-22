using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist_checker
{
    public partial class FrmSelector : Form
    {
        private string employeeNr;
        public FrmSelector(string employeeNr)
        {
            InitializeComponent();
            this.employeeNr = employeeNr;
            lblEmployeeNr.Text = employeeNr;
        }

        private void btnCar1_Click(object sender, EventArgs e)
        {
            FrmCheckList checklist = new FrmCheckList("Bil1");
            checklist.Show();
        }

        private void btnCar2_Click(object sender, EventArgs e)
        {
            FrmCheckList checklist = new FrmCheckList("Bil2");
            checklist.Show();
        }

        private void btnCar3_Click(object sender, EventArgs e)
        {
            FrmCheckList checklist = new FrmCheckList("Bil3");
            checklist.Show();
        }

        private void btnCar4_Click(object sender, EventArgs e)
        {
            FrmCheckList checklist = new FrmCheckList("Bil4");
            checklist.Show();
        }

        private void btnCar5_Click(object sender, EventArgs e)
        {
            FrmCheckList checklist = new FrmCheckList("Bil5");
            checklist.Show();
        }
    }
}
