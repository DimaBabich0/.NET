using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using SampleMVVM.Models;
using System.Windows;
using SampleMVVM.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    class MainViewModel
    {
        public ObservableCollection<BookViewModel> BooksList { get; set; }

        public MainViewModel(List<Book> books)
        {
            BooksList = new ObservableCollection<BookViewModel>(books.Select(b => new BookViewModel(b)));
        }

        private string _newTitle;
        private string _newAuthor;
        private int _newCount;
        public string NewTitle
        {
            get { return _newTitle; }
            set { _newTitle = value; }
        }
        public string NewAuthor
        {
            get { return _newAuthor; }
            set { _newAuthor = value; }
        }
        public int NewCount
        {
            get { return _newCount; }
            set { _newCount = value; }
        }

        private DelegateCommand addBookCommand;
        public ICommand AddBookCommand
        {
            get
            {
                if (addBookCommand == null)
                {
                    addBookCommand = new DelegateCommand(param => AddBook(), param => CanAddBook());
                }
                return addBookCommand;
            }
        }
        private void AddBook()
        {
            Book newBook = new Book(NewTitle, NewAuthor, NewCount);
            BooksList.Add(new BookViewModel(newBook));
        }
        private bool CanAddBook()
        {
            return !string.IsNullOrEmpty(NewTitle) &&
                   !string.IsNullOrEmpty(NewAuthor) &&
                   NewCount > 0;
        }
    }
}
