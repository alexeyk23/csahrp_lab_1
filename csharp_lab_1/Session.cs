using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace csharp_lab_1
{
    [Serializable]
    public class Session
    {
        List<Examen> exams;
        private string[] randName = new string[] { "матан", "алгем", "инф. и прогр.", "ясп", "алгоритмы", "структуры", "бд", "тв и мс" };
        public Session(List<Examen> ex)
        {
            exams = ex;
        }
        public List<Examen> Examens
        {
            get { return exams; }
            set { exams = value; }

        }
        public Session()
        {
            exams = new List<Examen>(5);
        }
        public void SaveToText(StreamWriter sw)
        {
            foreach (Examen item in exams)
            {
                item.SaveToText(sw);
            }
        }
        public void LoadFromText(StreamReader sr)
        {
            exams.Clear();
            for (int i = 0; i < 5; i++)
            {
                Examen ex = new Examen();
                ex.ReadFromText(sr);
                exams.Add(ex);
            }
        }
        public void  ShowToDgv(DataGridView dgv)
        {
           
            foreach (Examen item in exams)
            {
                DataGridViewRow r = new DataGridViewRow();
                item.ShowToDgvRow(r);
                dgv.Rows.Add(r);
            }
        }
        public double GetSumMark(string name, ref int count)
        {
            double res=0;            
            foreach (Examen item in exams)
            {
                if(item.Name.Equals(name))
                {
                    res+=item.Mark;
                    count++;
                }
            }
            return res;
        }

        public void FillRandom()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Examen ex = new Examen();
                ex.Name = randName[r.Next(randName.Length)];
                ex.Mark = r.Next(3, 6);
                exams.Add(ex);
            }
        }
    }
}
