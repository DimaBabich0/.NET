namespace HW07
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            deleteAllBooksToolStripMenuItem = new ToolStripMenuItem();
            getFirstBookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            DeleteBooksStripButton = new ToolStripButton();
            ShowFirstBookStripButton = new ToolStripButton();
            CloseWindowStripButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 3;
            label4.Text = "Year:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TitleTextBox.Location = new Point(129, 78);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(190, 29);
            TitleTextBox.TabIndex = 4;
            TitleTextBox.TextChanged += TextBox_TextChanged;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AuthorTextBox.Location = new Point(129, 122);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(190, 29);
            AuthorTextBox.TabIndex = 5;
            AuthorTextBox.TextChanged += TextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            YearTextBox.Location = new Point(129, 210);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(190, 29);
            YearTextBox.TabIndex = 7;
            YearTextBox.TextChanged += TextBox_TextChanged;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GenreTextBox.Location = new Point(129, 166);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(190, 29);
            GenreTextBox.TabIndex = 6;
            GenreTextBox.TextChanged += TextBox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.Location = new Point(12, 260);
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
            OutputTextBox.Location = new Point(342, 62);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            OutputTextBox.Size = new Size(450, 247);
            OutputTextBox.TabIndex = 9;
            OutputTextBox.Text = "";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(183, 260);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(135, 49);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.MouseClick += DeleteButton_MouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft YaHei", 9.75F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 27);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteAllBooksToolStripMenuItem, getFirstBookToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(57, 23);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // deleteAllBooksToolStripMenuItem
            // 
            deleteAllBooksToolStripMenuItem.Name = "deleteAllBooksToolStripMenuItem";
            deleteAllBooksToolStripMenuItem.Size = new Size(175, 24);
            deleteAllBooksToolStripMenuItem.Text = "Delete all books";
            deleteAllBooksToolStripMenuItem.Click += deleteAllBooksToolStripMenuItem_Click;
            // 
            // getFirstBookToolStripMenuItem
            // 
            getFirstBookToolStripMenuItem.Name = "getFirstBookToolStripMenuItem";
            getFirstBookToolStripMenuItem.Size = new Size(175, 24);
            getFirstBookToolStripMenuItem.Text = "Get first book";
            getFirstBookToolStripMenuItem.Click += getFirstBookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Microsoft YaHei", 9.75F);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(43, 23);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { DeleteBooksStripButton, ShowFirstBookStripButton, CloseWindowStripButton });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(804, 25);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // DeleteBooksStripButton
            // 
            DeleteBooksStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteBooksStripButton.Image = Properties.Resources.delete_file;
            DeleteBooksStripButton.ImageTransparentColor = Color.Magenta;
            DeleteBooksStripButton.Name = "DeleteBooksStripButton";
            DeleteBooksStripButton.Size = new Size(23, 22);
            DeleteBooksStripButton.Text = "Delete all books in file";
            DeleteBooksStripButton.Click += DeleteBooksStripButton_Click;
            // 
            // ShowFirstBookStripButton
            // 
            ShowFirstBookStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ShowFirstBookStripButton.Image = Properties.Resources.show_file;
            ShowFirstBookStripButton.ImageTransparentColor = Color.Magenta;
            ShowFirstBookStripButton.Name = "ShowFirstBookStripButton";
            ShowFirstBookStripButton.Size = new Size(23, 22);
            ShowFirstBookStripButton.Text = "Show box about first book";
            ShowFirstBookStripButton.Click += ShowFirstBookStripButton_Click;
            // 
            // CloseWindowStripButton
            // 
            CloseWindowStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CloseWindowStripButton.Image = Properties.Resources.close_win;
            CloseWindowStripButton.ImageTransparentColor = Color.Magenta;
            CloseWindowStripButton.Name = "CloseWindowStripButton";
            CloseWindowStripButton.Size = new Size(23, 22);
            CloseWindowStripButton.Text = "Close window";
            CloseWindowStripButton.Click += CloseWindowStripButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 321);
            Controls.Add(toolStrip1);
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
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Book Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton DeleteBooksStripButton;
        private ToolStripButton ShowFirstBookStripButton;
        private ToolStripButton CloseWindowStripButton;
        private ToolStripMenuItem deleteAllBooksToolStripMenuItem;
        private ToolStripMenuItem getFirstBookToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
