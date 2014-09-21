using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace csharp_lab_1
{
    [Serializable]
    class ListStudents
    {
       List<Student> stds = new List<Student>();
       public void Add(Student s)
        {
            stds.Add(s);
        }
       public void Delete(string fio)
        {
           //todo
        }
       public void Find(string fio)
        {
            //todo
        }
        public ListStudents()
        {

        }
        public int Count 
        {
            get { return stds.Count; }
        }
        public void Show(DataGridView dgvStud, DataGridView dgvSes)
        {
            dgvStud.Rows.Clear();
            dgvSes.Rows.Clear();
            foreach (Student item in stds)
            {
                DataGridViewRow r = new DataGridViewRow();                
                item.Show(r);
                dgvStud.Rows.Add(r);
                item.Sessions.ShowToDgv(dgvSes);
            }
        }
        public Student this[int index]
        {
            get { return stds[index]; }
            set { stds[index] = value; }
        }
        public double GetMidleMark(string subjName,int curs)
        {
            int count=0;
            double res=0;
            foreach (Student item in stds)
            {
                if (item.Curs == curs)
                {
                   res+=item.Sessions.GetSumMark(subjName, ref count);
                }
            }
            return count==0 ? 0: (res / count);
        }
    }
}
