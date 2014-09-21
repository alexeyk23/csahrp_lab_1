using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharp_lab_1
{
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
            AcceptButton = btnOk;
        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {

        }
        public string getFio()
        {
            return txbxFio.Text.Trim();
        }
        public int getCurs()
        {
            return (int)numpdCurs.Value;
        }
        public int getGroup()
        {
            return (int)numpdGroup.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
