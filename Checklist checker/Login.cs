using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Checklist_checker
{
    public partial class FrmLogin : Form
    {
        private string defaultText = "A177567";
        public FrmLogin()
        {
            InitializeComponent();
            txtEmployeeNr.Text = defaultText;
            txtEmployeeNr.ForeColor = SystemColors.GrayText;
            txtEmployeeNr.GotFocus += Txt_GotFocus;
            txtEmployeeNr.LostFocus += Txt_LostFocus;
        }

        private void Txt_GotFocus(object sender, EventArgs e)
        {
            if (txtEmployeeNr.Text == defaultText)
            {
                txtEmployeeNr.Text = "";
            }
        }
        private void Txt_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeNr.Text))
            {
                txtEmployeeNr.Text = defaultText;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string employeeNr;
            employeeNr = txtEmployeeNr.Text;
            FrmSelector selector = new FrmSelector(employeeNr);
            selector.ShowDialog();
        }
    }
}
