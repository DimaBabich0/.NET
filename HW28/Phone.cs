using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW28
{
    internal class Phone
    {
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Phone(string title, string manufacturer, int price, DateTime releaseDate)
        {
            Title = title;
            Manufacturer = manufacturer;
            Price = price;
            ReleaseDate = releaseDate;
        }
        public override string ToString()
        {
            return $"Title: {Title};\n" +
                $"Manufacturer: {Manufacturer};\n" +
                $"Price: {Price}$;\n" +
                $"ReleaseDate: {ReleaseDate.ToString("dd/MM/yyyy")};";
        }
    }
}
