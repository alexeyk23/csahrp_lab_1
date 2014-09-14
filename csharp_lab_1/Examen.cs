using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace csharp_lab_1
{
    [Serializable]
    class Examen
    {
        private string name;
        private int mark;
        private int Mark 
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
        public void ReadFromText(StreamReader sr)
        {
           string[] s= sr.ReadLine().Split(' ');
           Name = s[0];
           Mark = int.Parse(s[1]);           
        }
    }
}
