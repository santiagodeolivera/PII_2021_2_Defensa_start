using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

        public string AsText()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Fecha: ");
            builder.AppendLine(this.EndDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));

            foreach(PublicationItem item in this.items)
            {
                builder.AppendLine(item.AsText());
            }

            return builder.ToString();
        }
    }
}