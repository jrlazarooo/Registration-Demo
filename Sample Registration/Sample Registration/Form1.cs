using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Registration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            dtgrRegister.Columns.Add("fname", "First Name");
            dtgrRegister.Columns.Add("lname", "Last Name");
            dtgrRegister.Columns.Add("mname", "Middle Name");
            dtgrRegister.Columns.Add("Prog", "Program");
            dtgrRegister.Columns.Add("dept", "Department");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dtgrRegister.Rows.Add(txtFirst.Text, txtLast.Text, txtMiddle.Text, txtProgram.Text, cboDepartment.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtgrRegister.Rows.Clear();
        }
    }
}
