using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    internal class Food
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public Food(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }

    internal class FoodBox
    {
        public Food Food;
        public CheckBox Title;
        public TextBox Price;
        public TextBox Amount;

        public FoodBox(Food food, CheckBox title, TextBox price, TextBox amount)
        {
            Food = food;
            Title = title;
            Price = price;
            Amount = amount;

            Title.Text = Food.Title;
            Price.Text = Food.Price.ToString();
        }
    }
}
