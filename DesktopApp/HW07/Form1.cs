namespace HW07
{
    public partial class Form1 : Form, IBookView
    {
        #region IBookView Implementation
        public string Title
        {
            get { return TitleTextBox.Text.Trim(); }
            set { TitleTextBox.Text = value; }
        }

        public string Author
        {
            get { return AuthorTextBox.Text.Trim(); }
            set { AuthorTextBox.Text = value; }
        }

        public string Genre
        {
            get { return GenreTextBox.Text.Trim(); }
            set { GenreTextBox.Text = value; }
        }

        public int Year
        {
            get { return Convert.ToInt16(YearTextBox.Text.Trim()); }
            set { YearTextBox.Text = value.ToString(); }
        }

        public string Output
        {
            get { return OutputTextBox.Text.Trim(); }
            set { OutputTextBox.Text = value; }
        }

        public event EventHandler<EventArgs> SaveEvent;
        public event EventHandler<EventArgs> DeleteBookEvent;
        public event EventHandler<EventArgs> DeleteAllBooksEvent;
        public event EventHandler<EventArgs> ShowFirstBookEvent;
        public event EventHandler<EventArgs> CloseWindowEvent;

        public void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        public void ShowInfo(string message)
        {
            MessageBox.Show(
                message,
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void CloseWindow()
        {
            Close();
        }
        #endregion ICalculateView Implementation

        public Form1()
        {
            InitializeComponent();
        }

        private void InvokeEvent(EventHandler<EventArgs> e)
        {
            try
            {
                e?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_MouseClick(object sender, MouseEventArgs e)
        {
            InvokeEvent(SaveEvent);
        }

        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            InvokeEvent(DeleteBookEvent);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = Title.Length > 0 &&
                Author.Length > 0 &&
                Genre.Length > 0 &&
                YearTextBox.Text != "";
        }

        private void deleteAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvokeEvent(DeleteAllBooksEvent);
        }

        private void getFirstBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvokeEvent(ShowFirstBookEvent);
        }

        private void DeleteBooksStripButton_Click(object sender, EventArgs e)
        {
            InvokeEvent(DeleteAllBooksEvent);
        }

        private void ShowFirstBookStripButton_Click(object sender, EventArgs e)
        {
            InvokeEvent(ShowFirstBookEvent);
        }

        private void CloseWindowStripButton_Click(object sender, EventArgs e)
        {
            InvokeEvent(CloseWindowEvent);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvokeEvent(CloseWindowEvent);
        }
    }
}
