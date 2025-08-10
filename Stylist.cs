using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Booking.models_1
{
    public class Stylist
    { public Guid Id { get; set; } // Unique identifier for the stylist
        public required string FirstName { get; set; } // First name of the stylist
        public required string LastName { get; set; } // Last name of the stylist
        public required string Email { get; set; } // Email address of the stylist
        public required string PhoneNumber { get; set; } // Phone number of the stylist
        public Stylist(Guid id, string firstName, string lastName, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
