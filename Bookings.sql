Create Table BookingsTable
(
BookingId int Not Null Primary Key,
AppointmentDate Date,
AppointmentTime Time,
BookingStatus nvarchar(50),
ServiceId int,
CustomerId int,
StylistId int,
FOREIGN KEY (ServiceId) REFERENCES Services(ServiceId),
Foreign KEY (CustomerId) REFERENCES Customers(CustomerId),
FOREIGN KEY (StylistId) REFERENCES Stylist(StylistId),


)