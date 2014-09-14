using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace csharp_lab_1
{
    [Serializable]
    class ListSessions
    {
        List<Session> ses;
        [NonSerialized]
        int countSes;

        public ListSessions(int kurs)
        {
            countSes = 2 * kurs;
            ses = new List<Session>(countSes);
           
        }
        public void SaveToText(StreamWriter sw)
        {
            foreach (Session item in ses)
            {
                item.SaveToText(sw);
            }
        }
        public void LoadFromText(StreamReader sr)
        {
            ses.Clear();
            for (int i = 0; i < countSes; i++)
            {
                Session s = new Session();
                s.LoadFromText(sr);
            }
        }
        public void AddSession(Session s)
        {
            ses.Add(s);
        }
    }
}
