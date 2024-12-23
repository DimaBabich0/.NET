using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Expression = "";
        private string Result = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string buttonContent = button.Content.ToString();

            if (buttonContent == null) return;

            switch (buttonContent)
            {
                case "CE":
                    Expression = "";
                    UpdateInput();
                    break;
                case "C":
                    Expression = "";
                    Result = "";
                    UpdateInput();
                    break;
                case "<":
                    if (Expression.Length > 0)
                    {
                        Expression = Expression.Remove(Expression.Length - 1);
                        UpdateInput();
                    }
                    break;
                case "=":
                    CalculateResult();
                    break;
                default:
                    Result = "";
                    HandleInput(buttonContent);
                    break;
            }
        }

        private void HandleInput(string input)
        {
            if (input == "." && Expression.EndsWith("."))
                return;
            if (input == "." && Expression == "")
                return;
            if ("/*-+".Contains(input) &&
                (Expression == "" || "/*-+.".Contains(Expression[^1].ToString())))
                return;
            Expression += input;
            UpdateInput();
        }

        private void CalculateResult()
        {
            try
            {
                DataTable dt = new DataTable();
                Result = dt.Compute(Expression, null).ToString();
            }
            catch
            {
                Result = "ERROR";
            }
            UpdateInput();
        }

        private void UpdateInput()
        {
            InputTextBox.Text = Expression;
            OutputTextBox.Text = Result;
        }
    }
}