using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Xml;

namespace SampleMVVM.Models
{
    internal class BookManager
    {
        private readonly string filePath;
        public BookManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveData(List<Book> books)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    writer.WriteLine(book.Title + '|' + book.Author + '|' + book.Count);
                }
            }
        }

        public List<Book> LoadData()
        {
            List<Book> data = new List<Book>();

            if (!File.Exists(filePath))
            {
                return data;
            }

            using (var reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3 && int.TryParse(parts[2], out int count))
                        data.Add(new Book(parts[0], parts[1], int.Parse(parts[2])));
                }
            }
            return data;
        }
    }
}
