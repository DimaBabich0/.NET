namespace HW06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            YearTextBox = new TextBox();
            GenreTextBox = new TextBox();
            SaveButton = new Button();
            OutputTextBox = new RichTextBox();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 3;
            label4.Text = "Year:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TitleTextBox.Location = new Point(129, 28);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(190, 29);
            TitleTextBox.TabIndex = 4;
            TitleTextBox.TextChanged += TextBox_TextChanged;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AuthorTextBox.Location = new Point(129, 72);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(190, 29);
            AuthorTextBox.TabIndex = 5;
            AuthorTextBox.TextChanged += TextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            YearTextBox.Location = new Point(129, 160);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(190, 29);
            YearTextBox.TabIndex = 7;
            YearTextBox.TextChanged += TextBox_TextChanged;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenreTextBox.Location = new Point(129, 116);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(190, 29);
            GenreTextBox.TabIndex = 6;
            GenreTextBox.TextChanged += TextBox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.Location = new Point(12, 210);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(135, 49);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.MouseClick += SaveButton_MouseClick;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Font = new Font("Microsoft YaHei", 15.75F);
            OutputTextBox.Location = new Point(342, 12);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            OutputTextBox.Size = new Size(446, 247);
            OutputTextBox.TabIndex = 9;
            OutputTextBox.Text = "";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(183, 210);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(135, 49);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.MouseClick += DeleteButton_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 286);
            Controls.Add(DeleteButton);
            Controls.Add(OutputTextBox);
            Controls.Add(SaveButton);
            Controls.Add(YearTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TitleTextBox;
        private TextBox AuthorTextBox;
        private TextBox YearTextBox;
        private TextBox GenreTextBox;
        private Button SaveButton;
        private RichTextBox OutputTextBox;
        private Button DeleteButton;
    }
}
