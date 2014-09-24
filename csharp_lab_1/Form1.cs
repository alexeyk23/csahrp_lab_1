using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
namespace csharp_lab_1
{
    public partial class Form1 : Form
    {
        frmNewStudent f2 = new frmNewStudent();
        ListStudents gListStudents = new ListStudents();
        SerializeManager sm = new SerializeManager();
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
            if (gListStudents.Count != 0 && dgvStudents.CurrentRow.Index >= 0 && dgvStudents.CurrentRow.Index < gListStudents.Count)
            { gListStudents[dgvStudents.CurrentRow.Index].Sessions.ShowToDgv(dgvSessions); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializeManager sm = new SerializeManager();
           // sm.Serialize(gListStudents, typeof(ListStudents), ESerializeType.Binary, "gop.bin");
            gListStudents = (ListStudents)sm.Deserialize(typeof(ListStudents), ESerializeType.Binary, "gop.bin");
            gListStudents.Show(dgvStudents, dgvSessions);
        }

        private void numpdCurs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGoMidMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gListStudents.GetMidleMark(txbxSubjName.Text.Trim(), (int)numpdCurs.Value).ToString(),"Средний бал по предмету");

        }
        SaveFileDialog sfd = new SaveFileDialog();
        private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "xml files (*.xml)|*.xml";
            if(sfd.ShowDialog()==DialogResult.OK)
              sm.Serialize(gListStudents,typeof(ListStudents),ESerializeType.Xml,sfd.FileName);
        }

        private void saveToBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Binary files (*.bin)|*.bin";
            if (sfd.ShowDialog() == DialogResult.OK)
                sm.Serialize(gListStudents, typeof(ListStudents), ESerializeType.Binary, sfd.FileName);
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void loadFromBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Binary files (*.bin)|*.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gListStudents = (ListStudents)sm.Deserialize(typeof(ListStudents), ESerializeType.Binary, ofd.FileName);
                gListStudents.Show(dgvStudents, dgvSessions);            
            }
        }

        private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "xml files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gListStudents = (ListStudents)sm.Deserialize(typeof(ListStudents), ESerializeType.Xml, ofd.FileName);
                gListStudents.Show(dgvStudents, dgvSessions);            
            }
        }

        private void loadFromTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gListStudents.LoadFromText(ofd.FileName);
                gListStudents.Show(dgvStudents, dgvSessions);         
            }
        }

        private void saveToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                gListStudents.SaveToText(sfd.FileName);
                gListStudents.Show(dgvStudents, dgvSessions);
            }
        }
        
    }
}
