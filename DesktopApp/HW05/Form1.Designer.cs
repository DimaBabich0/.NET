namespace HW05
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            startGameButton = new Button();
            BotMoveFirstCheckBox = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button_MouseClick;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(138, 12);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button_MouseClick;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(264, 12);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button_MouseClick;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(12, 138);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button_MouseClick;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(138, 138);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += button_MouseClick;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(264, 138);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.MouseClick += button_MouseClick;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(12, 266);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.MouseClick += button_MouseClick;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(138, 264);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.MouseClick += button_MouseClick;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Location = new Point(264, 266);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.MouseClick += button_MouseClick;
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGameButton.Location = new Point(412, 23);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(258, 65);
            startGameButton.TabIndex = 9;
            startGameButton.Text = "Start new game";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // BotMoveFirstCheckBox
            // 
            BotMoveFirstCheckBox.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotMoveFirstCheckBox.Location = new Point(412, 94);
            BotMoveFirstCheckBox.Name = "BotMoveFirstCheckBox";
            BotMoveFirstCheckBox.Size = new Size(258, 32);
            BotMoveFirstCheckBox.TabIndex = 10;
            BotMoveFirstCheckBox.Text = "The computer move first";
            BotMoveFirstCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(412, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 81);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulty  level:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hard";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Easy";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 401);
            Controls.Add(groupBox1);
            Controls.Add(BotMoveFirstCheckBox);
            Controls.Add(startGameButton);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button startGameButton;
        private CheckBox BotMoveFirstCheckBox;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
