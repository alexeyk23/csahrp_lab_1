using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace csharp_lab_1
{
    [Serializable]
    class Student
    {
        string fio;
        int curs;
        int group;
        ListSessions sessions;

        public string Fio 
        {
            get{ return fio; }
            set { fio = value; }
        }
        public int Curs 
        {
            get { return curs; }
            set { curs = value; }
        }
        public int Group 
        {
            get{return group;}
            set{group = value;}
        }
        public ListSessions Sessions
        {
            get { return sessions; }
            set { sessions = value; }
        }
        public Student()
        {
            sessions = new ListSessions(curs);
        }
        public Student(string fio, int curs, int group, ListSessions sessions)
        {
            this.fio = fio;
            this.curs = curs;
            this.group = group;
            this.sessions = sessions;
        }
        public Student(string fio, int curs, int group)
        {
            this.fio = fio;
            this.curs = curs;
            this.group = group;
            this.sessions = new ListSessions(curs);
            sessions.FillRandom();
        }
        public void SaveToText(StreamWriter sw)
        {
            sw.WriteLine(fio);
            sw.WriteLine(curs);
            sw.WriteLine(group);
            sessions.SaveToText(sw);
        }
        public void LoadFromText(StreamReader sr)
        {
            fio = sr.ReadLine();
            curs = int.Parse(sr.ReadLine());
            group = int.Parse(sr.ReadLine());
            sessions.LoadFromText(sr);
        }
        public void Show(DataGridViewRow row)
        {            
            
            DataGridViewCell[] cells = new DataGridViewTextBoxCell[3];
            for (int i = 0; i < 3; i++)
            {
                cells[i] = new DataGridViewTextBoxCell();
            }
            cells[0].Value = fio;
            cells[1].Value = curs;
            cells[2].Value = group;
            row.Cells.AddRange(cells);
        }
    }

}
