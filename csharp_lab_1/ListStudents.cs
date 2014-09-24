using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharp_lab_1
{
    [Serializable]
    public class ListStudents

    {
       private List<Student> students = new List<Student>();
       public void Add(Student s)
        {
            students.Add(s);
        }
       public List<Student> Students
       {   get { return students; }
           set { students = value; }
       }
        /* public void Delete(string fio)
        {
           //todo
        }
       public void Find(string fio)
        {
            //todo
        }*/
        public ListStudents()
        {

        }
        public int Count 
        {
            get { return students.Count; }
        }
        public void Show(DataGridView dgvStud, DataGridView dgvSes)
        {
            dgvStud.Rows.Clear();
            dgvSes.Rows.Clear();
            foreach (Student item in students)
            {
                DataGridViewRow r = new DataGridViewRow();                
                item.Show(r);
                dgvStud.Rows.Add(r);
                item.Sessions.ShowToDgv(dgvSes);
            }
        }
        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
        public double GetMidleMark(string subjName,int curs)
        {
            int count=0;
            double res=0;
            foreach (Student item in students)
            {
                if (item.Curs == curs)
                {
                   res+=item.Sessions.GetSumMark(subjName, ref count);
                }
            }
            return count==0 ? 0: (res / count);
        }
        public void SaveToText(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (Student item in students)
            {
                item.SaveToText(sw);
            }
            sw.Close();
        }
        public void LoadFromText(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            students.Clear();
            while (!sr.EndOfStream)
            {
                Student a = new Student();
                a.LoadFromText(sr);
                students.Add(a);
            }
            sr.Close();
        }
    }
}
