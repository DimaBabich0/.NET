namespace HW04
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
            groupBox1 = new GroupBox();
            PetrolGroupBox = new GroupBox();
            PetrolPaymentSign = new Label();
            PetrolPayment = new Label();
            label8 = new Label();
            label7 = new Label();
            PriceTextBox = new TextBox();
            LitersTextBox = new TextBox();
            groupBox3 = new GroupBox();
            PriceRadioButton = new RadioButton();
            NumberRadioButton = new RadioButton();
            label3 = new Label();
            PetrolPrice = new TextBox();
            label2 = new Label();
            label1 = new Label();
            PetrolComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            FoodBox4Amount = new TextBox();
            FoodBox4Price = new TextBox();
            FoodBox4 = new CheckBox();
            FoodBox3Amount = new TextBox();
            FoodBox3Price = new TextBox();
            FoodBox3 = new CheckBox();
            FoodBox2Amount = new TextBox();
            FoodBox2Price = new TextBox();
            FoodBox2 = new CheckBox();
            FoodBox1Amount = new TextBox();
            FoodBox1Price = new TextBox();
            label5 = new Label();
            label4 = new Label();
            FoodBox1 = new CheckBox();
            groupBox5 = new GroupBox();
            label11 = new Label();
            FoodPayment = new Label();
            groupBox6 = new GroupBox();
            CalculateButton = new Button();
            label6 = new Label();
            TotalPayment = new Label();
            groupBox1.SuspendLayout();
            PetrolGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PetrolGroupBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(PriceTextBox);
            groupBox1.Controls.Add(LitersTextBox);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PetrolPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PetrolComboBox);
            groupBox1.Location = new Point(11, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gas station";
            // 
            // PetrolGroupBox
            // 
            PetrolGroupBox.Controls.Add(PetrolPaymentSign);
            PetrolGroupBox.Controls.Add(PetrolPayment);
            PetrolGroupBox.Font = new Font("Calibri", 12F);
            PetrolGroupBox.Location = new Point(6, 187);
            PetrolGroupBox.Name = "PetrolGroupBox";
            PetrolGroupBox.Size = new Size(218, 88);
            PetrolGroupBox.TabIndex = 11;
            PetrolGroupBox.TabStop = false;
            PetrolGroupBox.Text = "To payment";
            // 
            // PetrolPaymentSign
            // 
            PetrolPaymentSign.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PetrolPaymentSign.Location = new Point(174, 44);
            PetrolPaymentSign.Name = "PetrolPaymentSign";
            PetrolPaymentSign.Size = new Size(38, 33);
            PetrolPaymentSign.TabIndex = 12;
            PetrolPaymentSign.Text = "₴";
            PetrolPaymentSign.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PetrolPayment
            // 
            PetrolPayment.Font = new Font("Calibri", 28F);
            PetrolPayment.Location = new Point(6, 23);
            PetrolPayment.Name = "PetrolPayment";
            PetrolPayment.Size = new Size(169, 58);
            PetrolPayment.TabIndex = 12;
            PetrolPayment.Text = "Price";
            PetrolPayment.TextAlign = ContentAlignment.BottomRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(198, 148);
            label8.Name = "label8";
            label8.Size = new Size(16, 19);
            label8.TabIndex = 10;
            label8.Text = "₴";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(198, 105);
            label7.Name = "label7";
            label7.Size = new Size(26, 19);
            label7.TabIndex = 9;
            label7.Text = "lit.";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Calibri", 12F);
            PriceTextBox.Location = new Point(101, 144);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(97, 27);
            PriceTextBox.TabIndex = 8;
            PriceTextBox.Leave += PriceTextBox_Leave;
            // 
            // LitersTextBox
            // 
            LitersTextBox.Font = new Font("Calibri", 12F);
            LitersTextBox.Location = new Point(101, 102);
            LitersTextBox.Name = "LitersTextBox";
            LitersTextBox.Size = new Size(97, 27);
            LitersTextBox.TabIndex = 7;
            LitersTextBox.Leave += LitersTextBox_Leave;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PriceRadioButton);
            groupBox3.Controls.Add(NumberRadioButton);
            groupBox3.Location = new Point(6, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(89, 93);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // PriceRadioButton
            // 
            PriceRadioButton.AutoSize = true;
            PriceRadioButton.Font = new Font("Calibri", 12F);
            PriceRadioButton.Location = new Point(6, 56);
            PriceRadioButton.Name = "PriceRadioButton";
            PriceRadioButton.Size = new Size(59, 23);
            PriceRadioButton.TabIndex = 1;
            PriceRadioButton.TabStop = true;
            PriceRadioButton.Text = "Price";
            PriceRadioButton.UseVisualStyleBackColor = true;
            PriceRadioButton.CheckedChanged += PriceRadioButton_CheckedChanged;
            // 
            // NumberRadioButton
            // 
            NumberRadioButton.AutoSize = true;
            NumberRadioButton.Font = new Font("Calibri", 12F);
            NumberRadioButton.Location = new Point(6, 17);
            NumberRadioButton.Name = "NumberRadioButton";
            NumberRadioButton.Size = new Size(78, 23);
            NumberRadioButton.TabIndex = 0;
            NumberRadioButton.TabStop = true;
            NumberRadioButton.Text = "Number";
            NumberRadioButton.UseVisualStyleBackColor = true;
            NumberRadioButton.CheckedChanged += NumberRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(208, 59);
            label3.Name = "label3";
            label3.Size = new Size(16, 19);
            label3.TabIndex = 5;
            label3.Text = "₴";
            // 
            // PetrolPrice
            // 
            PetrolPrice.Font = new Font("Calibri", 12F);
            PetrolPrice.Location = new Point(74, 55);
            PetrolPrice.Name = "PetrolPrice";
            PetrolPrice.ReadOnly = true;
            PetrolPrice.Size = new Size(128, 27);
            PetrolPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(2, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 1;
            label1.Text = "Petrol";
            // 
            // PetrolComboBox
            // 
            PetrolComboBox.Font = new Font("Calibri", 12F);
            PetrolComboBox.FormattingEnabled = true;
            PetrolComboBox.Location = new Point(74, 22);
            PetrolComboBox.Name = "PetrolComboBox";
            PetrolComboBox.Size = new Size(150, 27);
            PetrolComboBox.TabIndex = 0;
            PetrolComboBox.SelectedIndexChanged += PetrolComboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FoodBox4Amount);
            groupBox2.Controls.Add(FoodBox4Price);
            groupBox2.Controls.Add(FoodBox4);
            groupBox2.Controls.Add(FoodBox3Amount);
            groupBox2.Controls.Add(FoodBox3Price);
            groupBox2.Controls.Add(FoodBox3);
            groupBox2.Controls.Add(FoodBox2Amount);
            groupBox2.Controls.Add(FoodBox2Price);
            groupBox2.Controls.Add(FoodBox2);
            groupBox2.Controls.Add(FoodBox1Amount);
            groupBox2.Controls.Add(FoodBox1Price);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(FoodBox1);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Location = new Point(247, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 289);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mini cafe";
            // 
            // FoodBox4Amount
            // 
            FoodBox4Amount.Font = new Font("Calibri", 12F);
            FoodBox4Amount.Location = new Point(202, 152);
            FoodBox4Amount.Name = "FoodBox4Amount";
            FoodBox4Amount.Size = new Size(64, 27);
            FoodBox4Amount.TabIndex = 28;
            FoodBox4Amount.Leave += FoodBoxAmount_Leave;
            // 
            // FoodBox4Price
            // 
            FoodBox4Price.Font = new Font("Calibri", 12F);
            FoodBox4Price.Location = new Point(134, 152);
            FoodBox4Price.Name = "FoodBox4Price";
            FoodBox4Price.ReadOnly = true;
            FoodBox4Price.Size = new Size(61, 27);
            FoodBox4Price.TabIndex = 26;
            // 
            // FoodBox4
            // 
            FoodBox4.Font = new Font("Calibri", 12F);
            FoodBox4.Location = new Point(6, 152);
            FoodBox4.Name = "FoodBox4";
            FoodBox4.Size = new Size(122, 23);
            FoodBox4.TabIndex = 27;
            FoodBox4.Text = "checkBox3";
            FoodBox4.UseVisualStyleBackColor = true;
            FoodBox4.CheckedChanged += FoodBox_CheckedChanged;
            // 
            // FoodBox3Amount
            // 
            FoodBox3Amount.Font = new Font("Calibri", 12F);
            FoodBox3Amount.Location = new Point(202, 119);
            FoodBox3Amount.Name = "FoodBox3Amount";
            FoodBox3Amount.Size = new Size(64, 27);
            FoodBox3Amount.TabIndex = 25;
            FoodBox3Amount.Leave += FoodBoxAmount_Leave;
            // 
            // FoodBox3Price
            // 
            FoodBox3Price.Font = new Font("Calibri", 12F);
            FoodBox3Price.Location = new Point(134, 119);
            FoodBox3Price.Name = "FoodBox3Price";
            FoodBox3Price.ReadOnly = true;
            FoodBox3Price.Size = new Size(61, 27);
            FoodBox3Price.TabIndex = 23;
            // 
            // FoodBox3
            // 
            FoodBox3.Font = new Font("Calibri", 12F);
            FoodBox3.Location = new Point(6, 119);
            FoodBox3.Name = "FoodBox3";
            FoodBox3.Size = new Size(122, 23);
            FoodBox3.TabIndex = 24;
            FoodBox3.Text = "checkBox4";
            FoodBox3.UseVisualStyleBackColor = true;
            FoodBox3.CheckedChanged += FoodBox_CheckedChanged;
            // 
            // FoodBox2Amount
            // 
            FoodBox2Amount.Font = new Font("Calibri", 12F);
            FoodBox2Amount.Location = new Point(202, 88);
            FoodBox2Amount.Name = "FoodBox2Amount";
            FoodBox2Amount.Size = new Size(64, 27);
            FoodBox2Amount.TabIndex = 22;
            FoodBox2Amount.Leave += FoodBoxAmount_Leave;
            // 
            // FoodBox2Price
            // 
            FoodBox2Price.Font = new Font("Calibri", 12F);
            FoodBox2Price.Location = new Point(134, 88);
            FoodBox2Price.Name = "FoodBox2Price";
            FoodBox2Price.ReadOnly = true;
            FoodBox2Price.Size = new Size(61, 27);
            FoodBox2Price.TabIndex = 20;
            // 
            // FoodBox2
            // 
            FoodBox2.Font = new Font("Calibri", 12F);
            FoodBox2.Location = new Point(6, 88);
            FoodBox2.Name = "FoodBox2";
            FoodBox2.Size = new Size(122, 23);
            FoodBox2.TabIndex = 21;
            FoodBox2.Text = "checkBox2";
            FoodBox2.UseVisualStyleBackColor = true;
            FoodBox2.CheckedChanged += FoodBox_CheckedChanged;
            // 
            // FoodBox1Amount
            // 
            FoodBox1Amount.Font = new Font("Calibri", 12F);
            FoodBox1Amount.Location = new Point(202, 55);
            FoodBox1Amount.Name = "FoodBox1Amount";
            FoodBox1Amount.Size = new Size(64, 27);
            FoodBox1Amount.TabIndex = 19;
            FoodBox1Amount.Leave += FoodBoxAmount_Leave;
            // 
            // FoodBox1Price
            // 
            FoodBox1Price.Font = new Font("Calibri", 12F);
            FoodBox1Price.Location = new Point(134, 55);
            FoodBox1Price.Name = "FoodBox1Price";
            FoodBox1Price.ReadOnly = true;
            FoodBox1Price.Size = new Size(61, 27);
            FoodBox1Price.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(205, 24);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 18;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(144, 24);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // FoodBox1
            // 
            FoodBox1.Font = new Font("Calibri", 12F);
            FoodBox1.Location = new Point(6, 55);
            FoodBox1.Name = "FoodBox1";
            FoodBox1.Size = new Size(122, 23);
            FoodBox1.TabIndex = 14;
            FoodBox1.Text = "checkBox1";
            FoodBox1.UseVisualStyleBackColor = true;
            FoodBox1.CheckedChanged += FoodBox_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(FoodPayment);
            groupBox5.Font = new Font("Calibri", 12F);
            groupBox5.Location = new Point(6, 187);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(258, 88);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "To payment";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(221, 48);
            label11.Name = "label11";
            label11.Size = new Size(27, 33);
            label11.TabIndex = 12;
            label11.Text = "₴";
            // 
            // FoodPayment
            // 
            FoodPayment.Font = new Font("Calibri", 28F);
            FoodPayment.Location = new Point(6, 23);
            FoodPayment.Name = "FoodPayment";
            FoodPayment.Size = new Size(209, 58);
            FoodPayment.TabIndex = 12;
            FoodPayment.Text = "Price";
            FoodPayment.TextAlign = ContentAlignment.BottomRight;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(CalculateButton);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(TotalPayment);
            groupBox6.Font = new Font("Calibri", 12F);
            groupBox6.Location = new Point(11, 310);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(511, 100);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Total payment";
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CalculateButton.Location = new Point(12, 26);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(218, 68);
            CalculateButton.TabIndex = 15;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.MouseClick += CalculateButton_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(463, 49);
            label6.Name = "label6";
            label6.Size = new Size(27, 33);
            label6.TabIndex = 13;
            label6.Text = "₴";
            // 
            // TotalPayment
            // 
            TotalPayment.Font = new Font("Calibri", 28F);
            TotalPayment.Location = new Point(248, 26);
            TotalPayment.Name = "TotalPayment";
            TotalPayment.Size = new Size(209, 56);
            TotalPayment.TabIndex = 14;
            TotalPayment.Text = "Price";
            TotalPayment.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 421);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BestOil";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PetrolGroupBox.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox PetrolPrice;
        private Label label2;
        private Label label1;
        private ComboBox PetrolComboBox;
        private TextBox LitersTextBox;
        private GroupBox groupBox3;
        private RadioButton NumberRadioButton;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private TextBox PriceTextBox;
        private RadioButton PriceRadioButton;
        private GroupBox PetrolGroupBox;
        private Label PetrolPaymentSign;
        private Label PetrolPayment;
        private GroupBox groupBox5;
        private Label label11;
        private Label FoodPayment;
        private TextBox FoodBox4Amount;
        private TextBox FoodBox4Price;
        private CheckBox FoodBox4;
        private TextBox FoodBox3Amount;
        private TextBox FoodBox3Price;
        private CheckBox FoodBox3;
        private TextBox FoodBox2Amount;
        private TextBox FoodBox2Price;
        private CheckBox FoodBox2;
        private TextBox FoodBox1Amount;
        private TextBox FoodBox1Price;
        private Label label5;
        private Label label4;
        private CheckBox FoodBox1;
        private GroupBox groupBox6;
        private Button CalculateButton;
        private Label label6;
        private Label TotalPayment;
    }
}
