using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    internal class Program
    {
        static void Main()
        {
            int i;
            Library lib = new Library();
            lib.AddBook(new Book("My Autobiography", "Ostap Vyshnia", 1927, 191, "Ukrainian"));
            lib.AddBook(new Book("Robinson Crusoe", "Daniel Defoe", 1719, 607, "English"));
            lib.AddBook(new Book("La Divina Commedia", "Dante Alighieri", 1321, 928, "Italian"));

            Console.WriteLine("Array of books:");
            i = 1;
            foreach (var book in lib.GetBooks())
            {
                Console.WriteLine($"\tBook #{i++}");
                book.Print();
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");

            lib.SortBooks(new Book.SortByTitle());
            i = 1;
            Console.WriteLine("Library sort by title:");
            foreach (var book in lib.GetBooks())
            {
                Console.WriteLine($"\tBook #{i++}");
                book.Print();
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");

            lib.SortBooks(new Book.SortByYearPublished());
            i = 1;
            Console.WriteLine("Library sort by year:");
            foreach (var book in lib.GetBooks())
            {
                Console.WriteLine($"\tBook #{i++}");
                book.Print();
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");

            lib.SortBooks(new Book.SortByPages());
            i = 1;
            Console.WriteLine("Library sort by pages:");
            foreach (var book in lib.GetBooks())
            {
                Console.WriteLine($"\tBook #{i++}");
                book.Print();
                Console.WriteLine();
            }
        }
    }
}
