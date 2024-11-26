namespace HW01
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
            task1 = new Button();
            task2 = new Button();
            SuspendLayout();
            // 
            // task1
            // 
            task1.Location = new Point(41, 39);
            task1.Name = "task1";
            task1.Size = new Size(200, 100);
            task1.TabIndex = 0;
            task1.Text = "Task #1";
            task1.UseVisualStyleBackColor = true;
            task1.Click += task1_Click;
            // 
            // task2
            // 
            task2.Location = new Point(296, 39);
            task2.Name = "task2";
            task2.Size = new Size(200, 100);
            task2.TabIndex = 1;
            task2.Text = "Task #2";
            task2.UseVisualStyleBackColor = true;
            task2.Click += task2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 187);
            Controls.Add(task2);
            Controls.Add(task1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button task1;
        private Button task2;
    }
}
