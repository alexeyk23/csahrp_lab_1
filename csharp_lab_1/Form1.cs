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
    public partial class Form1 : Form
    {
        frmNewStudent f2 = new frmNewStudent();
        ListStudents gListStudents = new ListStudents();
        public Form1()
        {
            InitializeComponent();
           

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (f2.ShowDialog(this.Owner) == DialogResult.OK)
            {
                Student st = new Student(f2.getFio(), f2.getCurs(), f2.getGroup());
                gListStudents.Add(st);
                gListStudents.Show(dgvStudents, dgvSessions);
            }      

        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (gListStudents.Count != 0 && dgvStudents.CurrentRow.Index>=0) { gListStudents[dgvStudents.CurrentRow.Index].Sessions.ShowToDgv(dgvSessions); }
        }
    }
}
