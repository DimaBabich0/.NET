namespace HW01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task1_Click(object sender, EventArgs e)
        {
            string[] resume = { 
                "Name: Dima Babich\nAge: 19\nPhone number: +380631234567\nEmail: babichdima@gmail.com",
                "Professional skills:\nStrong knowledge and experience in C# (.NET, .NET Core)\nWorking with databases (SQL)\nCode optimization and refactoring skills",
                "Experience:\nImplementation and support of web applications and services\nIntegration with external APIs and systems\nApplication performance optimization",
                "Additional:\nAble to work in a team and manage projects independently, adapting to business requirements and finding optimal technical solutions."
            };

            int wordsCount = 0;
            for (int i = 0; i < resume.Length; i++)
            {
                wordsCount += resume[i].Length;
                MessageBox.Show(resume[i], $"{wordsCount} / {i+1} = {wordsCount/(i+1)}");
            }
        }

        private void task2_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = 2000;
            int attempts = 0;
            DialogResult rez;

            MessageBox.Show($"Guess the number from {min} to {max}", "Game rules");

            while (true)
            {
                if (min >= max)
                {
                    MessageBox.Show("The number is out of range and impossible to guess.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                int num = (min + max) / 2;
                attempts++;

                rez = MessageBox.Show($"Your number is {num}?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                {
                    MessageBox.Show($"Your number is {num}. The program has guessed the number from {attempts} attempts.", "Program win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

                rez = MessageBox.Show($"Your number is more than {num}?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                    min = num;
                else
                    max = num;
            }

            rez = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
                task2_Click(sender, e);
            return;
        }
    }
}
