namespace HW06
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
        public event EventHandler<EventArgs> DeleteEvent;

        #endregion ICalculateView Implementation

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = Title.Length > 0 &&
                Author.Length > 0 &&
                Genre.Length > 0 &&
                YearTextBox.Text != "";
        }
    }
}
