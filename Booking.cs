using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Booking.models_1
{
    public class Booking
    {
        public Guid Id { get; set; } //Unique identifier for the booking

        public Guid CustomerId { get; set; }  // Unique identifier for the customer

        public Guid StytlistId { get; set; } // Unique identifier for the stylist

        public required string ServiceName { get; set; } // Name of the service being booked

        public DateTime AppointmentDate { get; set; } // Date and time of the appointment

        public BookingStatus Status { get; set; } = BookingStatus.Pending; // Status of the booking, default is Pending


        public Booking(Guid id, Guid customerId, Guid stylistId, string serviceName, DateTime appointmentDate)
        {
            Id = id;
            CustomerId = customerId;
            StytlistId = stylistId;
            ServiceName = serviceName;
            AppointmentDate = appointmentDate;
        }
    }
public enum BookingStatus
    {
        Pending,
        Confirmed,
        Completed,
        Cancelled
    }
}
