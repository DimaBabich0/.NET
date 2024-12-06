namespace HW04
{
    public partial class Form1 : Form
    {
        Petrol[] petrols =
        {
            new Petrol("А 95+", 60.49),
            new Petrol("А 95", 55.99),
            new Petrol("А 92", 51.99)
        };
        FoodBox[] foodBoxes;

        public Form1()
        {
            InitializeComponent();

            var petrolsTitle = petrols.Select(p => p.Title).ToArray();
            PetrolComboBox.Items.AddRange(petrolsTitle);

            PriceTextBox.Enabled = false;
            LitersTextBox.Enabled = false;

            foodBoxes = new FoodBox[]
            {
                new FoodBox(new Food("Hot dog", 32.59),
                FoodBox1, FoodBox1Price, FoodBox1Amount),
                new FoodBox(new Food("Donut", 15.99),
                FoodBox2, FoodBox2Price, FoodBox2Amount),
                new FoodBox(new Food("Coffee", 21.29),
                FoodBox3, FoodBox3Price, FoodBox3Amount),
                new FoodBox(new Food("Chocolate bar", 19.99),
                FoodBox4, FoodBox4Price, FoodBox4Amount)
            };

            foreach (var foodBox in foodBoxes)
            {
                foodBox.Amount.Enabled = false;
            }

            PetrolPayment.Text = "0.00";
            FoodPayment.Text = "0.00";
            TotalPayment.Text = "0.00";
        }

        private void CountFoodTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (FoodBox foodBox in foodBoxes)
            {
                if (foodBox.Amount.Text != string.Empty)
                {
                    totalPrice += Convert.ToDouble(foodBox.Amount.Text) * Convert.ToDouble(foodBox.Price.Text);
                }
            }
            FoodPayment.Text = totalPrice.ToString("0.00");
        }

        private void PetrolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedPetrol = PetrolComboBox.SelectedItem as string;
            foreach (var petrol in petrols)
            {
                if (petrol.Title == SelectedPetrol)
                {
                    PetrolPrice.Text = petrol.Price.ToString();
                    break;
                }
            }
        }

        private void NumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LitersTextBox.Enabled = true;

            PriceTextBox.Enabled = false;
            PriceTextBox.Text = string.Empty;

            PetrolGroupBox.Text = "To payment";
            PetrolPayment.Text = "0";
            PetrolPaymentSign.Text = "₴";
        }

        private void PriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PriceTextBox.Enabled = true;

            LitersTextBox.Enabled = false;
            LitersTextBox.Text = string.Empty;

            PetrolGroupBox.Text = "To fill";
            PetrolPayment.Text = "0";
            PetrolPaymentSign.Text = "lit.";
        }

        private void FoodBox_CheckedChanged(object sender, EventArgs e)
        {
            string foodTitle = (sender as CheckBox).Text;

            FoodBox foodBox = foodBoxes.FirstOrDefault(f => f.Food.Title == foodTitle);

            if (foodBox != null)
            {
                if ((sender as CheckBox).Checked)
                {
                    foodBox.Amount.Enabled = true;
                    foodBox.Amount.Text = "1";
                    CountFoodTotalPrice();
                }
                else
                {
                    foodBox.Amount.Enabled = false;
                    foodBox.Amount.Text = string.Empty;
                }
            }
        }

        private void LitersTextBox_Leave(object sender, EventArgs e)
        {
            if (LitersTextBox.Text != string.Empty &&
                PetrolComboBox.SelectedItem != null)
            {
                double res = Convert.ToDouble(PetrolPrice.Text) * Convert.ToDouble(LitersTextBox.Text);
                PetrolPayment.Text = res.ToString();
            }
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            if (PriceTextBox.Text != string.Empty &&
                PetrolComboBox.SelectedItem != null)
            {
                double res = Convert.ToDouble(PriceTextBox.Text) / Convert.ToDouble(PetrolPrice.Text);
                PetrolPayment.Text = res.ToString("0.00");
            }
        }

        private void FoodBoxAmount_Leave(object sender, EventArgs e)
        {
            CountFoodTotalPrice();
        }

        private void CalculateButton_MouseClick(object sender, MouseEventArgs e)
        {
            double totalPayment = 0.0;
            
            if (FoodPayment.Text != "0.00")
                totalPayment += Convert.ToDouble(FoodPayment.Text);

            if (NumberRadioButton.Checked == true)
            {
                totalPayment += Convert.ToDouble(LitersTextBox.Text) * Convert.ToDouble(PetrolPrice.Text);
            }
            else if (PriceRadioButton.Checked == true)
            {
                totalPayment += Convert.ToDouble(PriceTextBox.Text);
            }

            TotalPayment.Text = totalPayment.ToString("0.00");
        }
    }
}
