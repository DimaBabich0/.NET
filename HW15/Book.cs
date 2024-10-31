using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    internal class Book : ICloneable, IComparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }

        public Book(string title, string author, int yearPublished, int pageCount, string language)
        {
            Title = title;
            Author = author;
            Year = yearPublished;
            Pages = pageCount;
            Language = language;
        }

        public object Clone()
        {
            return new Book(Title, Author, Year, Pages, Language);
        }

        public int CompareTo(object obj)
        {
            if (obj is Book objBook)
                return Title.CompareTo(objBook.Title);
            throw new NotImplementedException();
        }

        public class SortByTitle : IComparer<Book>
        {
            public int Compare(Book obj1, Book obj2)
            {
                return obj1.Title.CompareTo(obj2.Title);
            }
        }
        public class SortByPages : IComparer<Book>
        {
            public int Compare(Book obj1, Book obj2)
            {
                return obj1.Pages.CompareTo(obj2.Pages);
            }
        }

        public class SortByYearPublished : IComparer<Book>
        {
            public int Compare(Book obj1, Book obj2)
            {
                return obj1.Year.CompareTo(obj2.Year);
            }
        }
        public void Print()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Page count: {Pages}");
            Console.WriteLine($"Year published: {Year}");
            Console.WriteLine($"Language: {Language}");
        }
    }
}
