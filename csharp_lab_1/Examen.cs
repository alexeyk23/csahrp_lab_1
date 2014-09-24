using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace csharp_lab_1
{
    [Serializable]
    public class Examen 
    {
        private string name;
        private int mark;
        public int Mark 
        {
            get { return mark; }
            set { mark = value; }
        }
        public string Name 
        { 
            get{ return name; }
            set{ name=value; }
        }
        public Examen(string name, int mark)
        {
            this.mark = mark;
            this.name = name;
        }
        public Examen()
        {

        }
        public void SaveToText(StreamWriter sw)
        {
            sw.WriteLine(name+" "+mark);
        }
        private char[] separators = new char[] { ' ' };
        public void ReadFromText(StreamReader sr)
        {
           string[] s= sr.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
           Name = s[0];
           Mark = int.Parse(s[s.Length-1]);           
        }
        public void ShowToDgvRow(DataGridViewRow row)
        {
            DataGridViewCell[] cells = new DataGridViewTextBoxCell[2];
            for (int i = 0; i < 2; i++)
            {
                cells[i] = new DataGridViewTextBoxCell();
            }
            cells[0].Value = name;
            cells[1].Value = mark;
            row.Cells.AddRange(cells);
        }
    }
}
