using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.LinkLabel;

namespace HW07
{
    public interface IBookView
    {
        string Title { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
        int Year { get; set; }
        string Output { set; }

        event EventHandler<EventArgs> SaveEvent;
        event EventHandler<EventArgs> DeleteBookEvent;
        event EventHandler<EventArgs> DeleteAllBooksEvent;
        event EventHandler<EventArgs> ShowFirstBookEvent;
        event EventHandler<EventArgs> CloseWindowEvent;

        void ShowError(string message);
        void ShowInfo(string message);
        void CloseWindow();
    }

    internal class BookPresenter
    {
        private readonly IModel _model;
        private readonly IBookView _view;

        public BookPresenter(IModel model, IBookView view)
        {
            _model = model;
            _view = view;

            _view.SaveEvent += new EventHandler<EventArgs>(AddBook);
            _view.DeleteBookEvent += new EventHandler<EventArgs>(DeleteBook);
            _view.DeleteAllBooksEvent += new EventHandler<EventArgs>(DeleteAllBooksEvent);
            _view.ShowFirstBookEvent += new EventHandler<EventArgs>(ShowFirstBookEvent);
            _view.CloseWindowEvent += new EventHandler<EventArgs>(CloseWindowEvent);

            _model.Load();
            _view.Output = string.Join("\n", _model.Books);
        }

        private void AddBook(object sender, EventArgs e)
        {
            string result = $"Title: {_view.Title}; " +
                $"Author: {_view.Author}; " +
                $"Genre: {_view.Genre}; " +
                $"Year: {_view.Year};";
            _model.Books.Add(result);

            UpdateView();
        }
        
        private void DeleteBook(object sender, EventArgs e)
        {
            string result = $"Title: {_view.Title}; " +
                $"Author: {_view.Author}; " +
                $"Genre: {_view.Genre}; " +
                $"Year: {_view.Year};";
            _model.Load();
            
            if (_model.Books.Contains(result))
            {
                _model.Books = _model.Books.Where(l => l != result).ToList();
                _view.ShowInfo("Book deleted from list");
            }
            else
                _view.ShowError("Your book is not found among all books");
            
            UpdateView();
        }

        private void DeleteAllBooksEvent(object sender, EventArgs e)
        {
            _model.Books.Clear();
            UpdateView();
            _view.ShowInfo("Books deleted from memory");
        }

        private void ShowFirstBookEvent(object sender, EventArgs e)
        {
            if (_model.Books.Count == 0)
                _view.ShowError("No books in memory");
            else
                _view.ShowInfo(_model.Books[0]);
        }

        private void CloseWindowEvent(object sender, EventArgs e)
        {
            _view.CloseWindow();
        }

        private void UpdateView()
        {
            _model.Save();
            _model.Load();
            _view.Output = string.Join("\n", _model.Books);
        }
    }
}
