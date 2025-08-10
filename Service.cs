using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Booking.models_1
{
    internal class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }// Name of the service
        public decimal Price { get; set; } // Price of the service
        public Service(int id, string name, decimal price, int duration, string description)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}
