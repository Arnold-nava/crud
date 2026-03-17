using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            new registration().Show();
            this.Close();

        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            new MasterList().Show();
            this.Close();
        }
    }
}
