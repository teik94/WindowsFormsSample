using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class FileControl
    {
        public static void WriteTableToFile(string path, List<Card> data)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //TypeConverter obj = TypeDescriptor.GetConverter(data.GetType());
            //byte[] bt = (byte[])obj.ConvertTo(data, typeof(byte[]));

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, data);
                byte[] bt = ms.ToArray();
                fs.Write(bt, 0, bt.Length);
            }

            fs.Close();
        }

        public static List<Card> ReadTableFromFile(string path)
        {
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (File.Exists(path))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(path);
                BinaryFormatter bf = new BinaryFormatter();
                using (var ms = new MemoryStream(bytes))
                {
                    List<Card> obj = (List<Card>)bf.Deserialize(ms);
                    //fs.Close();
                    return obj;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
