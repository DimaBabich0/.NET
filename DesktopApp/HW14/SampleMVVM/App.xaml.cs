using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;

namespace SampleMVVM
{
    public partial class App : Application
    {
        MainViewModel viewModel;
        BookManager manager = new BookManager("save_data.txt");

        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Book> data = manager.LoadData();

            MainView view = new MainView();
            viewModel = new MainViewModel(data);
            view.DataContext = viewModel;
            view.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            List<Book> books = new List<Book>();
            ObservableCollection<BookViewModel> data = viewModel.BooksList;
            foreach (BookViewModel item in data)
            {
                books.Add(new Book(item.Title, item.Author, item.Count));
            }
            manager.SaveData(books);

            base.OnExit(e);
        }
    }
}
