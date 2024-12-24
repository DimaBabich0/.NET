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

namespace HW12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AlphaSlider.Value = 255;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)RedSlider.Value;
            byte green = (byte)GreenSlider.Value;
            byte blue = (byte)BlueSlider.Value;
            byte alpha = (byte)AlphaSlider.Value;

            RedValueText.Text = red.ToString();
            GreenValueText.Text = green.ToString();
            BlueValueText.Text = blue.ToString();
            AlphaValueText.Text = alpha.ToString();

            Color color = Color.FromArgb(alpha, red, green, blue);

            ColorPreview.Fill = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte red = (byte)RedSlider.Value;
            byte green = (byte)GreenSlider.Value;
            byte blue = (byte)BlueSlider.Value;
            byte alpha = (byte)AlphaSlider.Value;

            Color color = Color.FromArgb(alpha, red, green, blue);

            TextBlock textBlock = new TextBlock();
            textBlock.Text = $"RGBA ({red}, {green}, {blue}, {alpha})";
            textBlock.VerticalAlignment = VerticalAlignment.Center;
            textBlock.Width = 180;
            textBlock.FontSize = 15;

            Rectangle rectangle = new Rectangle();
            rectangle.Fill = new SolidColorBrush(color);
            rectangle.Width = 400;
            rectangle.Height = 30;
            rectangle.Margin = new Thickness(10, 0, 0, 0);
            rectangle.Stroke = new SolidColorBrush(Colors.Black);
            rectangle.StrokeThickness = 1;

            Button button = new Button();
            button.Width = 100;
            button.Margin = new Thickness(10, 0, 0, 0);
            button.Content = "Delete";
            button.Click += DeleteButton_Click;

            StackPanel first = new StackPanel();
            first.Orientation = Orientation.Horizontal;
            first.Children.Add(textBlock);
            first.Children.Add(rectangle);
            first.Children.Add(button);
            first.Margin = new Thickness(3);

            root.Children.Add(first);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                StackPanel parentStackPanel = clickedButton.Parent as StackPanel;
                if (parentStackPanel != null)
                {
                    root.Children.Remove(parentStackPanel);
                }
            }
        }
    }
}