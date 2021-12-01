using System;
using System.Text;

namespace Ucu.Poo.Defense
{
    public class PublicationItem
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public PublicationItem(Material material, int quantity, int price)
        {
            this.Material = material;
            this.Quantity = quantity;
            this.Price = price;
        }

        // Añadido por el patrón "Don't talk to strangers".
        public string AsText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(this.Quantity);
            builder.Append(" de ");
            builder.Append(this.Material.Name);
            builder.Append(" a $");
            builder.Append(this.Price);

            return builder.ToString();
        }
    }
}