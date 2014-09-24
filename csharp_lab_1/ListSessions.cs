using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace csharp_lab_1
{
    [Serializable]
   public class ListSessions
    {
        private List<Session> ses;
        public List<Session> Sessions 
        { 
            get{return ses;}
            set{ses=value;}
        }
        [NonSerialized]
        int countSes;

        public ListSessions(int kurs)
        {
            countSes = 2 * kurs;
            ses = new List<Session>(countSes);           
        }
        public ListSessions()
        {

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
            ses = new List<Session>(countSes);     
            for (int i = 0; i < countSes; i++)
            {
                Session s = new Session();
                s.LoadFromText(sr);
                ses.Add(s);
            }
        }
        public void AddSession(Session s)
        {
            ses.Add(s);
        }
        public void ShowToDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (Session item in ses)
            {
                item.ShowToDgv(dgv);
            }
        }
        public double GetSumMark(string name, ref int count)
        {
            double res = 0;            
            foreach (Session item in ses)
            {
                res+= item.GetSumMark(name,ref count);                
            }
            return res;
        }
        public void FillRandom()
        {
            Session s;
            for (int i = 0; i < countSes; i++)
            {
                s = new Session();
                s.FillRandom();
                ses.Add(s);
            }
        }
    }
}
