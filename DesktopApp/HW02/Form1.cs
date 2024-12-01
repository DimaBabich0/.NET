using Microsoft.VisualBasic.Devices;

namespace HW02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Text = $"X: {x}; Y: {y}";
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Text = $"X: {x}; Y: {y}";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Click was made outside of the rectangle");
            else if (e.Button == MouseButtons.Right)
                MessageBox.Show($"Width: {Size.Width}; Height: {Size.Height}");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Button button = sender as Button;

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Width: {Size.Width}; Height: {Size.Height}");
                return;
            }    

            bool nearLeft = x >= -10 && x <= 10;
            bool nearRight = x >= button.Width - 10 && x <= button.Width + 10;
            bool nearTop = y >= -10 && y <= 10;
            bool nearBottom = y >= button.Height - 10 && y <= button.Height + 10;
            if (nearLeft || nearRight || nearTop || nearBottom)
                MessageBox.Show("Click was made at the border of a rectangle");
            else
                MessageBox.Show("Click was made inside the rectangle");
        }
    }
}
