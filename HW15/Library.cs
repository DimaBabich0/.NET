using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    internal class Library : IEnumerable
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public IEnumerable<Book> GetBooks()
        {
            return books;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        public void SortBooks(IComparer<Book> comparer)
        {
            books.Sort(comparer);
        }
    }
}
