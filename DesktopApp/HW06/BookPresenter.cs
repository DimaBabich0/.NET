using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace HW06
{
    public interface IBookView
    {
        string Title { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
        int Year { get; set; }
        string Output { set; }

        event EventHandler<EventArgs> SaveEvent;
        event EventHandler<EventArgs> DeleteEvent;
    }

    internal class BookPresenter
    {
        private readonly IModel _model;
        private readonly IBookView _view;

        public BookPresenter(IModel model, IBookView view)
        {
            _model = model;
            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.SaveEvent += new EventHandler<EventArgs>(AddBook);
            _view.DeleteEvent += new EventHandler<EventArgs>(DeleteBook);
            _model.Load();
            _view.Output = string.Join("\n", _model.Books);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        private void ShowInfo(string message)
        {
            MessageBox.Show(
                message,
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
                ShowInfo("Book deleted from list");
            }
            else
                ShowError("Your book is not found among all books");
            
            UpdateView();
        }

        private void UpdateView()
        {
            _model.Save();
            _model.Load();
            _view.Output = string.Join("\n", _model.Books);
        }
    }
}
