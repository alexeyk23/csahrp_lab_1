using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace csharp_lab_1
{
    enum ESerializeType 
    {
         Xml, Binary
    }
    class SerializeManager
    {
        XmlSerializer xmlSer;
        BinaryFormatter binSer;
        public void Serialize(Object o, Type t, ESerializeType serializeType,string fileName)
        {
            switch (serializeType)
            {
                case ESerializeType.Xml:
                    xmlSerialization(o, t, fileName);
                    break;
                case ESerializeType.Binary:
                    binarySerialization(o,fileName);
                    break;             
                default:
                    break;
            }
        }

        public object Deserialize(Type t, ESerializeType serializeType,string fileName)
        {
           if(serializeType==ESerializeType.Binary)
               return binaryDeserialization(fileName);
            return xmlDeserialization(t,fileName);
        }

        private void xmlSerialization(Object o,Type t, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);  
            xmlSer = new XmlSerializer(t);
            xmlSer.Serialize(fs, o);            
            fs.Close();
            
        }
        private Object xmlDeserialization(Type t, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            xmlSer = new XmlSerializer(t);
            Object o= xmlSer.Deserialize(fs);
            fs.Close();
            return o;             
        }
        private void binarySerialization(Object o, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            binSer = new BinaryFormatter();
            binSer.Serialize(fs,o);
            fs.Close();
        }
        private Object binaryDeserialization(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            binSer = new BinaryFormatter();
            Object o = binSer.Deserialize(fs);
            fs.Close();
            return o;
        }
    }
}
