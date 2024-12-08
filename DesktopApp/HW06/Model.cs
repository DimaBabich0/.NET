using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW06
{
    public interface IModel
    {
        List<string> Books { get; set; }
        void Save();
        void Load();
    }

    public class Model : IModel
    {
        public List<string> Books { get; set; } = new List<string>();

        public void Save()
        {
            StreamWriter sw = new StreamWriter("Books.txt", false);
            sw.WriteLine(string.Join("\n", Books));
            sw.Close();
        }
        public void Load()
        {
            try
            {
                StreamReader sr = new StreamReader("Books.txt", Encoding.UTF8);
                if (sr != null)
                {
                    string line;
                    Books.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line != "")
                            Books.Add(line);
                    }
                }
                sr.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
