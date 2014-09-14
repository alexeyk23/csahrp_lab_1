using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace csharp_lab_1
{
    [Serializable]
    class Session
    {
        List<Examen> exams = new List<Examen>(5);
        public Session(List<Examen> ex)
        {
            exams = ex;
        }
        public Session()
        {
            
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
    }
}
