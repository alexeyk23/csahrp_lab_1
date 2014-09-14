using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_lab_1
{
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

    }

}
