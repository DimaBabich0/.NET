using HW05.Properties;
using System;
using System.Drawing.Design;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HW05
{
    public interface View
    {
        public bool IsGameStart { get; set; }
        public bool IsBotMoveFirst { get; }

        void ShowInfo(string message);
        void ShowError(string message);
        void UpdateButton(int index, char playerSymbol);
        void ClearBoard();

        public event EventHandler<EventArgs> StartGame;
        public event EventHandler<EventArgs> ClickCell;
    }

    public partial class Form1 : Form, View
    {
        public List<Button> buttons;

        public bool IsGameStart
        {
            get
            {
                return !startGameButton.Enabled;
            }
            set
            {
                startGameButton.Enabled = !value;
            }
        }

        public bool IsBotMoveFirst
        {
            get
            {
                return BotMoveFirstCheckBox.Checked;
            }
        }

        public event EventHandler<EventArgs> StartGame;
        public event EventHandler<EventArgs> ClickCell;

        public Form1()
        {
            InitializeComponent();

            buttons = Controls.OfType<Button>()
                .Where(button => button.Name.StartsWith("button", StringComparison.OrdinalIgnoreCase))
                .OrderBy(button => int.Parse(Regex.Match(button.Name, @"\d+").Value))
                .ToList();
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public void UpdateButton(int index, char playerSymbol)
        {
            buttons[index].BackgroundImage = playerSymbol == 'X' ? Resources.cross : Resources.circle;
        }

        public void ClearBoard()
        {
            foreach (var button in buttons)
            {
                button.BackgroundImage = null;
            }
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ClickCell?.Invoke(sender, MouseEventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartGame?.Invoke(this, MouseEventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
